using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QrCodeMobileApp
{
    public interface IScanService
    {
        Task<string> Scan();
    }
}
