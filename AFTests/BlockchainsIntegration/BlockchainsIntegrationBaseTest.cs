﻿using BlockchainsIntegration.BlockchainWallets;
using BlockchainsIntegration.LiteCoin;
using BlockchainsIntegration.LitecoinSign;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using XUnitTestCommon.Tests;

namespace AFTests.BlockchainsIntegrationTests.LiteCoin
{
    class BlockchainsIntegrationBaseTest : BaseTest
    {

        static string SpecificBlockchain()
        {
            return Environment.GetEnvironmentVariable("BlockchainIntegration") ?? "Litecoin";
        }

        private static BlockchainSpecificModel _settings;

        static BlockchainSpecificModel BlockchainSpecificSettings()
        {
            if (_settings != null)
                return _settings;

            if (SpecificBlockchain().ToLower() == "litecoin")
                _settings = new LitecoinSettings();

            if (SpecificBlockchain().ToLower() == "dash")
                _settings = new DashSettings();

            if (SpecificBlockchain().ToLower() == "zcash")
                _settings = new ZcashSettings();

            return _settings;
        }

        protected BlockchainApi blockchainApi = new BlockchainApi(BlockchainSpecificSettings().ApiUrl);
        protected BlockchainSign blockchainSign = new BlockchainSign(BlockchainSpecificSettings().SignUrl);
        protected BlockchainWallets blockchainWallets = new BlockchainWallets();

        protected static string HOT_WALLET = BlockchainSpecificSettings().HotWallet;
        protected static string WALLET_ADDRESS = BlockchainSpecificSettings().WalletAddress;
        protected static string PKey = BlockchainSpecificSettings().PrivateKey;

        protected static string WALLET_SINGLE_USE = BlockchainSpecificSettings().WalletSingleUse;
        protected static string KEY_WALLET_SINGLE_USE = BlockchainSpecificSettings().WalletSingleUseKey;

        protected static string CLIENT_ID = BlockchainSpecificSettings().ClientId;
        //fill here http://faucet.thonguyen.net/ltc
    }

    abstract class BlockchainSpecificModel
    {
        public string ApiUrl { get; set; }
        public string SignUrl { get; set; }
        public string WalletsUrl { get; set; }

        public string HotWallet { get; set; }
        public string WalletAddress { get; set; }
        public string PrivateKey { get; set; }
        public string WalletSingleUse { get; set; }
        public string WalletSingleUseKey { get; set; }
        public string ClientId { get; set; }
    }

    class LitecoinSettings : BlockchainSpecificModel
    {
        public LitecoinSettings()
        {
            ApiUrl = "http://litecoin-api.autotests-service.svc.cluster.local/api";
            SignUrl = "http://litecoin-sign.autotests-service.svc.cluster.local/api";
            WalletsUrl = null;
            HotWallet = "mwy2LRNecLfHxatdAxz1XQP2sqv8Nk3PFV";
            WalletAddress = "msvNWBpFNDQ6JxiEcTFU3xXbSnDir4EqCk";
            PrivateKey = "cRTB3eAajJchgNuybhH5SwC9L5PFoTwxXBjgB8vRNJeJ4EpcXmAP";
            WalletSingleUse = "mvErcbPuL4T4kxbJYejk6xLbv8pfBiiSPu";
            WalletSingleUseKey = "cNn38kw6LSfAS6WvJJbFTqWRewa1GgfwczftXrBcyAmygM1V7qKr";
            ClientId = "b623b171-a307-4485-897c-f3a70b763217";
        }
    }

    class DashSettings : BlockchainSpecificModel
    {
        public DashSettings()
        {
            ApiUrl = "http://dash-api.autotests-service.svc.cluster.local/api";
            SignUrl = "http://dash-sign.autotests-service.svc.cluster.local/api";
            WalletsUrl = null;
            HotWallet = "mwy2LRNecLfHxatdAxz1XQP2sqv8Nk3PFV";
            WalletAddress = "msvNWBpFNDQ6JxiEcTFU3xXbSnDir4EqCk";
            PrivateKey = "cRTB3eAajJchgNuybhH5SwC9L5PFoTwxXBjgB8vRNJeJ4EpcXmAP";
            WalletSingleUse = "mvErcbPuL4T4kxbJYejk6xLbv8pfBiiSPu";
            WalletSingleUseKey = "cNn38kw6LSfAS6WvJJbFTqWRewa1GgfwczftXrBcyAmygM1V7qKr";
            ClientId = "b623b171-a307-4485-897c-f3a70b763217";
        }
    }

    class ZcashSettings : BlockchainSpecificModel
    {
        public ZcashSettings()
        {
            ApiUrl = "http://zcash-api.autotests-service.svc.cluster.local/api";
            SignUrl = "http://zcash-sign-service.autotests-service.svc.cluster.local/api";
            WalletsUrl = null;
            HotWallet = "mwy2LRNecLfHxatdAxz1XQP2sqv8Nk3PFV";
            WalletAddress = "msvNWBpFNDQ6JxiEcTFU3xXbSnDir4EqCk";
            PrivateKey = "cRTB3eAajJchgNuybhH5SwC9L5PFoTwxXBjgB8vRNJeJ4EpcXmAP";
            WalletSingleUse = "mvErcbPuL4T4kxbJYejk6xLbv8pfBiiSPu";
            WalletSingleUseKey = "cNn38kw6LSfAS6WvJJbFTqWRewa1GgfwczftXrBcyAmygM1V7qKr";
            ClientId = "b623b171-a307-4485-897c-f3a70b763217";
        }
    }
}
