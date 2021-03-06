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
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// Device NetInterface
    /// </summary>
    public partial class NetInterface
    {
        private NetInterfaceId _interfaceId;
        
        /// <summary>
        /// Required. Gets or sets the InterfaceId
        /// </summary>
        public NetInterfaceId InterfaceId
        {
            get { return this._interfaceId; }
            set { this._interfaceId = value; }
        }
        
        private bool _isCloudEnabled;
        
        /// <summary>
        /// Required. Gets or sets a value indicating whether this instance is
        /// cloud enabled.
        /// </summary>
        public bool IsCloudEnabled
        {
            get { return this._isCloudEnabled; }
            set { this._isCloudEnabled = value; }
        }
        
        private bool _isDefault;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating whether this instance is
        /// default.
        /// </summary>
        public bool IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }
        
        private bool _isEnabled;
        
        /// <summary>
        /// Required. Gets or sets a value indicating whether this instance is
        /// enabled.
        /// </summary>
        public bool IsEnabled
        {
            get { return this._isEnabled; }
            set { this._isEnabled = value; }
        }
        
        private bool _isIScsiEnabled;
        
        /// <summary>
        /// Required. Gets or sets a value indicating whether this instance is
        /// i scsi enabled.
        /// </summary>
        public bool IsIScsiEnabled
        {
            get { return this._isIScsiEnabled; }
            set { this._isIScsiEnabled = value; }
        }
        
        private int _mediaConnectState;
        
        /// <summary>
        /// Optional. Gets or sets the MediaConnectState.
        /// </summary>
        public int MediaConnectState
        {
            get { return this._mediaConnectState; }
            set { this._mediaConnectState = value; }
        }
        
        private NetworkMode _mode;
        
        /// <summary>
        /// Required. Gets or sets the network mode.
        /// </summary>
        public NetworkMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }
        
        private NicIPv4 _nicIPv4Settings;
        
        /// <summary>
        /// Optional. Gets or sets the nic IPV4 settings.
        /// </summary>
        public NicIPv4 NicIPv4Settings
        {
            get { return this._nicIPv4Settings; }
            set { this._nicIPv4Settings = value; }
        }
        
        private NicIPv6 _nicIPv6Settings;
        
        /// <summary>
        /// Optional. Gets or sets the nic IPV6 settings.
        /// </summary>
        public NicIPv6 NicIPv6Settings
        {
            get { return this._nicIPv6Settings; }
            set { this._nicIPv6Settings = value; }
        }
        
        private long _speed;
        
        /// <summary>
        /// Optional. Gets or sets the speed.
        /// </summary>
        public long Speed
        {
            get { return this._speed; }
            set { this._speed = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the NetInterface class.
        /// </summary>
        public NetInterface()
        {
        }
    }
}
