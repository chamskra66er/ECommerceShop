using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public interface IEmailGoogle
    {
        Task SendEmailAsync(string emailFrom, string emailTo, string subject, string message);
    }
}
