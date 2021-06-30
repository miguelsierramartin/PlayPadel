using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alquiler.Persistence.Databse.Configuration
{
    public class ReservaConfiguration
    {
        public ReservaConfiguration(EntityTypeBuilder<Domain.Reserva> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ReservaID);
        }
    }
}
