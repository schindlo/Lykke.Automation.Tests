﻿using AssetsData.DTOs.Assets;
using AssetsData.Fixtures;
using FluentAssertions;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using NUnit.Framework;
using XUnitTestCommon.Utils;
using XUnitTestCommon;
using System.Threading.Tasks;
using XUnitTestData.Entities.Assets;

namespace AFTests.AssetsTests
{
    [Category("FullRegression")]
    [Category("AssetsService")]
    public partial class AssetsTest
    {
        [Test]
        [Category("Smoke")]
        [Category("AssetExtendedInfos")]
        [Category("AssetExtendedInfoGet")]
        public async Task GetAllAssetExtendedInfos()
        {
            string url = ApiPaths.ASSET_EXTENDED_INFO_PATH;
            var response = await fixture.Consumer.ExecuteRequest(url, Helpers.EmptyDictionary, null, Method.GET);
            Assert.True(response.Status == HttpStatusCode.OK);

            List<AssetExtendedInfoDTO> parsedResponse = JsonUtils.DeserializeJson<List<AssetExtendedInfoDTO>>(response.ResponseJson);
            Assert.NotNull(parsedResponse);

            for (int i = 0; i < fixture.AllAssetExtendedInfosFromDB.Count; i++)
            {
                fixture.AllAssetExtendedInfosFromDB[i].ShouldBeEquivalentTo(
                    parsedResponse.Where(a => a.Id == fixture.AllAssetExtendedInfosFromDB[i].Id).FirstOrDefault()
                    , o => o.ExcludingMissingMembers());
            }
        }

        [Test]
        [Category("Smoke")]
        [Category("AssetExtendedInfos")]
        [Category("AssetExtendedInfoGet")]
        public async Task GetSingleAssetExtendedInfo()
        {
            string url = ApiPaths.ASSET_EXTENDED_INFO_PATH + "/" + fixture.TestAssetExtendedInfo.Id;
            var response = await fixture.Consumer.ExecuteRequest(url, Helpers.EmptyDictionary, null, Method.GET);
            Assert.True(response.Status == HttpStatusCode.OK);

            AssetExtendedInfoDTO parsedResponse = JsonUtils.DeserializeJson<AssetExtendedInfoDTO>(response.ResponseJson);
            Assert.NotNull(parsedResponse);

            fixture.TestAssetExtendedInfo.ShouldBeEquivalentTo(parsedResponse, o => o
            .ExcludingMissingMembers());
        }

        [Test]
        [Category("Smoke")]
        [Category("AssetExtendedInfos")]
        [Category("AssetExtendedInfoGet")]
        public async Task CheckIfAssetExtendedInfoExists()
        {
            string url = ApiPaths.ASSET_EXTENDED_INFO_PATH + "/" + fixture.TestAssetExtendedInfo.Id + "/exists";
            var response = await fixture.Consumer.ExecuteRequest(url, Helpers.EmptyDictionary, null, Method.GET);
            Assert.NotNull(response);
            bool parsedResponse = JsonUtils.DeserializeJson<bool>(response.ResponseJson);
            Assert.NotNull(parsedResponse);
            Assert.True(parsedResponse);

            string badUrl = ApiPaths.ASSET_EXTENDED_INFO_PATH + "/AutoTestAssetThatDoesntExist/exists";
            var badResponse = await fixture.Consumer.ExecuteRequest(badUrl, Helpers.EmptyDictionary, null, Method.GET);
            Assert.NotNull(badResponse);
            bool badParsedResponse = JsonUtils.DeserializeJson<bool>(badResponse.ResponseJson);
            Assert.NotNull(badParsedResponse);
            Assert.False(badParsedResponse);
        }

        [Test]
        [Category("Smoke")]
        [Category("AssetExtendedInfos")]
        [Category("AssetExtendedInfoPost")]
        public async Task CreateAssetExtendedInfo()
        {
            AssetExtendedInfoDTO createdInfo = await fixture.CreateTestAssetExtendedInfo();
            Assert.NotNull(createdInfo);

            AssetExtendedInfosEntity checkDbCreated = (AssetExtendedInfosEntity)await fixture.AssetExtendedInfosManager.TryGetAsync(createdInfo.Id);
            checkDbCreated.ShouldBeEquivalentTo(createdInfo, o => o
            .ExcludingMissingMembers());
        }

        [Test]
        [Category("Smoke")]
        [Category("AssetExtendedInfos")]
        [Category("AssetExtendedInfoPut")]
        public async Task UpdateAssetExtendedInfo()
        {
            string url = ApiPaths.ASSET_EXTENDED_INFO_PATH;

            AssetExtendedInfoDTO updateExtendedInfo = new AssetExtendedInfoDTO()
            {
                Id = fixture.TestAssetExtendedInfoUpdate.Id,
                AssetClass = fixture.TestAssetExtendedInfoUpdate.AssetClass,
                AssetDescriptionUrl = fixture.TestAssetExtendedInfoUpdate.AssetDescriptionUrl,
                Description = fixture.TestAssetExtendedInfoUpdate.Description,
                FullName = fixture.TestAssetExtendedInfoUpdate.FullName + "_autotestt",
                MarketCapitalization = fixture.TestAssetExtendedInfoUpdate.MarketCapitalization,
                NumberOfCoins = fixture.TestAssetExtendedInfoUpdate.NumberOfCoins,
                PopIndex = fixture.TestAssetExtendedInfoUpdate.PopIndex
            };
            string updateParam = JsonUtils.SerializeObject(updateExtendedInfo);

            var updateResponse = await fixture.Consumer.ExecuteRequest(url, Helpers.EmptyDictionary, updateParam, Method.PUT);
            Assert.True(updateResponse.Status == HttpStatusCode.NoContent);

            AssetExtendedInfosEntity checkDbUpdated = (AssetExtendedInfosEntity)await fixture.AssetExtendedInfosManager.TryGetAsync(fixture.TestAssetExtendedInfoUpdate.Id);
            checkDbUpdated.ShouldBeEquivalentTo(updateParam, o => o
            .ExcludingMissingMembers());
        }

        [Test]
        [Category("Smoke")]
        [Category("AssetExtendedInfos")]
        [Category("AssetExtendedInfoDelete")]
        public async Task DeleteAssetExtendedInfo()
        {
            string deleteUrl = ApiPaths.ASSET_EXTENDED_INFO_PATH + "/" + fixture.TestAssetExtendedInfoDelete.Id;
            var deleteResponse = await fixture.Consumer.ExecuteRequest(deleteUrl, Helpers.EmptyDictionary, null, Method.DELETE);
            Assert.True(deleteResponse.Status == HttpStatusCode.NoContent);

            AssetExtendedInfosEntity checkDbDeleted = (AssetExtendedInfosEntity)await fixture.AssetExtendedInfosManager.TryGetAsync(fixture.TestAssetExtendedInfoDelete.Id);
            Assert.Null(checkDbDeleted);
        }

        // /api/v2/asset-extended-infos/__default
    }
}
