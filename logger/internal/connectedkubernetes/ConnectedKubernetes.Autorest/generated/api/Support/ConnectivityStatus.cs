// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support
{

    /// <summary>Represents the connectivity status of the connected cluster.</summary>
    public partial struct ConnectivityStatus :
        System.IEquatable<ConnectivityStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectivityStatus Connected = @"Connected";

        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectivityStatus Connecting = @"Connecting";

        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectivityStatus Expired = @"Expired";

        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectivityStatus Offline = @"Offline";

        /// <summary>the value for an instance of the <see cref="ConnectivityStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ConnectivityStatus"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ConnectivityStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ConnectivityStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ConnectivityStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ConnectivityStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ConnectivityStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectivityStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ConnectivityStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ConnectivityStatus && Equals((ConnectivityStatus)obj);
        }

        /// <summary>Returns hashCode for enum ConnectivityStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ConnectivityStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ConnectivityStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ConnectivityStatus" />.</param>

        public static implicit operator ConnectivityStatus(string value)
        {
            return new ConnectivityStatus(value);
        }

        /// <summary>Implicit operator to convert ConnectivityStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ConnectivityStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectivityStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ConnectivityStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectivityStatus e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectivityStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ConnectivityStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectivityStatus e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectivityStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}