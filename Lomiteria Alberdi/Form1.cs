using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lomiteria_Alberdi
{
    public partial class Form1 : Form
    {
        private Producto[] compra = new Producto[10];
        private int indice = 0;
        string decision;
        bool volver= false;
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        public class Producto
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public string Descripcion { get; set; }


            public Producto(string nombre, double precio, string descripcion)
            {
                Nombre = nombre;
                Precio = precio;
                Descripcion = descripcion;

            }

        }

        public void Agregados()
        {
            panel.Visible = true;
            lblAgregados.Visible = true;
            checkTomate.Visible = true;
            checkLechuga.Visible = true;
            checkQueso.Visible = true;
            checkJamon.Visible = true;
            checkHuevo.Visible = true;
            btnAgregar.Visible = true;
        }

        public void OcultarPrincipal()
        {
            lblTitulo.Visible = false;
            lblMenu.Visible = false;
            txtEleccion.Visible = false;
            btnAceptar.Visible = false;
        }

        public void MostrarPrincipal()
        {
            lblTitulo.Visible = true;
            lblMenu.Visible = true;
            txtEleccion.Visible = true;
            btnAceptar.Visible = true;
            panel1.Visible = true;

        }



        public void Menu()
        {
            if (txtEleccion.Text != "" && txtEleccion.Text != null)
            {


                switch (decision)
                {
                    case "1":
                        Agregados();
                        OcultarPrincipal();
                       
                        break;
                    case "2":
                        Agregados();
                        OcultarPrincipal();
                        break;
                    case "3":
                        Agregados();
                        OcultarPrincipal();
                        break;
                    case "4":
                        OcultarPrincipal();
                        break;
                    case "9":

                        break;
                    default:
                        lblError.Text = "Opción invalida, intentelo nuevamente";
                        break;
                }

            }

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decision = txtEleccion.Text;
            Menu();         
        }

   

        private void LimpiarChecks()
        {
            checkTomate.Checked = false;
            checkLechuga.Checked = false;
            checkQueso.Checked = false;
            checkJamon.Checked = false;
            checkHuevo.Checked = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = "Agregados: ";
            if (checkTomate.Checked) descripcion += "Tomate ";
            if (checkLechuga.Checked) descripcion += "Lechuga ";
            if (checkQueso.Checked) descripcion += "Queso ";
            if (checkJamon.Checked) descripcion += "Jamón ";
            if (checkHuevo.Checked) descripcion += "Huevo ";

            switch (decision)
            {
                case "1":
                    compra[indice] = new Producto("Sanguche de lomito", 1500.00, descripcion);
                    break;
                case "2":
                    compra[indice] = new Producto("Sanguche de milanesa", 1200.00, descripcion);
                    break;
                case "3":
                    compra[indice] = new Producto("Hamburguesa", 1000.00, descripcion);
                    break;
                case "4":
                    compra[indice] = new Producto("Papas fritas", 500.00, descripcion = "");
                    break;
            }

            
            btvolver.Visible = true;
            LimpiarChecks();
            panel.Visible = false;
            mostrarProductos();
            panel1.Visible = true;

        }

        public void mostrarProductos()
        {
            lblError.Visible = true;
            lblError.Text = "Producto agregado con éxito! " + compra[indice].Nombre + compra[indice].Precio + compra[indice].Descripcion;
            
            indice++;
        } 

        private void btvolver_Click(object sender, EventArgs e)
        {
            //lblError.Visible = false;
            //MostrarPrincipal();
            //panel1.Visible=false;
            //txtEleccion.Text = "";
            volver = true;
        }



        private void btFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
