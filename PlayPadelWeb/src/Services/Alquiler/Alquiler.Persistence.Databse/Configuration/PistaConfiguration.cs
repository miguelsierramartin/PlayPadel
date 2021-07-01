using Alquiler.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alquiler.Persistence.Databse.Configuration
{
    public class PistaConfiguration
    {
        public PistaConfiguration(EntityTypeBuilder<Domain.Pista> entityBuilder)
        {
            entityBuilder.HasKey(x => x.PistaID);
            entityBuilder.Property(x => x.Nombre).IsRequired().HasMaxLength(100);

            var pistas = new List<Pista>();

            for (var i = 1; i <= 10; i++)
            {
                pistas.Add(new Pista
                {
                    PistaID = i,
                    Nombre = (Common.Enums.PistaNumerada)i-1
                }) ;
            }

            entityBuilder.HasData(pistas);
        }
    }
}
