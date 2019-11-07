﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Application.Models
{
    public class AccountTransferModels
    {
        public int FromAccount { get; set; }

        public int ToAccount { get; set; }

        public decimal TransferAmount { get; set; }
    }
}