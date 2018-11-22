using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Estacionamiento.Models
{
    public class EstacionamientosInitializer : CreateDatabaseIfNotExists<EstacionamientosDB>
    {
        protected override void Seed(EstacionamientosDB context)
        {
            base.Seed(context);
            var Estacionamientos = new List<Estacionamientos>
            {
                new Estacionamientos

                {
                    Fecha = DateTime.Now,
                    Nivel = 2,
                    Placas = "asd3-we3",

                }
            };
            Estacionamientos.ForEach(s => context.Estacionamientos.Add(s));
            context.SaveChanges();
        }
    }
}
