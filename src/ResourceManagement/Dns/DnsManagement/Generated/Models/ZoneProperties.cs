// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;

namespace Microsoft.Azure.Management.Dns.Models
{
    /// <summary>
    /// Represents the properties of the zone.
    /// </summary>
    public partial class ZoneProperties
    {
        private long? _maxNumberOfRecordSets;
        
        /// <summary>
        /// Optional. Gets or sets the maximum number of record sets that can
        /// be created in this zone.
        /// </summary>
        public long? MaxNumberOfRecordSets
        {
            get { return this._maxNumberOfRecordSets; }
            set { this._maxNumberOfRecordSets = value; }
        }
        
        private IList<string> _nameServers;
        
        /// <summary>
        /// Optional. Gets the name servers populated for this zone. This is a
        /// read-only property and any attempt to set this value will be
        /// ignored.
        /// </summary>
        public IList<string> NameServers
        {
            get { return this._nameServers; }
            set { this._nameServers = value; }
        }
        
        private long? _numberOfRecordSets;
        
        /// <summary>
        /// Optional. Gets or sets the current number of record sets in this
        /// zone.
        /// </summary>
        public long? NumberOfRecordSets
        {
            get { return this._numberOfRecordSets; }
            set { this._numberOfRecordSets = value; }
        }
        
        private string _parentResourceGroupName;
        
        /// <summary>
        /// Optional. Gets the resource group name for this zone. THis is a
        /// read-only property and any attempt to set this value will be
        /// ignored.
        /// </summary>
        public string ParentResourceGroupName
        {
            get { return this._parentResourceGroupName; }
            set { this._parentResourceGroupName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ZoneProperties class.
        /// </summary>
        public ZoneProperties()
        {
            this.NameServers = new LazyList<string>();
        }
    }
}
