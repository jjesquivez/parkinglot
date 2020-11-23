using Microsoft.EntityFrameworkCore;
using parkinglot.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parkinglot.Database
{
    public class ParkinglotContext : DbContext, IParkingContext
    {

        #region Constructor
        public ParkinglotContext(DbContextOptions options) : base(options)
        {

        }
        #endregion
    }
}
