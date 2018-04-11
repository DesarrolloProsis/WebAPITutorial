using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAPITutorial.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int UnidadesEnAlmacen { get; set; }
    }

    public class ProductoDbContext : DbContext
    {
        public DbSet<Producto> Producto { get; set; }        
    }
}