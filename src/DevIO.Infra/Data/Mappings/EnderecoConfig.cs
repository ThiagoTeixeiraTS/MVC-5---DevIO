using DevIO.Business.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Infra.Data.Mappings
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(p => p.Id);

            Property(p => p.Logradouro)
                .IsRequired()
                .HasMaxLength(200);

            Property(f => f.Numero)
                .IsRequired()
                .HasMaxLength(50);

            Property(f => f.Cep)
                .IsRequired()
                .HasMaxLength(8)
            .IsFixedLength();

            Property(f => f.Complemento)
                    .HasMaxLength(250);


            Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(200);


            Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(100);

            ToTable("Enderecos");





        }
    }
}
