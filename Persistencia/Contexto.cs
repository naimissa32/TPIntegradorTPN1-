using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupo4.Persistencia;
using TPGrupo4.Clases;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace TPGrupo4.Persistencia
{
    public class Contexto : DbContext
    {
        // Usando el namespace completo de DbSet
        private Microsoft.EntityFrameworkCore.DbSet<Cliente> Clientes { get; set; }
        private Microsoft.EntityFrameworkCore.DbSet<Domicilio> Domicilios { get; set; }
        private Microsoft.EntityFrameworkCore.DbSet<Objeto> Objetos { get; set; }
        private Microsoft.EntityFrameworkCore.DbSet<Venta> Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configuración de la cadena de conexión para SQL Server
            optionsBuilder.UseSqlServer("Data Source=ingresar_servidor;Initial Catalog=ClientesDb;Trusted_Connection=True;TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
