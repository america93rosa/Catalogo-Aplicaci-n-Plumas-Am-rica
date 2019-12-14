using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Catalogo
{
    public partial class VentanaDetalles : Form{
        private int idImagen;
        public VentanaDetalles()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e){  }
        internal void FijarImagen(PictureBox picturebox,int idImagen,int noMaxPiezas) 
        { 
            pictureBox1.Image=picturebox.Image;
            this.idImagen = idImagen;
            numericUpDown1.Maximum = noMaxPiezas;
        }
        internal void FijarLabel(String lbl) 
        { 
            label1.Text = lbl; 
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e){}
        private void Button1_Click(object sender, EventArgs e){
            StreamWriter agregar = File.AppendText("Venta.txt");
            agregar.WriteLine(idImagen+","+numericUpDown1.Value);
            agregar.Close();
            MessageBox.Show("Articulo añadido al carrito");
        }
    }
}
