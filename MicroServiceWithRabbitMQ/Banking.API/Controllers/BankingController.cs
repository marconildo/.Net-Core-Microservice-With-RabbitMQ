﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banking.Application.Interfaces;
using Banking.Application.Models;
using Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        // GET api/banking
        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

        [HttpPost]
        public IActionResult Post([FromBody] AccountTransferModels accountTransfer)
        {
            _accountService.Transfer(accountTransfer);
            return Ok(accountTransfer);
        }
    }
}
