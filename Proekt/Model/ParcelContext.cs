using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt.Model
{
    public class ParcelContext : DbContext 
    {
        public ParcelContext() :base("ParcelContext")
        {

        }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<ParcelType> ParcelTypes { get; set; }
    }
}
