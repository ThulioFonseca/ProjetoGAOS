using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProjetoGAOS.Models
{
    public partial class AulaContext : DbContext
    {
        public AulaContext()
        {
        }

        public AulaContext(DbContextOptions<AulaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Dispositivo> Dispositivos { get; set; }
        public virtual DbSet<OrdemDeServico> OrdemDeServicos { get; set; }
        public virtual DbSet<Tecnico> Tecnicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.*/
                optionsBuilder.UseNpgsql("DBconnetionsString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Cpf)
                    .HasName("cliente_pkey");

                entity.ToTable("cliente", "thuliofonseca");

                entity.Property(e => e.Cpf)
                    .HasMaxLength(20)
                    .HasColumnName("cpf");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .HasMaxLength(150)
                    .HasColumnName("nome");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(50)
                    .HasColumnName("telefone");
            });

            modelBuilder.Entity<Dispositivo>(entity =>
            {
                entity.HasKey(e => e.Identificador)
                    .HasName("dispositivo_pkey");

                entity.ToTable("dispositivo", "thuliofonseca");

                entity.Property(e => e.Identificador)
                    .HasMaxLength(50)
                    .HasColumnName("identificador");

                entity.Property(e => e.Categoria)
                    .HasMaxLength(50)
                    .HasColumnName("categoria");

                entity.Property(e => e.Fabricante)
                    .HasMaxLength(50)
                    .HasColumnName("fabricante");

                entity.Property(e => e.Modelo)
                    .HasMaxLength(100)
                    .HasColumnName("modelo");
            });

            modelBuilder.Entity<OrdemDeServico>(entity =>
            {
                entity.ToTable("ordem_de_servico", "thuliofonseca");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(20)
                    .HasColumnName("cliente");

                entity.Property(e => e.Data)
                    .HasMaxLength(150)
                    .HasColumnName("data");

                entity.Property(e => e.Identificador)
                    .HasMaxLength(50)
                    .HasColumnName("identificador");

                entity.Property(e => e.Orcamento)
                    .HasMaxLength(50)
                    .HasColumnName("orcamento");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.OrdemDeServicos)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("ordem_de_servico_cliente_fkey");

                entity.HasOne(d => d.IdentificadorNavigation)
                    .WithMany(p => p.OrdemDeServicos)
                    .HasForeignKey(d => d.Identificador)
                    .HasConstraintName("ordem_de_servico_identificador_fkey");
            });

            modelBuilder.Entity<Tecnico>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("tecnico_pkey");

                entity.ToTable("tecnico", "thuliofonseca");

                entity.Property(e => e.Codigo)
                    .HasMaxLength(20)
                    .HasColumnName("codigo");

                entity.Property(e => e.Nome)
                    .HasMaxLength(150)
                    .HasColumnName("nome");

                entity.Property(e => e.Telefone)
                    .HasMaxLength(50)
                    .HasColumnName("telefone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
