// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support
{

    /// <summary>
    /// Indicates whether the Arc agents on the be upgraded automatically to the latest version. Defaults to Enabled.
    /// </summary>
    public partial struct AutoUpgradeOptions :
        System.IEquatable<AutoUpgradeOptions>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AutoUpgradeOptions Disabled = @"Disabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AutoUpgradeOptions Enabled = @"Enabled";

        /// <summary>the value for an instance of the <see cref="AutoUpgradeOptions" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="AutoUpgradeOptions"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private AutoUpgradeOptions(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to AutoUpgradeOptions</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AutoUpgradeOptions" />.</param>
        internal static object CreateFrom(object value)
        {
            return new AutoUpgradeOptions(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type AutoUpgradeOptions</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AutoUpgradeOptions e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type AutoUpgradeOptions (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is AutoUpgradeOptions && Equals((AutoUpgradeOptions)obj);
        }

        /// <summary>Returns hashCode for enum AutoUpgradeOptions</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for AutoUpgradeOptions</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to AutoUpgradeOptions</summary>
        /// <param name="value">the value to convert to an instance of <see cref="AutoUpgradeOptions" />.</param>

        public static implicit operator AutoUpgradeOptions(string value)
        {
            return new AutoUpgradeOptions(value);
        }

        /// <summary>Implicit operator to convert AutoUpgradeOptions to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="AutoUpgradeOptions" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AutoUpgradeOptions e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum AutoUpgradeOptions</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AutoUpgradeOptions e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AutoUpgradeOptions e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum AutoUpgradeOptions</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AutoUpgradeOptions e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.AutoUpgradeOptions e2)
        {
            return e2.Equals(e1);
        }
    }
}