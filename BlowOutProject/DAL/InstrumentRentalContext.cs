using BlowOutProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlowOutProject.DAL
{
    public class InstrumentRentalContext : DbContext
    {
        public InstrumentRentalContext()
            : base("InsturmentRentalContext")
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
    }
}