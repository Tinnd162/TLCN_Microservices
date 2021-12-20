﻿using Aggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aggregator.Services
{
    public interface IInventoryService
    {
        public Task<InventoryModel> GetProductDetailById(string strProductId, string strToken);
        public Task<bool> UpdateNumberOfSaleAfterSO(List<ParamsUpdateModel> lstObjParams, string strToken);
    }
}
