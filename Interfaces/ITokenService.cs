using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kalashop.Models;

namespace kalashop.Interfaces
{
    public interface ITokenService
    {  
        string CreateToken(User user);
    }
}