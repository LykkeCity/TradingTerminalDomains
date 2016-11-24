﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IClientTrade : IBaseCashBlockchainOperation
    {
        string LimitOrderId { get; }
        string MarketOrderId { get; }
        double Price { get; }
        DateTime? DetectionTime { get; set; }
        int Confirmations { get; set; }
    }


    public class ClientTrade : IClientTrade
    {
        public string Id { get; set; }
        public string ClientId { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsHidden { get; set; }
        public string LimitOrderId { get; set; }
        public string MarketOrderId { get; set; }
        public double Amount { get; set; }
        public string AssetId { get; set; }
        public string BlockChainHash { get; set; }
        public string Multisig { get; set; }
        public string TransactionId { get; set; }
        public string AddressFrom { get; set; }
        public string AddressTo { get; set; }
        public bool? IsSettled { get; set; }
        public double Price { get; set; }
        public DateTime? DetectionTime { get; set; }
        public int Confirmations { get; set; }
    }

    public interface IClientTradesRepository
    {
        Task AddAsync(IEnumerable<IClientTrade> clientTrades);
    }

}