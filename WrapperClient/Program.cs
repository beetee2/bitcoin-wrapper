﻿using System;
using System.Configuration;
using System.Globalization;
using BitcoinWrapper.Wrapper;

namespace WrapperClient
{
    internal sealed class Program
    {
        static void Main()
        {
            BaseBtcConnector baseBtcConnector = new BaseBtcConnector();
            Console.Write("Connecting to bitcoin daemon: " + ConfigurationManager.AppSettings["ServerIp"] + "...");
            Double networkDifficulty = baseBtcConnector.GetDifficulty();
            Console.WriteLine("OK\n\nBTC Network Difficulty: " + networkDifficulty.ToString("#,#", CultureInfo.InvariantCulture));
            Decimal myBalance = baseBtcConnector.GetBalance();
            Console.WriteLine("My balance: " + myBalance + " BTC");
            Console.ReadLine();
        }
    }
}
