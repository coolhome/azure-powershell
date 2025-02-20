// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Extensions;

    /// <summary>The response of a FirewallStatusResource list operation.</summary>
    public partial class FirewallStatusResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IFirewallStatusResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IFirewallStatusResourceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IFirewallStatusResource[] _value;

        /// <summary>The items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Origin(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IFirewallStatusResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="FirewallStatusResourceListResult" /> instance.</summary>
        public FirewallStatusResourceListResult()
        {

        }
    }
    /// The response of a FirewallStatusResource list operation.
    public partial interface IFirewallStatusResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IFirewallStatusResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IFirewallStatusResource[] Value { get; set; }

    }
    /// The response of a FirewallStatusResource list operation.
    internal partial interface IFirewallStatusResourceListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The items on this page</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PaloAltoNetworks.Models.Api20220829.IFirewallStatusResource[] Value { get; set; }

    }
}