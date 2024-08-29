using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.DTOs.Account;

namespace TalentoTrack.Common.Service
{
    public interface IAccountService
    {
        Task<LoginResponse> VerifyLoginDetails(LoginRequest request);
    }
}
