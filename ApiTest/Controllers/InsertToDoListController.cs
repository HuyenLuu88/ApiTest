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
    public class InsertToDoListController : ApiController
    {
        private ToDoListRepository toDoListRepository;
        public InsertToDoListController()
        {
            this.toDoListRepository = new ToDoListRepository();
        }

        public HttpResponseMessage Post(ToDoList toDoList)
        {
            this.toDoListRepository.insertToDoList(toDoList);
            var response = Request.CreateResponse<ToDoList>(System.Net.HttpStatusCode.Created, toDoList);

            return response;
        }
    }
}
