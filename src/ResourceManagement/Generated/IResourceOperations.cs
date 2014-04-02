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
using Microsoft.Azure.Management.Resources.Models;
using Microsoft.WindowsAzure;

namespace Microsoft.Azure.Management.Resources
{
    /// <summary>
    /// Operations for managing resources.
    /// </summary>
    public partial interface IResourceOperations
    {
        /// <summary>
        /// Checks whether resource exists.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='identity'>
        /// Resource identity.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Resource group information.
        /// </returns>
        Task<ResourceExistsResult> CheckExistenceAsync(string resourceGroupName, ResourceIdentity identity, CancellationToken cancellationToken);
        
        /// <summary>
        /// Create a resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='identity'>
        /// Resource identity.
        /// </param>
        /// <param name='parameters'>
        /// Create or update resource parameters.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Resource information.
        /// </returns>
        Task<ResourceCreateOrUpdateResult> CreateOrUpdateAsync(string resourceGroupName, ResourceIdentity identity, ResourceCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Delete resource and all of its resources.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='identity'>
        /// Resource identity.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteAsync(string resourceGroupName, ResourceIdentity identity, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns a resource belonging to a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='identity'>
        /// Resource identity.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Resource information.
        /// </returns>
        Task<ResourceGetResult> GetAsync(string resourceGroupName, ResourceIdentity identity, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get all of the resources under a subscription.
        /// </summary>
        /// <param name='parameters'>
        /// Query parameters. If null is passed returns all resource groups.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// List of resource groups.
        /// </returns>
        Task<ResourceListResult> ListAsync(ResourceListParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Get a list of deployments.
        /// </summary>
        /// <param name='nextLink'>
        /// NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// List of resource groups.
        /// </returns>
        Task<ResourceListResult> ListNextAsync(string nextLink, CancellationToken cancellationToken);
    }
}
