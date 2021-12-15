﻿using AspnetRunBasics.Extensions;
using AspnetRunBasics.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AspnetRunBasics.Services.Impl
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _client;

        public OrderService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<DeliveryModel>> GetDeliveryInfos(string strCustomerId)
        {
            var response = await _client.GetAsync($"/Order/GetDeliveryInfos/{strCustomerId}");
            return await response.ReadContentAs<List<DeliveryModel>>();
        }

        public async Task<IEnumerable<PaymentModel>> GetPaymentInfos(string strCustomerId)
        {
            var response = await _client.GetAsync($"/Order/GetPaymentInfos/{strCustomerId}");
            return await response.ReadContentAs<List<PaymentModel>>();
        }

        public async Task<SOModel> GetSO(string strCustomerId, string strSaleOrderId)
        {
            var response = await _client.GetAsync($"/Order/GetSO/{strCustomerId}/{strSaleOrderId}");
            return await response.ReadContentAs<SOModel>();
        }

        public async Task<IEnumerable<SOModel>> GetSaleOrderList(string strCustomerId)
        {
            var response = await _client.GetAsync($"/Order/GetSaleOrderList/{strCustomerId}");
            return await response.ReadContentAs<List<SOModel>>();
        }
    }
}
