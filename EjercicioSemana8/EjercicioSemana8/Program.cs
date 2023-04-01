using System;
using EjercicioSemana8.DAO;
using EjercicioSemana8.Models;
while (true)
{
    Console.WriteLine("Selecciona una opción del menú");
    Console.WriteLine("1 - Guardar");
    Console.WriteLine("2 - Listar");
    Console.WriteLine("3 - Eliminar"); 
    Console.WriteLine("4 - Actualizar");
    Console.WriteLine("5 - Salir");
    int op = int.Parse(Console.ReadLine());
    Producto producto = new Producto();
    crudProductos CrudProductos = new crudProductos();
    switch (op)
    {
        case 1:
            
            Console.WriteLine("Por Favor Digite el Nombre");
            producto.Nombre = Console.ReadLine();
            Console.WriteLine("Por Favor Digite La Descripcion");
            producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Por Favor Digite El Precio");
            producto.Precio = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Por Favor Digite el Stock");
            producto.Stock = int.Parse(Console.ReadLine());
            CrudProductos.guardar(producto);
            break;
        case 2:
            var lista = CrudProductos.Listar();
            foreach(var item in lista)
            {
                Console.WriteLine($"ID {item.Id}");
                Console.WriteLine($"Nombre {item.Nombre}");
                Console.WriteLine($"Descripcion {item.Descripcion}");
                Console.WriteLine($"Precio {item.Precio}");
                Console.WriteLine($"Stock {item.Stock}");
            }
            break;
        case 3:
            Console.WriteLine("Ingresa el ID a eliminar");
            producto.Id = Convert.ToInt32(Console.ReadLine());
            if(CrudProductos.ListarProductoPorId(producto) != null)
            {
                CrudProductos.Eliminar(producto);
            }
            break;
        case 4:
            Console.WriteLine("Ingresa el ID a actualizar");
            producto.Id = Convert.ToInt32(Console.ReadLine());
            if (CrudProductos.ListarProductoPorId(producto) != null)
            {
                Console.WriteLine("Por Favor Digite el Nombre actualizado");
                producto.Nombre = Console.ReadLine();
                Console.WriteLine("Por Favor Digite La Descripcion actualizado");
                producto.Descripcion = Console.ReadLine();
                Console.WriteLine("Por Favor Digite El Precio actualizado");
                producto.Precio = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Por Favor Digite el Stock actualizado");
                producto.Stock = int.Parse(Console.ReadLine());
                CrudProductos.Actualizar(producto);
            }
            break;
        case 5:
            break;
    }
    Console.WriteLine("Selecciona una opción");
    Console.WriteLine("1 - Ejecutar de nuevo");
    Console.WriteLine("2 - Salir");
    int seguir = int.Parse(Console.ReadLine());
    if (seguir.Equals(2))
    {
        break;
    }
    
}