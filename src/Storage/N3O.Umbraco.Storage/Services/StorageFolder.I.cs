﻿using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace N3O.Umbraco.Storage.Services {
    public interface IStorageFolder {
        Task<Blob> AddFileAsync(string name, Stream stream);
        Task<Blob> AddFileAsync(string name, byte[] contents);
        Task DeleteAllFilesAsync();
        Task DeleteFileAsync(string name);
        Task<Blob> GetFileAsync(string name, CancellationToken cancellationToken = default);
    }
}