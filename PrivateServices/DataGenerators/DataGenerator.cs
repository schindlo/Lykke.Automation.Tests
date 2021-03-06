﻿using LykkeAutomationPrivate.Models.ClientAccount.Models;
using LykkeAutomationPrivate.Models.Registration.Models;
using System;
using System.Collections.Generic;
using System.Text;
using XUnitTestCommon.TestsData;

namespace LykkeAutomationPrivate.DataGenerators
{
    public static class DataGenerator
    {
        public static AccountRegistrationModel GetTestModel(this AccountRegistrationModel model)
        {
            return new AccountRegistrationModel()
            {
                Email = TestData.GenerateEmail(),
                FullName = TestData.FullName(),
                ContactPhone = TestData.GeneratePhone(),
                Password = "1234567",
                Hint = TestData.GenerateString(5)
                //ClientInfo = 
                //UserAgent = 
                //PartnerId = 
                //Ip = 
                //Changer = 
                //IosVersion = 
                //Referer = 
            };
        }

        public static CreateWalletRequest GetTestModel(this CreateWalletRequest wallet, string clientId, WalletType walletType = WalletType.Trusted)
        {
            return new CreateWalletRequest()
            {
                ClientId = clientId,
                Name = TestData.GenerateString(10),
                Type = walletType,
                Description = TestData.GenerateString(15)
            };
        }

        public static ModifyWalletRequest GetTestModel(this ModifyWalletRequest modify) =>
            new ModifyWalletRequest()
            {
                Name = "Brand new test name",
                Description = "Brand new test description"
            };

        public static ClientRegistrationModel GetTestModel(
            this ClientRegistrationModel clientRegistration, string partnerId = null) =>
            new ClientRegistrationModel
            {
                Email = TestData.GenerateEmail(),
                Phone = TestData.GeneratePhone(),
                Password = "1234567",
                PartnerId = partnerId
            };

        public static Partner GetTestModel(this Partner partner) =>
            new Partner()
            {
                InternalId = Guid.NewGuid().ToString(),
                PublicId = Guid.NewGuid().ToString("N"),
                Name = TestData.GenerateLetterString(7),
                AssetPrefix = TestData.GenerateLetterString(5) + "_",
                RegisteredUsersCount = 0
            };
    }
}
