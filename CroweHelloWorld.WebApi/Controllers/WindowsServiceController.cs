﻿using CroweHelloWorld.WebApi.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CroweHelloWorld.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WindowsServiceController : ControllerBase, IMessageController
    {
        [HttpGet]
        public string GetMessage()
        {
            throw new NotImplementedException();
        }
    }
}
