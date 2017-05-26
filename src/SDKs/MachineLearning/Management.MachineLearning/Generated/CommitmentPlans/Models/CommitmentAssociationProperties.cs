// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.CommitmentPlans.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of an Azure ML commitment association.
    /// </summary>
    public partial class CommitmentAssociationProperties
    {
        /// <summary>
        /// Initializes a new instance of the CommitmentAssociationProperties
        /// class.
        /// </summary>
        public CommitmentAssociationProperties() { }

        /// <summary>
        /// Initializes a new instance of the CommitmentAssociationProperties
        /// class.
        /// </summary>
        /// <param name="associatedResourceId">The ID of the resource this
        /// association points to, such as the ARM ID of an Azure ML web
        /// service.</param>
        /// <param name="commitmentPlanId">The ARM ID of the parent Azure ML
        /// commitment plan.</param>
        /// <param name="creationDate">The date at which this commitment
        /// association was created, in ISO 8601 format.</param>
        public CommitmentAssociationProperties(string associatedResourceId = default(string), string commitmentPlanId = default(string), System.DateTime? creationDate = default(System.DateTime?))
        {
            AssociatedResourceId = associatedResourceId;
            CommitmentPlanId = commitmentPlanId;
            CreationDate = creationDate;
        }

        /// <summary>
        /// Gets the ID of the resource this association points to, such as
        /// the ARM ID of an Azure ML web service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "associatedResourceId")]
        public string AssociatedResourceId { get; private set; }

        /// <summary>
        /// Gets the ARM ID of the parent Azure ML commitment plan.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "commitmentPlanId")]
        public string CommitmentPlanId { get; private set; }

        /// <summary>
        /// Gets the date at which this commitment association was created, in
        /// ISO 8601 format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "creationDate")]
        public System.DateTime? CreationDate { get; private set; }

    }
}