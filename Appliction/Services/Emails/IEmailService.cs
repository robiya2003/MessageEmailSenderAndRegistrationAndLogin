using Domains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliction.Services.Emails
{
    public interface IEmailService
    {
        public Task SendEmailAsync(EmailModel emailModel);
    }
}
