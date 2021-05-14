using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zajigalka.Services
{
     public interface IUserService
     {
        string RollingUser7();
        TimeSpan[] GetLiveSpan();
     }
}
