using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Estacionamiento.Models
{
    public class EstacionamientosDB : DbContext
    {
        public DbSet<Estacionamientos> Estacionamientos { get; set; }


    }

}

