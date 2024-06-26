// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// AdminRuleCollectionsOperations operations.
    /// </summary>
    public partial interface IAdminRuleCollectionsOperations
    {
        /// <summary>
        /// Lists all the rule collections in a security admin configuration,
        /// in a paginated format.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager Security Configuration.
        /// </param>
        /// <param name='top'>
        /// An optional query parameter which specifies the maximum number of
        /// records to be returned by the server.
        /// </param>
        /// <param name='skipToken'>
        /// SkipToken is only used if a previous operation returned a partial
        /// result. If a previous response contains a nextLink element, the
        /// value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AdminRuleCollection>>> ListWithHttpMessagesAsync(string resourceGroupName, string networkManagerName, string configurationName, int? top = default(int?), string skipToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a network manager security admin configuration rule
        /// collection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager Security Configuration.
        /// </param>
        /// <param name='ruleCollectionName'>
        /// The name of the network manager security Configuration rule
        /// collection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AdminRuleCollection>> GetWithHttpMessagesAsync(string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates an admin rule collection.
        /// </summary>
        /// <param name='ruleCollection'>
        /// The Rule Collection to create or update
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager Security Configuration.
        /// </param>
        /// <param name='ruleCollectionName'>
        /// The name of the network manager security Configuration rule
        /// collection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<AdminRuleCollection>> CreateOrUpdateWithHttpMessagesAsync(AdminRuleCollection ruleCollection, string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an admin rule collection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager Security Configuration.
        /// </param>
        /// <param name='ruleCollectionName'>
        /// The name of the network manager security Configuration rule
        /// collection.
        /// </param>
        /// <param name='force'>
        /// Deletes the resource even if it is part of a deployed
        /// configuration. If the configuration has been deployed, the service
        /// will do a cleanup deployment in the background, prior to the
        /// delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<AdminRuleCollectionsDeleteHeaders>> DeleteWithHttpMessagesAsync(string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, bool? force = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes an admin rule collection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='networkManagerName'>
        /// The name of the network manager.
        /// </param>
        /// <param name='configurationName'>
        /// The name of the network manager Security Configuration.
        /// </param>
        /// <param name='ruleCollectionName'>
        /// The name of the network manager security Configuration rule
        /// collection.
        /// </param>
        /// <param name='force'>
        /// Deletes the resource even if it is part of a deployed
        /// configuration. If the configuration has been deployed, the service
        /// will do a cleanup deployment in the background, prior to the
        /// delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<AdminRuleCollectionsDeleteHeaders>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string networkManagerName, string configurationName, string ruleCollectionName, bool? force = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all the rule collections in a security admin configuration,
        /// in a paginated format.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<AdminRuleCollection>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
