﻿using System.Text.RegularExpressions;

namespace System.ComponentModel.DataAnnotations
{
    /// <summary>
    /// Validation attribute ensuring that specified string value is valid MAC address.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public sealed class MacAddressValidationAttribute : ValidationAttribute
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public MacAddressValidationAttribute()
        {
            _regex = new Regex("^([0-9A-F]{2}[:-]){5}([0-9A-F]{2})$", RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled);
        }
        #endregion

        #region STATIC FIELDS
        private static Regex _regex;
        #endregion

        #region OVERRIDES
        /// <summary>
        /// Gets if value is valid.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <returns>True or false.</returns>
        public override bool IsValid(object value)
        {
            string macAddress = value as string;
            return string.IsNullOrWhiteSpace(macAddress) || _regex.Match(macAddress).Length > 0;
        }
        #endregion
    }
}
