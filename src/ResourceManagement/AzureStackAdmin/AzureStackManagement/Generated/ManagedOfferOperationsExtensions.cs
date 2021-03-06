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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.AzureStack.Management;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management
{
    public static partial class ManagedOfferOperationsExtensions
    {
        /// <summary>
        /// Returns the created or updated offer
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IManagedOfferOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='parameters'>
        /// Required. Offer properties
        /// </param>
        /// <returns>
        /// Result of the create or update operation of offer
        /// </returns>
        public static ManagedOfferCreateOrUpdateResult CreateOrUpdate(this IManagedOfferOperations operations, string resourceGroupName, ManagedOfferCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagedOfferOperations)s).CreateOrUpdateAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns the created or updated offer
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IManagedOfferOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='parameters'>
        /// Required. Offer properties
        /// </param>
        /// <returns>
        /// Result of the create or update operation of offer
        /// </returns>
        public static Task<ManagedOfferCreateOrUpdateResult> CreateOrUpdateAsync(this IManagedOfferOperations operations, string resourceGroupName, ManagedOfferCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete operation on the offer
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IManagedOfferOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='offerId'>
        /// Required. Offer name
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IManagedOfferOperations operations, string resourceGroupName, string offerId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagedOfferOperations)s).DeleteAsync(resourceGroupName, offerId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete operation on the offer
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IManagedOfferOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='offerId'>
        /// Required. Offer name
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IManagedOfferOperations operations, string resourceGroupName, string offerId)
        {
            return operations.DeleteAsync(resourceGroupName, offerId, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the administrator view of the offer
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IManagedOfferOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='offerId'>
        /// Required. Offer name
        /// </param>
        /// <returns>
        /// Result of the offer Get operation
        /// </returns>
        public static ManagedOfferGetResult Get(this IManagedOfferOperations operations, string resourceGroupName, string offerId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagedOfferOperations)s).GetAsync(resourceGroupName, offerId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the administrator view of the offer
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IManagedOfferOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='offerId'>
        /// Required. Offer name
        /// </param>
        /// <returns>
        /// Result of the offer Get operation
        /// </returns>
        public static Task<ManagedOfferGetResult> GetAsync(this IManagedOfferOperations operations, string resourceGroupName, string offerId)
        {
            return operations.GetAsync(resourceGroupName, offerId, CancellationToken.None);
        }
        
        /// <summary>
        /// Lists the offers under the specified resource group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IManagedOfferOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='includeDetails'>
        /// Required. Flag to specify whether to include details
        /// </param>
        /// <returns>
        /// Result of the offer list operation
        /// </returns>
        public static ManagedOfferListResult List(this IManagedOfferOperations operations, string resourceGroupName, bool includeDetails)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IManagedOfferOperations)s).ListAsync(resourceGroupName, includeDetails);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists the offers under the specified resource group
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.AzureStack.Management.IManagedOfferOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name
        /// </param>
        /// <param name='includeDetails'>
        /// Required. Flag to specify whether to include details
        /// </param>
        /// <returns>
        /// Result of the offer list operation
        /// </returns>
        public static Task<ManagedOfferListResult> ListAsync(this IManagedOfferOperations operations, string resourceGroupName, bool includeDetails)
        {
            return operations.ListAsync(resourceGroupName, includeDetails, CancellationToken.None);
        }
    }
}
