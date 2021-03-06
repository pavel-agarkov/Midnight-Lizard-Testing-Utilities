﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace MidnightLizard.Testing.Utilities
{
    /// <summary>
    /// Xunit Fact with custom test name processing
    /// </summary>
    public class ItAttribute : FactAttribute
    {
        public ItAttribute(string it, [CallerMemberName]string should = "should work") : base()
        {
            //DisplayName = Regex.Replace(Regex.Replace(Regex.Replace(
            //    displayName, @"((?:[A-Z])+[^A-Z]*)", "$1 "), "_", " "), "  ", " ")
            //    .Trim().ToLower();

            //DisplayName = string.Join(" ", Regex
            //    .Split(displayName, @"_|((?:[A-Z])+[^A-Z_]*)")
            //    .Select(x => x.Trim()));

            DisplayName = $"{it} - {should}".Replace("__", ".").Replace("_", " ");
        }

    }

    /// <summary>
    /// Disable a test
    /// </summary>
    public class XItAttribute : FactAttribute
    {
        public XItAttribute(string it, string should = "should be disabled") : base()
        {
            Skip = "Test is skipped";
        }
    }
}
