// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Dns.Models
{
    using Azure;
    using Management;
    using Dns;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An NS record.
    /// </summary>
    public partial class NsRecord
    {
        /// <summary>
        /// Initializes a new instance of the NsRecord class.
        /// </summary>
        public NsRecord() { }

        /// <summary>
        /// Initializes a new instance of the NsRecord class.
        /// </summary>
        /// <param name="nsdname">The name server name for this NS
        /// record.</param>
        public NsRecord(string nsdname = default(string))
        {
            Nsdname = nsdname;
        }

        /// <summary>
        /// Gets or sets the name server name for this NS record.
        /// </summary>
        [JsonProperty(PropertyName = "nsdname")]
        public string Nsdname { get; set; }

    }
}

