// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StreamAnalytics;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An output object, containing all information associated with the named
    /// output. All outputs are contained under a streaming job.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Output : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the Output class.
        /// </summary>
        public Output()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Output class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="datasource">Describes the data source that output will
        /// be written to. Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="serialization">Describes how data from an input is
        /// serialized or how data is serialized when written to an output.
        /// Required on PUT (CreateOrReplace) requests.</param>
        /// <param name="diagnostics">Describes conditions applicable to the
        /// Input, Output, or the job overall, that warrant customer
        /// attention.</param>
        /// <param name="etag">The current entity tag for the output. This is
        /// an opaque string. You can use it to detect whether the resource has
        /// changed between requests. You can also use it in the If-Match or
        /// If-None-Match headers for write operations for optimistic
        /// concurrency.</param>
        public Output(string id = default(string), string name = default(string), string type = default(string), OutputDataSource datasource = default(OutputDataSource), Serialization serialization = default(Serialization), Diagnostics diagnostics = default(Diagnostics), string etag = default(string))
            : base(id, name, type)
        {
            Datasource = datasource;
            Serialization = serialization;
            Diagnostics = diagnostics;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes the data source that output will be written
        /// to. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.datasource")]
        public OutputDataSource Datasource { get; set; }

        /// <summary>
        /// Gets or sets describes how data from an input is serialized or how
        /// data is serialized when written to an output. Required on PUT
        /// (CreateOrReplace) requests.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serialization")]
        public Serialization Serialization { get; set; }

        /// <summary>
        /// Gets describes conditions applicable to the Input, Output, or the
        /// job overall, that warrant customer attention.
        /// </summary>
        [JsonProperty(PropertyName = "properties.diagnostics")]
        public Diagnostics Diagnostics { get; private set; }

        /// <summary>
        /// Gets the current entity tag for the output. This is an opaque
        /// string. You can use it to detect whether the resource has changed
        /// between requests. You can also use it in the If-Match or
        /// If-None-Match headers for write operations for optimistic
        /// concurrency.
        /// </summary>
        [JsonProperty(PropertyName = "properties.etag")]
        public string Etag { get; private set; }

    }
}
