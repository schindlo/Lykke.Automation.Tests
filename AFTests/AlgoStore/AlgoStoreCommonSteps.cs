﻿using AlgoStoreData.DTOs;
using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using XUnitTestCommon;
using XUnitTestCommon.Consumers;
using XUnitTestCommon.Utils;
using XUnitTestData.Domains.AlgoStore;
using XUnitTestData.Entities.AlgoStore;
using XUnitTestData.Repositories;

namespace AFTests.AlgoStore
{
    public class AlgoStoreCommonSteps
    {
        private static string stopAlgoPath = ApiPaths.ALGO_STORE_ALGO_STOP;
        private static string statisticsPath = ApiPaths.ALGO_STORE_STATISTICS;

        public static async Task WaitAlgoToStart(GenericRepository<ClientInstanceEntity, IClientInstance> clientInstanceRepository, InstanceDataDTO postInstanceData)
        {
            ClientInstanceEntity instanceDataEntityExists = await clientInstanceRepository.TryGetAsync(t => t.Id == postInstanceData.InstanceId) as ClientInstanceEntity;
            Assert.NotNull(instanceDataEntityExists);

            // Wait up to 3 minutes for the algo to be started
            int count = 45;
            while (instanceDataEntityExists.AlgoInstanceStatusValue != "Started" && count > 1) // TODO: Update when a health check endpoint is created
            {
                Wait.ForPredefinedTime(5000); // Wait for five secodns before getting the algo instance data again
                instanceDataEntityExists = await clientInstanceRepository.TryGetAsync(t => t.Id == postInstanceData.InstanceId) as ClientInstanceEntity;
                count--;
            }
        }

        public static async Task StopAlgoInstance(ApiConsumer apiConsumer, InstanceDataDTO postInstanceData)
        {
            StopBinaryDTO stopAlgo = new StopBinaryDTO()
            {
                AlgoId = postInstanceData.AlgoId,
                InstanceId = postInstanceData.InstanceId
            };
            var stopAlgoRequest = await apiConsumer.ExecuteRequest(stopAlgoPath, Helpers.EmptyDictionary, JsonUtils.SerializeObject(stopAlgo), Method.POST);
            StopBinaryResponseDTO stopAlgoResponce = JsonUtils.DeserializeJson<StopBinaryResponseDTO>(stopAlgoRequest.ResponseJson);

            int retryCounter = 1;
            while ((stopAlgoResponce.Status.Equals("Deploying") || stopAlgoResponce.Status.Equals("Started")) && retryCounter <= 30)
            {
                System.Threading.Thread.Sleep(10000);
                stopAlgoRequest = await apiConsumer.ExecuteRequest(stopAlgoPath, Helpers.EmptyDictionary, JsonUtils.SerializeObject(stopAlgo), Method.POST);

                stopAlgoResponce = JsonUtils.DeserializeJson<StopBinaryResponseDTO>(stopAlgoRequest.ResponseJson);

                retryCounter++;
            }
        }

        public static async Task<StatisticsDTO> GetStatisticsResponseAsync(ApiConsumer apiConsumer, InstanceDataDTO postInstanceData, int waitTime = 10000)
        {
            // Build statistics endpoint query param dictionary
            Dictionary<string, string> statisticsQueryParams = new Dictionary<string, string>()
            {
                { "instanceId", postInstanceData.InstanceId}
            };

            Wait.ForPredefinedTime(waitTime); // Wait for some trades to be done
            Response statisticsResponse = await apiConsumer.ExecuteRequest(statisticsPath, statisticsQueryParams, null, Method.GET);
            Assert.That(statisticsResponse.Status, Is.EqualTo(HttpStatusCode.OK));

            return JsonUtils.DeserializeJson<StatisticsDTO>(statisticsResponse.ResponseJson);
        }
    }
}
