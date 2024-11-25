// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support
{

    /// <summary>Indicates the kind of Arc connected cluster based on host infrastructure.</summary>
    public partial struct ConnectedClusterKind :
        System.IEquatable<ConnectedClusterKind>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectedClusterKind ProvisionedCluster = @"ProvisionedCluster";

        /// <summary>the value for an instance of the <see cref="ConnectedClusterKind" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ConnectedClusterKind"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ConnectedClusterKind(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ConnectedClusterKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ConnectedClusterKind" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ConnectedClusterKind(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ConnectedClusterKind</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectedClusterKind e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ConnectedClusterKind (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ConnectedClusterKind && Equals((ConnectedClusterKind)obj);
        }

        /// <summary>Returns hashCode for enum ConnectedClusterKind</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ConnectedClusterKind</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ConnectedClusterKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ConnectedClusterKind" />.</param>

        public static implicit operator ConnectedClusterKind(string value)
        {
            return new ConnectedClusterKind(value);
        }

        /// <summary>Implicit operator to convert ConnectedClusterKind to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ConnectedClusterKind" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectedClusterKind e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ConnectedClusterKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectedClusterKind e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectedClusterKind e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ConnectedClusterKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectedClusterKind e1, Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Support.ConnectedClusterKind e2)
        {
            return e2.Equals(e1);
        }
    }
}