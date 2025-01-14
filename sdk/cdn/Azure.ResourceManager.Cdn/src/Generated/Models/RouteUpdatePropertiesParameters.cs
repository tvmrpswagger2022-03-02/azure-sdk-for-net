// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The JSON object that contains the properties of the domain to create. </summary>
    internal partial class RouteUpdatePropertiesParameters
    {
        /// <summary> Initializes a new instance of RouteUpdatePropertiesParameters. </summary>
        internal RouteUpdatePropertiesParameters()
        {
            CustomDomains = new ChangeTrackingList<ActivatedResourceReference>();
            RuleSets = new ChangeTrackingList<WritableSubResource>();
            SupportedProtocols = new ChangeTrackingList<AfdEndpointProtocols>();
            PatternsToMatch = new ChangeTrackingList<string>();
        }

        /// <summary> The name of the endpoint which holds the route. </summary>
        public string EndpointName { get; }
        /// <summary> Domains referenced by this endpoint. </summary>
        public IReadOnlyList<ActivatedResourceReference> CustomDomains { get; }
        /// <summary> A reference to the origin group. </summary>
        internal WritableSubResource OriginGroup { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier OriginGroupId
        {
            get => OriginGroup?.Id;
        }

        /// <summary> A directory path on the origin that AzureFrontDoor can use to retrieve content from, e.g. contoso.cloudapp.net/originpath. </summary>
        public string OriginPath { get; }
        /// <summary> rule sets referenced by this endpoint. </summary>
        public IReadOnlyList<WritableSubResource> RuleSets { get; }
        /// <summary> List of supported protocols for this route. </summary>
        public IReadOnlyList<AfdEndpointProtocols> SupportedProtocols { get; }
        /// <summary> The route patterns of the rule. </summary>
        public IReadOnlyList<string> PatternsToMatch { get; }
        /// <summary> The caching configuration for this route. To disable caching, do not provide a cacheConfiguration object. </summary>
        public AfdRouteCacheConfiguration CacheConfiguration { get; }
        /// <summary> Protocol this rule will use when forwarding traffic to backends. </summary>
        public ForwardingProtocol? ForwardingProtocol { get; }
        /// <summary> whether this route will be linked to the default endpoint domain. </summary>
        public LinkToDefaultDomain? LinkToDefaultDomain { get; }
        /// <summary> Whether to automatically redirect HTTP traffic to HTTPS traffic. Note that this is a easy way to set up this rule and it will be the first rule that gets executed. </summary>
        public HttpsRedirect? HttpsRedirect { get; }
        /// <summary> Whether to enable use of this rule. Permitted values are &apos;Enabled&apos; or &apos;Disabled&apos;. </summary>
        public EnabledState? EnabledState { get; }
    }
}
