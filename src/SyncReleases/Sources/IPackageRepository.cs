﻿using System.IO;
using System.Threading.Tasks;

namespace SyncReleases.Sources
{
    internal interface IPackageRepository
    {
        public Task DownloadRecentPackages(DirectoryInfo releasesDir);
        public Task UploadMissingPackages(DirectoryInfo releasesDir);
    }
}
