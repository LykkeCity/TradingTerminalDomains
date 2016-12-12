﻿using System.Threading.Tasks;

namespace Lykke.Terminal.Domain.Exchange
{
    public interface IDoneOrderService
    {
        Task<IDoneOrder> CreateDoneOrderAsync(IOrderBase order, OrderStatus orderStatus, OrderComment orderComment,
            double profitLoss = double.NaN);
    }
}