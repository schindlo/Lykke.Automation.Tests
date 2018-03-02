﻿using AlgoStoreData.DependancyInjection;
using AlgoStoreData.DTOs;
using Autofac;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XUnitTestCommon;
using XUnitTestCommon.Consumers;
using XUnitTestCommon.Tests;
using XUnitTestCommon.Utils;
using XUnitTestData.Domains.AlgoStore;
using XUnitTestData.Entities.AlgoStore;
using XUnitTestData.Repositories;
using XUnitTestData.Repositories.AlgoStore;

namespace AlgoStoreData.Fixtures
{
    [TestFixture]
    public partial class AlgoStoreTestDataFixture : BaseTest
    {
        private ConfigBuilder _configBuilder;
        private TimeSpan timespan = TimeSpan.FromSeconds(120);
        public ApiConsumer Consumer;
        private OAuthConsumer User;
        private IContainer _container;
        public GenericRepository<MetaDataEntity, IMetaData> MetaDataRepository;
        public GenericRepository<RuntimeDataEntity, IRuntimeData> RuntimeDataRepository;
        public GenericRepository<ClientInstanceEntity, IClientInstance> ClientInstanceRepository;
        public List<BuilInitialDataObjectDTO> PreStoredMetadata;
        public AlgoBlobRepository BlobRepository;
        public string JavaAlgoString = "package com.lykke.algos;\n public class Algo \n { \n public void run() throws InterruptedException \n { \n for (int i = 100000; i > 0; i--) \n { \n java.lang.Thread.sleep(1000); \n System.out.println(\"Demo Algo Fil VS\" + i); \n } \n } \n }";
        public string CSharpAlgoString = "using Lykke.AlgoStore.CSharp.Algo.Core.Domain; \n using Lykke.AlgoStore.CSharp.AlgoTemplate.Services.Functions.SMA; \n using System; \n namespace Lykke.AlgoStore.CSharp.Algo.Implemention.ExecutableClass \n { \n public class CSharpAlgo : BaseAlgo \n { \n private SmaFunction _shortSma; \n  private SmaFunction _longSma; \n public override void OnStartUp(IFunctionProvider functions) \n { \n _shortSma = functions.GetFunction<SmaFunction>(\"SMA_Short\"); \n _longSma = functions.GetFunction<SmaFunction>(\"SMA_Long\"); \n } \n public override void OnQuoteReceived(IQuoteContext context) \n { \n var quote = context.Data.Quote; \n context.Actions.Log($\"Receiving quote at {DateTime.UtcNow} \" + $\"{{quote.Price: {quote.Price}}}, {{quote.Timestamp: {quote.Timestamp}}}, \" + $\"{{quote.IsBuy: {quote.IsBuy}}}, {{quote.IsOnline: {quote.IsOnline}}}\"); \n var smaShort = _shortSma.GetValue(); \n var smaLong = _longSma.GetValue(); \n context.Actions.Log($\"Function values are: SMA_Short: {smaShort}, SMA_Long: {smaLong}\"); \n } \n } \n }";

    [OneTimeSetUp]
        public void Initialize()
        {
            _configBuilder = new ConfigBuilder("AlgoStore");

            User = new OAuthConsumer(_configBuilder);
            Consumer = new ApiConsumer(_configBuilder, User);

            PrepareDependencyContainer();
            PrepareTestData().Wait();
        }

        private void PrepareDependencyContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AlgoStoreTestModule(_configBuilder));
            _container = builder.Build();

            this.MetaDataRepository = RepositoryUtils.ResolveGenericRepository<MetaDataEntity, IMetaData>(this._container);
            this.RuntimeDataRepository = RepositoryUtils.ResolveGenericRepository<RuntimeDataEntity, IRuntimeData>(this._container);
            this.ClientInstanceRepository = RepositoryUtils.ResolveGenericRepository<ClientInstanceEntity, IClientInstance>(this._container);
            this.BlobRepository = new AlgoBlobRepository(_configBuilder.Config["MainConnectionString"], timespan);
    }

        private async Task PrepareTestData()
        {
            PreStoredMetadata = await UploadSomeBaseMetaData(3);
            DataManager.storeMetadata(PreStoredMetadata);
        }

        private async Task ClearTestData()
        {
            await ClearAllCascadeDelete(DataManager.getAllMetaData());
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            ClearTestData().Wait();
            GC.SuppressFinalize(this);
        }
    }
}
