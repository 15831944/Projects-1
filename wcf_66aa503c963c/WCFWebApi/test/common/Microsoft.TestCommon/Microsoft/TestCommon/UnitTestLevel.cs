﻿// <copyright>
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>

namespace Microsoft.TestCommon
{
    using System;

    /// <summary>
    /// Enumeration of possible levels for a unit test.  This level is set
    /// using <see cref="UnitTestLevelAttribute"/>.
    /// </summary>
    public enum UnitTestLevel
    {
        /// <summary>
        /// Test is largely empty or stubbed out.
        /// This test will not be validated.
        /// </summary>
        None = 0,

        /// <summary>
        /// Some tests are runnable but the test is not ready for check in.
        /// This test will show as "Inconclusive" if run in MSTest even if
        /// it passes basic level of verifications.
        /// </summary>
        NotReady = 1,

        /// <summary>
        /// Most tests have been implemented and are runnable, but
        /// the test is yet not considered complete.
        /// This test will show as "Passed" in MSTest if it
        /// passes the basic levels of verification.
        /// </summary>
        InProgress = 2,

        /// <summary>
        /// Tests are complete and merit deeper verification.
        /// This test will show as "Pass" if run in MSTest only
        /// if it meets all the verification.
        /// </summary>
        Complete = 3
    }
}
