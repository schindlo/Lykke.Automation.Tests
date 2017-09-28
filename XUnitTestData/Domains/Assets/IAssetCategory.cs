﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTestData.Domains.Assets
{
    public interface IAssetCategory : IDictionaryItem
    {
        string Id { get; }
        string Name { get; }
        string IosIconUrl { get; set; }
        string AndroidIconUrl { get; set; }
        int SortOrder { get; set; }
    }

    public interface IAssetCategoryRepository
    {
        Task InsertAssetCategory(IAssetCategory assetCategory);

        Task DeleteAssetCategory(string assetCategoryId);

        Task UpdateAssetCategory(IAssetCategory assetCategory);
        Task<IAssetCategory> GetAssetCategory(string id);
    }
}
