using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCI_TSP_API.Dto.User
{
    public class TokenResponse
    {
        public string JWTToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
