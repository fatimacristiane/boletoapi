using boletoapi.business.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco.data.Mappings
{
    public class BancoMapping : IEntityTypeConfiguration<Banco>
    {
        public void Configure(EntityTypeBuilder<Banco> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Nome)
               .IsRequired()
               .HasColumnType("varchar(200)");

            builder.Property(c => c.Cadigo)
              .IsRequired()
              .HasColumnType("varchar(20)");

        }

    }
}
