using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public class Control
    {
        private Inventario inventario;
        private Carrito carrito;
        private string leerRegistros;
        private string[] registros;
        public Control()
        {
            inventario = new Inventario();
            carrito = new Carrito();
            leerRegistros = File.ReadAllText("Registro.txt");
        }

        internal void CargarInventarioDeAlmacen(){
            string nombre;
            string material;
            double precio;
            int categoria;
            int exitencias;
            int id;
            registros = leerRegistros.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string[] columnas;
            
            foreach (string fila in registros)
            {
                columnas = fila.Split(',');                
                nombre = columnas[0];
                precio = Convert.ToDouble(columnas[1]);
                categoria = Convert.ToInt32(columnas[2]);
                material = columnas[3];
                exitencias = Convert.ToInt32(columnas[4]);
                id = Convert.ToInt32(columnas[5]);

                inventario.AddProducto(new Producto(nombre, precio, categoria, material, exitencias, id)); 
            }
        }

        internal Inventario GetInventario() 
        { 
            return inventario; 
        }

        internal Carrito GetCarrito() 
        { 
            return carrito; 
        }

    }
}

