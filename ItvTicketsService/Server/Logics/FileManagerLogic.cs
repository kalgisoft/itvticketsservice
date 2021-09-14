using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using ItvTicketsService.Server.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;


namespace ItvTicketsService.Server.Logics
{
    public class FileManagerLogic : IFileManagerLogic
    {
        private readonly BlobServiceClient _blobServiceClient;
        private readonly string _azureConnectionString;
        public FileManagerLogic(BlobServiceClient blobServiceClient, IConfiguration config)
        {
            _blobServiceClient = blobServiceClient;
            _azureConnectionString = config.GetConnectionString("AzureConnectionString");
        }

        public async Task<string> Upload(FileModel model)
        {
            try
            {
                var blobContainer = new BlobContainerClient(_azureConnectionString, "upload-container");
                var createResponse = await blobContainer.CreateIfNotExistsAsync();
                if (createResponse != null && createResponse.GetRawResponse().Status == 201)
                    await blobContainer.SetAccessPolicyAsync(PublicAccessType.Blob);

                var blobClient = blobContainer.GetBlobClient(Path.Combine(@model.Folder, @model.ImageFile.FileName));
                await blobClient.DeleteIfExistsAsync(DeleteSnapshotsOption.IncludeSnapshots);

                using (var fileStream = model.ImageFile.OpenReadStream())
                {
                    await blobClient.UploadAsync(fileStream, new BlobHttpHeaders { ContentType = model.ImageFile.ContentType });
                }
                return blobClient.Uri.ToString();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
            return string.Empty;
        }

        public async Task<byte[]> Get(string imageName)
        {
            var blobContainer = _blobServiceClient.GetBlobContainerClient("upload-container");

            var blobClient = blobContainer.GetBlobClient(imageName);
            var downloadContent = await blobClient.DownloadAsync();
            using (MemoryStream ms = new MemoryStream())
            {
                await downloadContent.Value.Content.CopyToAsync(ms);
                return ms.ToArray();
            }
        }

        public async Task Delete(string imageName, string folder)
        {
            var blobContainer = _blobServiceClient.GetBlobContainerClient("upload-container");

            var blobClient = blobContainer.GetBlobClient(Path.Combine(@folder, @imageName));

            await blobClient.DeleteAsync();
        }

        public async Task<List<string>> List(string container, string folder)
        {

            var containerClient = _blobServiceClient.GetBlobContainerClient(container);
            var items = new List<string>();
            await foreach (var blobItem in containerClient.GetBlobsAsync(prefix: folder))
            {
                items.Add(string.Format("{0}/{1}",
                        containerClient.Uri.AbsoluteUri,
                        blobItem.Name));
            }

            return items;
        }
    }




}