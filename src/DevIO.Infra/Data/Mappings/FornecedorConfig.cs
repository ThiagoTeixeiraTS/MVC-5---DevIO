﻿using DevIO.Business.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Infra.Data.Mappings
{
    public class FornecedorConfig : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfig()
        {
            HasKey(f => f.Id);
            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(f => f.Documento)
                .IsRequired()
                .HasMaxLength(14)
                .HasColumnAnnotation(name: "index",
                value: new IndexAnnotation(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute { IsUnique = true }));


            HasRequired(f => f.Endereco)
                .WithRequiredPrincipal(f => f.Fornecedor);

            ToTable("Fornecedores");
    }
    }
}
