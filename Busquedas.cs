using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class Busquedas : Form
    {
       


        //Instancia de la clase Datos
        Datos d = new Datos();
        //Almacena la ruta del archivo . txt
        public string ARCHIVO = "";
        

        private Venta[] ventaBusqueda;
        Conversion convertir = new Conversion();  

      public Busquedas()
        {
            InitializeComponent();
        }

        string[,] ListaVenta = new string[200, 6];
        int filas = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDes.Text = "\n\nSeleccione un producto y presione el botón buscar \n\n";
            
            lblDes.BackColor = Color.Transparent;
        }

        //Abre el openFileDialog y captura la ruta del bloc de notas
        /*public void cargarArchivo()
        {
            try
            {
                this.openFileDialog1.Showdialog();

                if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                {
                    ARCHIVO = this.openFileDialog1.Filename;
                    d.lecturaArchivo(dataGridView1, ',', ARCHIVO);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
        }*/


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "ARETES CARACOL")
            {
                pbxImagenes.Image = Catalogo.Properties.Resources.caracol;
                l1.Text = "Aretes artesanales con caracol natural";
                lblPrecio.Text = "40.00";
            }

            if (comboBox1.Text == "PRENDEDOR GRANDE PAVO REAL")
            {
                pbxImagenes.Image = Catalogo.Properties.Resources.pavogrande;
                l1.Text = "Prendedor para el cabello de pavo real grande";
                lblPrecio.Text = "80.00";
            }
            if (comboBox1.Text == "PRENDEDOR CHICO PAVO REAL")
            {
                pbxImagenes.Image = Catalogo.Properties.Resources.pavochico;
                l1.Text = "Prendedor para el cabello de tamaño pequeño";
                lblPrecio.Text = "55.00";
            }
            if (comboBox1.Text == "PENACHO")
            {

                pbxImagenes.Image = Catalogo.Properties.Resources.penacho;
                l1.Text = "Penacho color vino";
                lblPrecio.Text = "300.00";
            }
            if (comboBox1.Text == "ATRAPA SUEÑOS")
            {
                pbxImagenes.Image = Catalogo.Properties.Resources.atrapasueños;
                l1.Text = "Atrapa sueños lila";
                lblPrecio.Text = "50.00";
            }

            if (comboBox1.Text == "COLLAR")
            {
                pbxImagenes.Image = Catalogo.Properties.Resources.collar;
                l1.Text = "Collar de plumas ";
                lblPrecio.Text = "110.00";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            try
            {
                ListaVenta[filas, 0] = comboBox1.Text;
            ListaVenta[filas, 1] = lblPrecio.Text;
            ListaVenta[filas, 2] = txtCantidad.Text;
            ListaVenta[filas, 3] = (double.Parse(txtCantidad.Text) * double.Parse(lblPrecio.Text)).ToString();
            dataGridView1.Rows.Add(ListaVenta[filas, 0], ListaVenta[filas, 1], ListaVenta[filas, 2], ListaVenta[filas, 3]);
            filas++;

                


            }
            catch
            {
                MessageBox.Show("Error en los datos capturados");
            
                txtCantidad.Clear();
            }
            finally
            {
                txtCantidad.Clear();
                
            
            }
            //cargarArchivo();

        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
            
                int posicion = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.RemoveAt(posicion);
            }

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            
            int j;
            double sub = 0;
            int cuantosrenglones = dataGridView1.Rows.Count;
            if (cuantosrenglones == 0)
            {
                MessageBox.Show("No hay articulos para totalizar");
                return;
            }
            for (j = 0; j <= cuantosrenglones - 1; j++)
            {
                sub = sub + Convert.ToDouble(dataGridView1[3, j].Value);
            }
            
            double total = sub;

            dataGridView1.Rows.Add("", "", "TOTAL:", sub);
            btnQuitar.Enabled = false;
            btnPedir.Enabled = false;
            btnFinalizar.Enabled = false;

            SistemaVentas ventanaSistVentas = new SistemaVentas();
            /*ventanaSistVentasdataGridView1.comboBox1.Tex;
            ventanaSistVentas.Show();
            this.Hide();*/

            //int f = dataGridView1.CurrentCellAddress.Y;
            //int c = dataGridView1.CurrentCellAddress.X;


            //object valorCelda = dataGridView1.Rows[f].Cells[c].Value;

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        /* private void listView1_SelectedIndexChanged(object sender, EventArgs e)
         {

         }*/
    }
    }
    

