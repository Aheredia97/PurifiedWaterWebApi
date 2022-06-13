using PurifiedWaterWebApi.Context;
using PurifiedWaterWebApi.DAL.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurifiedWaterWebApi.DAL
{
    public class AccountRepository : GenericRepository,IAccountRepository
    {
        private ApplicationDbContext _context;
        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }
    }
}
