// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The integration account session filter.
    /// </summary>
    public partial class IntegrationAccountSessionFilter
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountSessionFilter
        /// class.
        /// </summary>
        public IntegrationAccountSessionFilter() { }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountSessionFilter
        /// class.
        /// </summary>
        /// <param name="changedTime">The changed time of integration account
        /// sessions.</param>
        public IntegrationAccountSessionFilter(System.DateTime changedTime)
        {
            ChangedTime = changedTime;
        }

        /// <summary>
        /// Gets or sets the changed time of integration account sessions.
        /// </summary>
        [JsonProperty(PropertyName = "changedTime")]
        public System.DateTime ChangedTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
