using ApiTest.Models;
using ApiTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiTest.Controllers
{
    public class SelectSalesTranController : ApiController
    {
        private SalesTranRepository salesTranRepository;

        public SelectSalesTranController()
        {
            this.salesTranRepository = new SalesTranRepository();
        }
        public List<SalesTranDTO> Post(SalesTranInput salesTranInput)
        {
            return this.salesTranRepository.getList(salesTranInput); 
        }

    }
}
