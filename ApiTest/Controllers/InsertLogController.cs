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
    public class InsertLogController : ApiController
    {
        private LogRepository logRepository;
        public InsertLogController()
        {
            this.logRepository = new LogRepository();
        }
        public HttpResponseMessage Post(Log log)
        {
            this.logRepository.insertLog(log);
            var response = Request.CreateResponse<Log>(System.Net.HttpStatusCode.Created, log);

            return response;
        }
    }
}
