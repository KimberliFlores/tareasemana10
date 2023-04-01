using EjercicioSemana8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EjercicioSemana8.DAO
{
    public class crudProductos
    {
        public void guardar(Producto paramProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                Producto producto = new Producto();
                producto.Nombre = paramProducto.Nombre;
                producto.Descripcion = paramProducto.Descripcion;
                producto.Precio = paramProducto.Precio;
                producto.Stock = paramProducto.Stock;
                db.Add(producto);
                db.SaveChanges();
                Console.WriteLine("Producto ingresado correctamente!");
            }
        }
        public List<Producto> Listar()
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                return db.Productos.ToList();
            }
        }
        public Producto ListarProductoPorId(Producto paramProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                return db.Productos.FirstOrDefault(x => x.Id == paramProducto.Id);
            }
        }
        public void Eliminar (Producto paramProducto)
        {

            using (AlmacenContext db = new AlmacenContext())
            {
                db.Remove(paramProducto);
                db.SaveChanges();
            }
        }
        public void Actualizar(Producto paramProducto)
        {
            using (AlmacenContext db = new AlmacenContext())
            {
                db.Update(paramProducto);
                db.SaveChanges();
            }
        }
    }
}
