// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Cdn;
    using Microsoft.Azure.Management.Cdn.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters required for content purge.
    /// </summary>
    public partial class PurgeParameters
    {
        /// <summary>
        /// Initializes a new instance of the PurgeParameters class.
        /// </summary>
        public PurgeParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PurgeParameters class.
        /// </summary>
        /// <param name="contentPaths">The path to the content to be purged.
        /// Can describe a file path or a wild card directory.</param>
        public PurgeParameters(IList<string> contentPaths)
        {
            ContentPaths = contentPaths;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the path to the content to be purged. Can describe a
        /// file path or a wild card directory.
        /// </summary>
        [JsonProperty(PropertyName = "contentPaths")]
        public IList<string> ContentPaths { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ContentPaths == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContentPaths");
            }
        }
    }
}