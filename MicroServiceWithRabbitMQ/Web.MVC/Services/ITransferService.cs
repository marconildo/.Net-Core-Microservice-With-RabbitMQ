using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.MVC.Models.DTO;

namespace Web.MVC.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDTO transferDTO);
    }
}
