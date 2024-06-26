// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.AI.Vision.Face.Samples
{
    public partial class Samples_FaceClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FaceClient_FindSimilar_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                faceId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                faceIds = new object[]
            {
"73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"
            },
            });
            Response response = client.FindSimilar(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].GetProperty("confidence").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FaceClient_FindSimilar_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                faceId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                faceIds = new object[]
            {
"73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"
            },
            });
            Response response = await client.FindSimilarAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].GetProperty("confidence").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FaceClient_FindSimilar_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            Response<IReadOnlyList<FaceFindSimilarResult>> response = client.FindSimilar(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), new Guid[] { Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a") });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FaceClient_FindSimilar_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            Response<IReadOnlyList<FaceFindSimilarResult>> response = await client.FindSimilarAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), new Guid[] { Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a") });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FaceClient_FindSimilar_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                faceId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                maxNumOfCandidatesReturned = 1234,
                mode = "matchPerson",
                faceIds = new object[]
            {
"73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"
            },
            });
            Response response = client.FindSimilar(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].GetProperty("confidence").ToString());
            Console.WriteLine(result[0].GetProperty("faceId").ToString());
            Console.WriteLine(result[0].GetProperty("persistedFaceId").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FaceClient_FindSimilar_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                faceId = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                maxNumOfCandidatesReturned = 1234,
                mode = "matchPerson",
                faceIds = new object[]
            {
"73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"
            },
            });
            Response response = await client.FindSimilarAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result[0].GetProperty("confidence").ToString());
            Console.WriteLine(result[0].GetProperty("faceId").ToString());
            Console.WriteLine(result[0].GetProperty("persistedFaceId").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FaceClient_FindSimilar_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            Response<IReadOnlyList<FaceFindSimilarResult>> response = client.FindSimilar(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), new Guid[] { Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a") }, maxNumOfCandidatesReturned: 1234, mode: FindSimilarMatchMode.MatchPerson);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FaceClient_FindSimilar_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            Response<IReadOnlyList<FaceFindSimilarResult>> response = await client.FindSimilarAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), new Guid[] { Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a") }, maxNumOfCandidatesReturned: 1234, mode: FindSimilarMatchMode.MatchPerson);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FaceClient_VerifyFaceToFace_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                faceId1 = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                faceId2 = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
            });
            Response response = client.VerifyFaceToFace(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("isIdentical").ToString());
            Console.WriteLine(result.GetProperty("confidence").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FaceClient_VerifyFaceToFace_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                faceId1 = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                faceId2 = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
            });
            Response response = await client.VerifyFaceToFaceAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("isIdentical").ToString());
            Console.WriteLine(result.GetProperty("confidence").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FaceClient_VerifyFaceToFace_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            Response<FaceVerificationResult> response = client.VerifyFaceToFace(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FaceClient_VerifyFaceToFace_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            Response<FaceVerificationResult> response = await client.VerifyFaceToFaceAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FaceClient_VerifyFaceToFace_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                faceId1 = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                faceId2 = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
            });
            Response response = client.VerifyFaceToFace(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("isIdentical").ToString());
            Console.WriteLine(result.GetProperty("confidence").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FaceClient_VerifyFaceToFace_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                faceId1 = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
                faceId2 = "73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a",
            });
            Response response = await client.VerifyFaceToFaceAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("isIdentical").ToString());
            Console.WriteLine(result.GetProperty("confidence").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FaceClient_VerifyFaceToFace_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            Response<FaceVerificationResult> response = client.VerifyFaceToFace(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FaceClient_VerifyFaceToFace_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            Response<FaceVerificationResult> response = await client.VerifyFaceToFaceAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FaceClient_Group_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                faceIds = new object[]
            {
"73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"
            },
            });
            Response response = client.Group(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("groups")[0][0].ToString());
            Console.WriteLine(result.GetProperty("messyGroup")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FaceClient_Group_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                faceIds = new object[]
            {
"73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"
            },
            });
            Response response = await client.GroupAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("groups")[0][0].ToString());
            Console.WriteLine(result.GetProperty("messyGroup")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FaceClient_Group_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            Response<FaceGroupingResult> response = client.Group(new Guid[] { Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a") });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FaceClient_Group_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            Response<FaceGroupingResult> response = await client.GroupAsync(new Guid[] { Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a") });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FaceClient_Group_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                faceIds = new object[]
            {
"73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"
            },
            });
            Response response = client.Group(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("groups")[0][0].ToString());
            Console.WriteLine(result.GetProperty("messyGroup")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FaceClient_Group_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            using RequestContent content = RequestContent.Create(new
            {
                faceIds = new object[]
            {
"73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"
            },
            });
            Response response = await client.GroupAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("groups")[0][0].ToString());
            Console.WriteLine(result.GetProperty("messyGroup")[0].ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_FaceClient_Group_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            Response<FaceGroupingResult> response = client.Group(new Guid[] { Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a") });
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_FaceClient_Group_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            FaceClient client = new FaceClient(endpoint, credential);

            Response<FaceGroupingResult> response = await client.GroupAsync(new Guid[] { Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a") });
        }
    }
}
