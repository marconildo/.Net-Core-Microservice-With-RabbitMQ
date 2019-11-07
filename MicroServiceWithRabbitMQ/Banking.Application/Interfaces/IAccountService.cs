﻿using Banking.Application.Models;
using Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();

        void Transfer(AccountTransferModels accountTransfer);
    }
}
