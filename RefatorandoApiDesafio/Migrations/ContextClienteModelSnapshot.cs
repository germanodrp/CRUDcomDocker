// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RefatorandoApiDesafio.Context;

#nullable disable

namespace RefatorandoApiDesafio.Migrations
{
    [DbContext(typeof(ContextCliente))]
    partial class ContextClienteModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RefatorandoApiDesafio.Models.Cliente", b =>
                {
                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cpf");

                    b.ToTable("Cliente", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
