﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloBlazor.Server.Models;
using HelloBlazor.Shared;
using Microsoft.EntityFrameworkCore;

namespace HelloBlazor.Server.Controllers
{
    [Route("specials")]
    [ApiController]
    public class SpecialController : ControllerBase
    {
        private readonly PizzaStoreContext Context;
        public SpecialController(PizzaStoreContext context)
        {
            this.Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
        {
            return await Context.Specials
            .OrderByDescending(s => s.BasePrice).ToListAsync();
        }

    }
}
