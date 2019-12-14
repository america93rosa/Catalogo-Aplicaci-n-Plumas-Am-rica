using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    class Carrito
    {
        private ArrayList ventas;
        private double total;

        public Carrito()
        {
            ventas = new ArrayList();
            total = 0;
        }

        internal double GetTotal() 
        { 
            return total; 
        }

        internal void AgregarVenta(Venta venta)
        {
            ventas.Add(venta);
            total = total + venta.GetsubTotal();   
        }

        /*Elimina una venta de la lista de ventas*/
        internal void EliminarVenta(int indice) 
        {
            total = total - ((Venta)ventas[indice]).GetsubTotal();
            ventas.RemoveAt(indice);
        }

        internal Venta GetVenta(int indice)
        {
            return (Venta)ventas[indice];
        }
        
        internal  Venta[] GetVentas()
        {
            Venta[] listaVentas=new Venta[ventas.Count];
            for (int i=0;i<ventas.Count;i++) {
                listaVentas[i] = (Venta)ventas[i];
            }

            return listaVentas;
        }
    }
}
