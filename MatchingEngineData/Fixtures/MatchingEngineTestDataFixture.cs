﻿using AFTMatchingEngine.DTOs.RabbitMQ;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using XUnitTestCommon;
using XUnitTestCommon.Consumers;
using XUnitTestCommon.DTOs.RabbitMQ;
using XUnitTestCommon.Utils;

namespace AFTMatchingEngine.Fixtures
{
    public class MatchingEngineTestDataFixture : IDisposable
    {
        public MatchingEngineConsumer Consumer;
        public List<CashOperation> CashInOutMessages;

        private RabbitMQConsumer<CashOperation> CashInOutSubscription;
        private ConfigBuilder _configBuilder;

        private List<string> _createdQueues;

        public MatchingEngineTestDataFixture()
        {
            this._configBuilder = new ConfigBuilder("MatchingEngine");
            prepareConsumer();
            prepareRabbitQueues();
            prepareRabbitMQConnections();


        }

        private void prepareRabbitMQConnections()
        {
            CashInOutMessages = new List<CashOperation>();

            CashInOutSubscription = new RabbitMQConsumer<CashOperation>(
                _configBuilder, "cashinout", "automation_functional_tests");

            CashInOutSubscription.SubscribeMessageHandler(handleCashInOutMessages);
            CashInOutSubscription.Start();
        }

        private void prepareConsumer()
        {
            if (Int32.TryParse(_configBuilder.Config["Port"], out int port))
            {
                Consumer = new MatchingEngineConsumer(_configBuilder.Config["BaseUrl"], port);
            }
            else
            {
                throw new FormatException();
            }
        }

        private void prepareRabbitQueues()
        {
            _createdQueues = new List<string>();
            RabbitMQHttpApiConsumer.Setup(_configBuilder);

            List<Task<bool>> createQueueTasks = new List<Task<bool>>();
            createQueueTasks.Add(createQueue("lykke.cashinout", "lykke.cashinout.automation_functional_tests"));


            Task.WhenAll(createQueueTasks).Wait();
        }

        private async Task<bool> createQueue(string exchangeName, string queueName)
        {
            RabbitMQHttpApiQueueResultDTO queueModel = Task.Run(async () =>
            {
                return await RabbitMQHttpApiConsumer.GetQueueByNameAsync(queueName);
            }).Result;

            if (queueModel != null)
            {
                await RabbitMQHttpApiConsumer.DeleteQueueAsync(queueName);
            }

            bool IsBinded = false;

            bool IsCreated = await RabbitMQHttpApiConsumer.CreateQueueAsync(queueName);
            if (IsCreated)
            {
                IsBinded = await RabbitMQHttpApiConsumer.BindQueueAsync(exchangeName, queueName);
            }

            if (IsBinded)
            {
                _createdQueues.Add(queueName);
            }

            return IsBinded;
        }

        public void Dispose()
        {
            CashInOutSubscription.Stop();

            List<Task<bool>> deleteTasks = new List<Task<bool>>();

            foreach (string queueName in _createdQueues)
            {
                deleteTasks.Add(RabbitMQHttpApiConsumer.DeleteQueueAsync(queueName));
            }

            Task.WhenAll(deleteTasks).Wait();
            
        }

        #region messageHandlers

        private Task handleCashInOutMessages(CashOperation msg)
        {
            CashInOutMessages.Add(msg);
            return Task.FromResult(msg);
        }

        #endregion
    }
}
