// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Represents a Upgrade Hint.
    /// </summary>
    public partial class UpgradeHintInner : Microsoft.Azure.Management.Resource.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the UpgradeHintInner class.
        /// </summary>
        public UpgradeHintInner() { }

        /// <summary>
        /// Initializes a new instance of the UpgradeHintInner class.
        /// </summary>
        /// <param
        /// name="targetServiceLevelObjective">TargetServiceLevelObjective
        /// for upgrade hint.</param>
        /// <param
        /// name="targetServiceLevelObjectiveId">TargetServiceLevelObjectiveId
        /// for upgrade hint.</param>
        public UpgradeHintInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string targetServiceLevelObjective = default(string), System.Guid? targetServiceLevelObjectiveId = default(System.Guid?))
            : base(location, id, name, type, tags)
        {
            TargetServiceLevelObjective = targetServiceLevelObjective;
            TargetServiceLevelObjectiveId = targetServiceLevelObjectiveId;
        }

        /// <summary>
        /// Gets or sets targetServiceLevelObjective for upgrade hint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetServiceLevelObjective")]
        public string TargetServiceLevelObjective { get; set; }

        /// <summary>
        /// Gets or sets targetServiceLevelObjectiveId for upgrade hint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetServiceLevelObjectiveId")]
        public System.Guid? TargetServiceLevelObjectiveId { get; set; }

    }
}