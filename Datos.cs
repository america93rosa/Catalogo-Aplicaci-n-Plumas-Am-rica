using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Catalogo
{


    class Datos
    {
        //Leer el archivo y llama al metodo agregarFilaDatagridview para que por cada linea del bloc agregue una linea

            public void lecturaArchivo(DataGridView tabla, char caracter, string ruta)
        {
            StreamReader objReadme = new StreamReader(ruta);
            string sLine = "";
            int fila = 0;
            tabla.Rows.Clear();
            tabla.AllowUserToAddRows = false;

            do
            {
                sLine = objReadme.ReadLine();
                if ((sLine != null))
                {
                    if (fila == 0)
                    {
                        tabla.ColumnCount = sLine.Split(caracter).Length;
                        nombrarTitulo(tabla, sLine.Split(caracter));
                        fila += 1;
                    }
                    else
                    {
                        agregarFilaDatagridview(tabla, sLine, caracter, fila);
                        fila += 1;
                    }
                }
            }
            while (!(sLine == null));
            objReadme.Close();
        }

        //Agrega el HeaderText al datagridview(SON LOS TITULOS)
        public static void nombrarTitulo(DataGridView tabla, string[] titulos)
        {
            int x = 0;
            for(x=0; x<=tabla.ColumnCount-1; x++)
            {
                tabla.Columns[x].HeaderText = titulos[x];
            }
        }

        //Agrega una fila por cada linea de bloc de notas
        public static void agregarFilaDatagridview(DataGridView tabla, string linea, char caracter, int fila)
        {
            string[] arreglo = linea.Split(caracter);
            tabla.Rows.Add(arreglo);
        }

        public string nombre { get; set; }
        string cantidad { get; set;}
        double precio { get; set; }

        

        //Propiedades

        /* public string Nombre
         {
             set { nombre = value; }
             get { return nombre; }
         }

         public string Cantidad
         {
             set { cantidad = value; }
             get { return cantidad; }
         }

         public double Precio
         {
             set { precio = value; }
             get { return precio; }

         }*/
    }



}
