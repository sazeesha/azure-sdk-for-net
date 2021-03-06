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
using System.Linq;

namespace Microsoft.Azure.Management.DataLake.AnalyticsCatalog.Models
{
    /// <summary>
    /// A Data Lake Analytics DDL name item.
    /// </summary>
    public partial class DdlName
    {
        private string _firstPart;
        
        /// <summary>
        /// Optional. Gets or sets the name of the table associated with this
        /// database and schema.
        /// </summary>
        public string FirstPart
        {
            get { return this._firstPart; }
            set { this._firstPart = value; }
        }
        
        private string _secondPart;
        
        /// <summary>
        /// Optional. Gets or sets the name of the table associated with this
        /// database and schema.
        /// </summary>
        public string SecondPart
        {
            get { return this._secondPart; }
            set { this._secondPart = value; }
        }
        
        private string _server;
        
        /// <summary>
        /// Optional. Gets or sets the name of the table associated with this
        /// database and schema.
        /// </summary>
        public string Server
        {
            get { return this._server; }
            set { this._server = value; }
        }
        
        private string _thirdPart;
        
        /// <summary>
        /// Optional. Gets or sets the name of the table associated with this
        /// database and schema.
        /// </summary>
        public string ThirdPart
        {
            get { return this._thirdPart; }
            set { this._thirdPart = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DdlName class.
        /// </summary>
        public DdlName()
        {
        }
    }
}
