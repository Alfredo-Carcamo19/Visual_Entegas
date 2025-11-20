using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace Practica6_PV
{
    // 1. Definimos la conexión a la base de datos (El DataContext)
    public class DatosVentasDataContext : DataContext
    {
        // Cadena de conexión directa a tu base de datos LocalDB
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_ventas;Integrated Security=True";

        public DatosVentasDataContext() : base(connectionString) { }

        // Definimos las tablas
        public Table<Catalogo> Catalogo;
        public Table<Factura> Factura;
        public Table<Producto> Producto;
    }

    // 2. Mapeamos la tabla Catalogo
    [Table(Name = "Catalogo")]
    public class Catalogo
    {
        [Column(IsPrimaryKey = true)]
        public int Codigo { get; set; }

        [Column]
        public string Nombre { get; set; }

        [Column]
        public double Precio { get; set; }
    }

    // 3. Mapeamos la tabla Factura
    [Table(Name = "Factura")]
    public class Factura
    {
        [Column(IsPrimaryKey = true)]
        public int Codigo { get; set; }

        [Column]
        public string Cliente { get; set; }

        [Column]
        public string Fecha { get; set; }

        // Relación con productos (Uno a Muchos)
        private EntitySet<Producto> _Producto = new EntitySet<Producto>();

        [Association(Storage = "_Producto", OtherKey = "Fk_Codigo", ThisKey = "Codigo")]
        public EntitySet<Producto> Producto
        {
            get { return this._Producto; }
            set { this._Producto.Assign(value); }
        }
    }

    // 4. Mapeamos la tabla Producto
    [Table(Name = "Producto")]
    public class Producto
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column]
        public int Codigo { get; set; }

        [Column]
        public string Nombre { get; set; }

        [Column]
        public double Precio { get; set; }

        [Column]
        public int Cantidad { get; set; }

        [Column]
        public int Fk_Codigo { get; set; }
    }
}