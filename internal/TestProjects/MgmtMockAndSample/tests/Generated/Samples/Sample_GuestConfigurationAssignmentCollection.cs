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
using MgmtMockAndSample.Models;
using NUnit.Framework;

namespace MgmtMockAndSample.Samples
{
    public partial class Sample_GuestConfigurationAssignmentCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateOrUpdateGuestConfigurationAssignment()
        {
            // Generated from example definition:
            // this example is just showing the usage of "GuestConfigurationAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this GuestConfigurationAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", subscriptionId, resourceGroupName, vmName));
            GuestConfigurationAssignmentCollection collection = client.GetGuestConfigurationAssignments(scopeId);

            // invoke the operation
            string guestConfigurationAssignmentName = "NotInstalledApplicationForWindows";
            GuestConfigurationAssignmentData data = new GuestConfigurationAssignmentData()
            {
                Properties = new GuestConfigurationAssignmentProperties()
                {
                    Context = "Azure policy",
                },
                Name = "NotInstalledApplicationForWindows",
                Location = new AzureLocation("westcentralus"),
            };
            ArmOperation<GuestConfigurationAssignmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, guestConfigurationAssignmentName, data);
            GuestConfigurationAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GuestConfigurationAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAGuestConfigurationAssignment()
        {
            // Generated from example definition:
            // this example is just showing the usage of "GuestConfigurationAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this GuestConfigurationAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", subscriptionId, resourceGroupName, vmName));
            GuestConfigurationAssignmentCollection collection = client.GetGuestConfigurationAssignments(scopeId);

            // invoke the operation
            string guestConfigurationAssignmentName = "SecureProtocol";
            GuestConfigurationAssignmentResource result = await collection.GetAsync(guestConfigurationAssignmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            GuestConfigurationAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAGuestConfigurationAssignment()
        {
            // Generated from example definition:
            // this example is just showing the usage of "GuestConfigurationAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this GuestConfigurationAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", subscriptionId, resourceGroupName, vmName));
            GuestConfigurationAssignmentCollection collection = client.GetGuestConfigurationAssignments(scopeId);

            // invoke the operation
            string guestConfigurationAssignmentName = "SecureProtocol";
            bool result = await collection.ExistsAsync(guestConfigurationAssignmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAGuestConfigurationAssignment()
        {
            // Generated from example definition:
            // this example is just showing the usage of "GuestConfigurationAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this GuestConfigurationAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", subscriptionId, resourceGroupName, vmName));
            GuestConfigurationAssignmentCollection collection = client.GetGuestConfigurationAssignments(scopeId);

            // invoke the operation
            string guestConfigurationAssignmentName = "SecureProtocol";
            NullableResponse<GuestConfigurationAssignmentResource> response = await collection.GetIfExistsAsync(guestConfigurationAssignmentName);
            GuestConfigurationAssignmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GuestConfigurationAssignmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAllGuestConfigurationAssignmentsForAVirtualMachine()
        {
            // Generated from example definition:
            // this example is just showing the usage of "GuestConfigurationAssignments_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this GuestConfigurationAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", subscriptionId, resourceGroupName, vmName));
            GuestConfigurationAssignmentCollection collection = client.GetGuestConfigurationAssignments(scopeId);

            // invoke the operation and iterate over the result
            await foreach (GuestConfigurationAssignmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                GuestConfigurationAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}