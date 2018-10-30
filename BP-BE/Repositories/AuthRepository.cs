using Data;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly BefordingTestContext _context;

        public AuthRepository(BefordingTestContext context)
        {
            _context = context;
        }
    }
}
