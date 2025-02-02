// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub
{
    public partial class Sample_ResourceTypeRegistrationResource
    {
        // ResourceTypeRegistrations_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ResourceTypeRegistrationsGet()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2021-09-01-preview/examples/ResourceTypeRegistrations_Get.json
            // this example is just showing the usage of "ResourceTypeRegistrations_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceTypeRegistrationResource created on azure
            // for more information of creating ResourceTypeRegistrationResource, please refer to the document of ResourceTypeRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "employees";
            ResourceIdentifier resourceTypeRegistrationResourceId = ResourceTypeRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType);
            ResourceTypeRegistrationResource resourceTypeRegistration = client.GetResourceTypeRegistrationResource(resourceTypeRegistrationResourceId);

            // invoke the operation
            ResourceTypeRegistrationResource result = await resourceTypeRegistration.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceTypeRegistrationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ResourceTypeRegistrations_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ResourceTypeRegistrationsCreateOrUpdate()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2021-09-01-preview/examples/ResourceTypeRegistrations_CreateOrUpdate.json
            // this example is just showing the usage of "ResourceTypeRegistrations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceTypeRegistrationResource created on azure
            // for more information of creating ResourceTypeRegistrationResource, please refer to the document of ResourceTypeRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "employees";
            ResourceIdentifier resourceTypeRegistrationResourceId = ResourceTypeRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType);
            ResourceTypeRegistrationResource resourceTypeRegistration = client.GetResourceTypeRegistrationResource(resourceTypeRegistrationResourceId);

            // invoke the operation
            ResourceTypeRegistrationData data = new ResourceTypeRegistrationData()
            {
                Properties = new ResourceTypeRegistrationProperties()
                {
                    RoutingType = RoutingType.Default,
                    Regionality = Regionality.Regional,
                    Endpoints =
{
new ResourceTypeEndpoint()
{
ApiVersions =
{
"2020-06-01-preview"
},
Locations =
{
"West US","East US","North Europe"
},
RequiredFeatures =
{
"<feature flag>"
},
}
},
                    SwaggerSpecifications =
{
new SwaggerSpecification()
{
ApiVersions =
{
"2020-06-01-preview"
},
SwaggerSpecFolderUri = new Uri("https://github.com/Azure/azure-rest-api-specs/blob/feature/azure/contoso/specification/contoso/resource-manager/Microsoft.SampleRP/"),
}
},
                    ResourceConcurrencyControlOptions =
{
["patch"] = new ResourceConcurrencyControlOption()
{
Policy = Policy.SynchronizeBeginExtension,
},
["post"] = new ResourceConcurrencyControlOption()
{
Policy = Policy.SynchronizeBeginExtension,
},
["put"] = new ResourceConcurrencyControlOption()
{
Policy = Policy.SynchronizeBeginExtension,
},
},
                    ResourceGraphConfiguration = new ResourceTypeRegistrationPropertiesResourceGraphConfiguration()
                    {
                        Enabled = true,
                        ApiVersion = "2019-01-01",
                    },
                    Management = new ResourceTypeRegistrationPropertiesManagement()
                    {
                        ManifestOwners =
{
"SPARTA-PlatformServiceAdministrator"
},
                        IncidentRoutingService = "",
                        IncidentRoutingTeam = "",
                        IncidentContactEmail = "helpme@contoso.com",
                        ServiceTreeInfos =
{
new ServiceTreeInfo()
{
ServiceId = "d1b7d8ba-05e2-48e6-90d6-d781b99c6e69",
ComponentId = "d1b7d8ba-05e2-48e6-90d6-d781b99c6e69",
Readiness = Readiness.InDevelopment,
}
},
                        ResourceAccessPolicy = ResourceProviderManagementResourceAccessPolicy.NotSpecified,
                    },
                    AllowNoncompliantCollectionResponse = true,
                },
            };
            ArmOperation<ResourceTypeRegistrationResource> lro = await resourceTypeRegistration.UpdateAsync(WaitUntil.Completed, data);
            ResourceTypeRegistrationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceTypeRegistrationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ResourceTypeRegistrations_Delete
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ResourceTypeRegistrationsDelete()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2021-09-01-preview/examples/ResourceTypeRegistrations_Delete.json
            // this example is just showing the usage of "ResourceTypeRegistrations_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this ResourceTypeRegistrationResource created on azure
            // for more information of creating ResourceTypeRegistrationResource, please refer to the document of ResourceTypeRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            ResourceIdentifier resourceTypeRegistrationResourceId = ResourceTypeRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType);
            ResourceTypeRegistrationResource resourceTypeRegistration = client.GetResourceTypeRegistrationResource(resourceTypeRegistrationResourceId);

            // invoke the operation
            await resourceTypeRegistration.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
