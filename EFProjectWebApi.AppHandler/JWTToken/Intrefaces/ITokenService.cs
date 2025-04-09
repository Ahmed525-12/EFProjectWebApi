using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProjectWebApi.AppHandler.JWTToken
{
    public interface ITokenService
    {
        public Task<string> CreateToken(Object user);
    }
}