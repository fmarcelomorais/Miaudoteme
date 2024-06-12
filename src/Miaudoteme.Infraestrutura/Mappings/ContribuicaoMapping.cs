using Miaudoteme.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miaudoteme.Infraestrutura.Mappings
{
    public class ContribuicaoMapping : IEntityTypeConfiguration<Contribuicao>
    {
        public void Configure(EntityTypeBuilder<Contribuicao> builder)
        {
            builder.ToTable("Contribuicoes");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.FormaDePagamento).HasConversion<string>().IsRequired();
            builder.Property(c => c.NumeroCartao).HasConversion<string>();
            builder.Property(c => c.ChavePix).HasConversion<string>();
            builder.Property(c => c.Valor).HasPrecision(10, 2).IsRequired();
            builder.Property(c => c.Parcelas).IsRequired();


        }
    }
}
