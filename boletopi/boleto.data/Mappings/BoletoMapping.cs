using boletoapi.business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boleto.data.Mappings
{
    public class BoletoMapping : IEntityTypeConfiguration<Boleto>
    {
        public void Configure(EntityTypeBuilder<Boleto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.NomePagador)
               .IsRequired()
               .HasColumnType("varchar(200)");

            builder.Property(c => c.CPF_CNPJ_Pagador)
              .IsRequired()
              .HasColumnType("varchar(20)");

            builder.Property(c => c.NomeBeneficiario)
              .IsRequired()
              .HasColumnType("varchar(200)");

            builder.Property(c => c.CPF_CNPJ_Beneficiário)
              .IsRequired()
              .HasColumnType("varchar(20)");

            builder.Property(c => c.Observacao)
             .IsRequired()
             .HasColumnType("varchar(200)");

        }

    }
}
