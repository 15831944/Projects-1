﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http.Headers;

namespace Microsoft.Net.Http.Test.Headers.GenericHeaderParserTest
{
    [TestClass]
    public class NameValueWithParametersParserTest
    {
        [TestMethod]
        public void Properties_ReadValues_MatchExpectation()
        {
            HttpHeaderParser parser = GenericHeaderParser.MultipleValueNameValueWithParametersParser;
            Assert.IsTrue(parser.SupportsMultipleValues, "SupportsMultipleValues");
            Assert.IsNull(parser.Comparer, "Comparer");

            parser = GenericHeaderParser.SingleValueNameValueWithParametersParser;
            Assert.IsFalse(parser.SupportsMultipleValues, "SupportsMultipleValues");
            Assert.IsNull(parser.Comparer, "Comparer");
        }

        [TestMethod]
        public void Parse_ValidValue_ReturnsNameValueWithParametersHeaderValue()
        {
            // This test verifies that Parse() correctly calls TryParse().
            HttpHeaderParser parser = GenericHeaderParser.MultipleValueNameValueWithParametersParser;
            int index = 2;

            NameValueWithParametersHeaderValue expected = new NameValueWithParametersHeaderValue("custom");
            expected.Parameters.Add(new NameValueHeaderValue("name", "value"));
            Assert.IsTrue(expected.Equals(parser.ParseValue("   custom ; name = value ", null, ref index)));
            Assert.AreEqual(25, index, "Returned index.");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Parse_InvalidValue_Throw()
        {
            // This test verifies that Parse() correctly calls TryParse().
            HttpHeaderParser parser = GenericHeaderParser.MultipleValueNameValueWithParametersParser;
            int index = 0;
            parser.ParseValue("custom;=value", null, ref index);
        }

        [TestMethod]
        public void TryParse_SetOfValidValueStrings_ParsedCorrectly()
        {
            NameValueWithParametersHeaderValue expected = new NameValueWithParametersHeaderValue("custom");
            CheckValidParsedValue("\r\n custom  ", 0, expected, 11);
            CheckValidParsedValue("custom", 0, expected, 6);
            CheckValidParsedValue(",, ,\r\n custom  , chunked", 0, expected, 17);

            // Note that even if the whole string is invalid, the first "Expect" value is valid. When the parser
            // gets called again using the result-index (9), then it fails: I.e. we have 1 valid "Expect" value
            // and an invalid one.
            CheckValidParsedValue("custom , 会", 0, expected, 9);

            // We don't have to test all possible input strings, since most of the pieces are handled by other parsers.
            // The purpose of this test is to verify that these other parsers are combined correctly to build a
            // transfer-coding parser.
            expected.Parameters.Add(new NameValueHeaderValue("name", "value"));
            CheckValidParsedValue("\r\n custom ;  name =   value ", 0, expected, 28);
            CheckValidParsedValue("  custom;name=value", 2, expected, 19);
            CheckValidParsedValue("  custom ; name=value", 2, expected, 21);

            CheckValidParsedValue(null, 0, null, 0);
            CheckValidParsedValue(string.Empty, 0, null, 0);
            CheckValidParsedValue("  ", 0, null, 2);
            CheckValidParsedValue("  ,,", 0, null, 4);
        }

        [TestMethod]
        public void TryParse_SetOfInvalidValueStrings_ReturnsFalse()
        {
            CheckInvalidParsedValue("custom会", 0);
            CheckInvalidParsedValue("custom; name=value;", 0);
            CheckInvalidParsedValue("custom; name1=value1; name2=value2;", 0);
        }

        #region Helper methods

        private void CheckValidParsedValue(string input, int startIndex,
            NameValueWithParametersHeaderValue expectedResult, int expectedIndex)
        {
            HttpHeaderParser parser = GenericHeaderParser.MultipleValueNameValueWithParametersParser;
            object result = null;
            Assert.IsTrue(parser.TryParseValue(input, null, ref startIndex, out result),
                "TryParse returned false. Input: '{0}', Index: {1}", input, startIndex);
            Assert.AreEqual(expectedIndex, startIndex, "Returned index. Input: '{0}'", input);
            Assert.AreEqual(result, expectedResult, "Result doesn't match expected object. Input: '{0}'", input);
        }

        private void CheckInvalidParsedValue(string input, int startIndex)
        {
            HttpHeaderParser parser = GenericHeaderParser.MultipleValueNameValueWithParametersParser;
            object result = null;
            int newIndex = startIndex;
            Assert.IsFalse(parser.TryParseValue(input, null, ref newIndex, out result),
                "TryParse returned true. Input: '{0}', Index: {1}", input, startIndex);
            Assert.AreEqual(null, result, "Parsed value");
            Assert.AreEqual(startIndex, newIndex, "Returned index");
        }

        #endregion
    }
}
