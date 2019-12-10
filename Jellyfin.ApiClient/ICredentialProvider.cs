﻿using MediaBrowser.Model.ApiClient;
using System.Threading.Tasks;
using Jellyfin.ApiClient.Model;

namespace Jellyfin.ApiClient
{
    public interface ICredentialProvider
    {
        /// <summary>
        /// Gets the server credentials.
        /// </summary>
        /// <returns>ServerCredentialConfiguration.</returns>
        Task<ServerCredentials> GetServerCredentials();

        /// <summary>
        /// Saves the server credentials.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        Task SaveServerCredentials(ServerCredentials configuration);
    }
}
