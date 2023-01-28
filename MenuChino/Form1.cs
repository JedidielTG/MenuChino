using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuChino
{
    public partial class Form1 : Form
    {
       
        string prueba;
        string pruebat;
        string pruebap, pruebac, pruebad;

        int basetotal = 0;
        int toppingtotall = 0;
        int proteinatotal = 0;
        int crujientestotal = 0;
        int aderezostotal = 0;
        
        
        
        public Form1()
        {          
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fond1.jpg");
            this.BackgroundImage= img;
        }

        
        
        

        private void Arroz_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Arroz.Checked)
            {
                basetotal = basetotal + 1;
            }
            else if (Arroz.Checked == false)
            {
                basetotal = basetotal - 1;
            }
        }

        private void ordenar_Click(object sender, EventArgs e)
        {
            ///BASE////////
            if (basetotal == 1)
            {
                AvisoB.Text = "Base Seleccionada";


            }
            else if (basetotal == 0)
            {
                AvisoB.Text = "Debe Seleccionar una Base";

            }
            else
            {
                AvisoB.Text = "Solo puede seleccionar una base";
            }

            //TOPPING//////

            if (toppingtotall == 3)
            {
                AvisoT.Text = "Topping Seleccionado";
            }
            else if (toppingtotall == 2)
            {
                AvisoT.Text = "Debe Seleccionar un Topping mas";
            }
            else if(toppingtotall == 1)
            {
                AvisoT.Text = "Debe Seleccionar dos Topping mas";
            }
            else if(toppingtotall == 0)
            {
                AvisoT.Text = "Debes Seleccionar algun Topping";
            }
            else
            {
                AvisoT.Text = "Solo Puedes Seleccionar tres topping";
            }

            // PROTEINAS///

            if (proteinatotal == 2)
            {
                AvisoP.Text = "Proteina Seleccionada";
            }
            else if (proteinatotal == 1)
            {
                AvisoP.Text = "Debe Seleccionar una proteina mas";
            }
            else if (proteinatotal == 0)
            {
                AvisoP.Text = "Debe Seleccionar alguna proteina";
            }
            else
            {
                AvisoP.Text = "Solo Puedes Seleccionar dos proteinas";
            }

            //CRUJIENTES//

            if (crujientestotal == 2)
            {
                AvisoC.Text = "Crujiente Seleccionado";
            }
            else if (crujientestotal == 1)
            {
                AvisoC.Text = "Debe Seleccionar una Crujiente mas";
            }
            else if (crujientestotal == 0)
            {
                AvisoC.Text = "Debe Seleccionar alguna Crujiente";
            }
            else
            {
                AvisoC.Text = "Solo Puedes Seleccionar dos Crujientes";
            }

            // ADEREZOS//

            if (aderezostotal == 2)
            {
                AvisoA.Text = "Aderezo Seleccionado";
            }
            else if (aderezostotal == 1)
            {
                AvisoA.Text = "Debe Seleccionar una Aderezo mas";
            }
            else if (aderezostotal == 0)
            {
                AvisoA.Text = "Debe Seleccionar alguna Aderezo";
            }
            else
            {
                AvisoA.Text = "Solo Puedes Seleccionar dos Aderezo";
            }

            if(basetotal == 1 && toppingtotall == 3 && proteinatotal == 2 && crujientestotal == 2 && aderezostotal == 2)
            {
                /// BASE///
                if (Arroz.Checked)
                {
                    prueba = "Arroz";
                }
                else if (Tallarines.Checked)
                {
                    prueba = "Tallarines";
                }
                else if (Fideo.Checked)
                {
                    prueba = "Fideos de Pepino";
                }
                else if (Lechuga.Checked)
                {
                    prueba = "Lechuga";
                }
                /// TOPPING//
                if(Mango.Checked && Durazno.Checked && Tomate.Checked)
                {
                    pruebat = " Mango " +
                              " Durazno " +
                              " Tomate ";
                }
                else if (Mango.Checked && Durazno.Checked && Garbanzo.Checked)
                {
                    pruebat = " Mango " +
                              " Durazno " +
                              " Garbanzo ";
                }
                else if (Mango.Checked && Durazno.Checked && Champiñones.Checked)
                {
                    pruebat = " Mango " +
                              " Durazno " +
                              " Champiñones ";
                }
                else if (Durazno.Checked && Tomate.Checked && Garbanzo.Checked)
                {
                    pruebat = " Durazno " +
                              " Tomate " +
                              " Garbanzo ";
                }
                else if(Durazno.Checked && Tomate.Checked && Champiñones.Checked)
                {
                    pruebat = " Durazno " +
                              " Tomate " +
                              " Champiñones ";
                }
                else if(Tomate.Checked && Garbanzo.Checked && Champiñones.Checked)
                {
                    pruebat = " Tomate " +
                              " Garbanzo " +
                              " Champinones ";
                }
                else if(Garbanzo.Checked && Champiñones.Checked && Mango.Checked)
                {
                    pruebat = " Garbanzo " +
                              " Champinones " +
                              " Mango ";
                }
                else if (Garbanzo.Checked && Champiñones.Checked && Durazno.Checked)
                {
                    pruebat = " Garbanzo " +
                              " Champinones " +
                              " Durazno ";
                }
                else if (Mango.Checked && Tomate.Checked && Champiñones.Checked)
                {
                    pruebat = " Mango " +
                              " Tomate " +
                              " Champiñones ";
                }
                
                /// PROTEINAS ///
                if (Pollo.Checked && Cerdo.Checked)
                {
                    pruebap = "  Pollo " + "  Cerdo ";
                }
                else if(Pollo.Checked && Rollos.Checked)
                {
                    pruebap = " Pollo " + " Rollos Primavera ";
                }
                else if(Pollo.Checked && Surimi.Checked)
                {
                    pruebap = " Pollo " + " Surimi ";
                }
                else if(Cerdo.Checked && Rollos.Checked)
                {
                    pruebap = " Cerdo " + " Rollos Primavera ";
                }
                else if (Cerdo.Checked && Surimi.Checked)
                {
                    pruebap = " Cerdo " + " Surimi ";
                }
                else if (Rollos.Checked && Surimi.Checked)
                {
                    pruebap = " Rollos Primavera " + " Surimi ";
                }

                /// CRUJIENTES //
                if (Arandanos.Checked && Amaranto.Checked)
                {
                    pruebac = " Arandanos " + " Amaranto ";
                }
                else if (Arandanos.Checked && Cacahuate.Checked)
                {
                    pruebac = " Arandenos " + " Cacahuate ";
                }
                else if (Arandanos.Checked && Semilla.Checked)
                {
                    pruebac = " Arandanos " + " Semilla ";
                }
                else if (Amaranto.Checked && Cacahuate.Checked)
                {
                    pruebac = " Amaranto " + " Cacahuate ";
                }
                else if (Amaranto.Checked && Semilla.Checked)
                {
                    pruebac = " Amaranto " + " Semilla ";
                }
                else if (Cacahuate.Checked && Semilla.Checked)
                {
                    pruebac = " Cacahuate " + " Semilla ";
                }

                // ADEREZOS //
                if (HKE.Checked && Salsa.Checked)
                {
                    pruebad = " Aderezos HKE " + " Salsa Agridulce ";
                }
                else if (HKE.Checked && Soya.Checked)
                {
                    pruebad = " Aderezos HKE " + " Soya ";
                }
                else if (HKE.Checked && checkBox21.Checked)
                {
                    pruebad = " Aderezos HKE " + " Aderezo de Mango ";
                }
                else if (Salsa.Checked && Soya.Checked)
                {
                    pruebad = " Salsa Agridulce " + " Soya ";
                }
                else if (Salsa.Checked && checkBox21.Checked)
                {
                    pruebad = " Salsa Agridulce " + " Aderezo de Mango ";
                }
                else if (Soya.Checked && checkBox21.Checked)
                {
                    pruebad = " Soya " + " Aderezo de Mango ";
                }

                MessageBox.Show("///////ORDEN TOMADA PROCESANDO PEDIDO///////");                   
                MessageBox.Show(" ++ TU HAS ORDENADO DE BASE:                  " + prueba + "             ++ TU HAS ORDENADO DE TOPPING:  " + pruebat, "  ++++BASE Y TOPPING+++ " );
                MessageBox.Show("  ++ TU HAS ORDENADO DE PROTEINAS:    " + pruebap + "  ++ TU HAS ORDENADO DE CRUJIENTES:  " + pruebac, "  +++PROTEINA Y CRUJIENTES+++ ");
                MessageBox.Show("  ++ TU HAS ORDENADO DE ADEREZOS:  " + pruebad, "  +++ ADEREZOS  +++");
            }
        }

        //BASE////
        private void Tallarines_CheckedChanged(object sender, EventArgs e)
        {
            if (Tallarines.Checked)
            {
                basetotal = basetotal + 1;
             
            }
            else if (Tallarines.Checked == false)
            {
                basetotal = basetotal - 1;
            }
            
        }

        private void Fideo_CheckedChanged(object sender, EventArgs e)
        {
            if (Fideo.Checked)
            {
                basetotal = basetotal + 1;
            }
            else if (Fideo.Checked == false)
            {
                basetotal = basetotal - 1;
            }
            
        }

        private void Lechuga_CheckedChanged(object sender, EventArgs e)
        {
            if (Lechuga.Checked)
            {
                basetotal = basetotal + 1;
            }
            else if (Lechuga.Checked == false)
            {
                basetotal = basetotal - 1;
            }
            
        }

        // TOPPING///

        private void Mango_CheckedChanged(object sender, EventArgs e)
        {
            if(Mango.Checked)
            {
                toppingtotall = toppingtotall + 1;
            }
            else if(Mango.Checked == false)
            {
                toppingtotall = toppingtotall - 1;
            }
        }

        private void Durazno_CheckedChanged(object sender, EventArgs e)
        {
            if(Durazno.Checked)
            {
                toppingtotall = toppingtotall + 1;
            }
            else if(Durazno.Checked == false)
            { 
                toppingtotall = toppingtotall - 1;
            }
        }

        private void Tomate_CheckedChanged(object sender, EventArgs e)
        {
            if (Tomate.Checked)
            {
                toppingtotall = toppingtotall + 1;   
            }
            else if (Tomate.Checked == false)
            {
                toppingtotall = toppingtotall - 1;
            }
        }

        private void Garbanzo_CheckedChanged(object sender, EventArgs e)
        {
            if (Garbanzo.Checked)
            {
                toppingtotall = toppingtotall + 1;
            }
            else if (Garbanzo.Checked  == false)
            {
                toppingtotall = toppingtotall - 1;
            }
        }

        private void Champiñones_CheckedChanged(object sender, EventArgs e)
        {
            if (Champiñones.Checked)
            {
                toppingtotall = toppingtotall + 1;
            }
            else if (Champiñones.Checked == false)
            {
                toppingtotall = toppingtotall - 1;
            }
        }

        // PROTEINAS///

        private void Pollo_CheckedChanged(object sender, EventArgs e)
        {
            if (Pollo.Checked)
            {
                proteinatotal = proteinatotal + 1;
            }
            else if (Pollo.Checked == false)
            {
                proteinatotal = proteinatotal - 1;
            }
        }

        private void Cerdo_CheckedChanged(object sender, EventArgs e)
        {
            if (Cerdo.Checked)
            {
                proteinatotal = proteinatotal + 1;
            }
            else if (Cerdo.Checked == false)
            {
                proteinatotal = proteinatotal - 1;
            }
        }

        private void Rollos_CheckedChanged(object sender, EventArgs e)
        {
            if (Rollos.Checked)
            {
                proteinatotal = proteinatotal + 1;
            }
            else if (Rollos.Checked == false)
            {
                proteinatotal = proteinatotal - 1;
            }
        }

        private void Surimi_CheckedChanged(object sender, EventArgs e)
        {
            if (Surimi.Checked)
            {
                proteinatotal = proteinatotal + 1;
            }
            else if (Surimi.Checked == false)
            {
                proteinatotal = proteinatotal - 1;
            }
        }

        // CRUJIENTES///

        private void Arandanos_CheckedChanged(object sender, EventArgs e)
        {
            if (Arandanos.Checked)
            {
                crujientestotal = crujientestotal + 1;
            }
            else if (Arandanos.Checked == false)
            {
                crujientestotal = crujientestotal - 1;
            }
        }

        private void Amaranto_CheckedChanged(object sender, EventArgs e)
        {
            if (Amaranto.Checked)
            {
                crujientestotal = crujientestotal + 1;
            }
            else if (Amaranto.Checked == false)
            {
                crujientestotal = crujientestotal - 1;
            }
        }

        private void Cacahuate_CheckedChanged(object sender, EventArgs e)
        {
            if (Cacahuate.Checked)
            {
                crujientestotal = crujientestotal + 1;
            }
            else if (Cacahuate.Checked == false)
            {
                crujientestotal = crujientestotal - 1;
            }
        }

        private void Semilla_CheckedChanged(object sender, EventArgs e)
        {
            if (Semilla.Checked)
            {
                crujientestotal = crujientestotal + 1;
            }
            else if (Semilla.Checked == false)
            {
                crujientestotal = crujientestotal - 1;
            }
        }

        // ADEREZOS ///

        private void HKE_CheckedChanged(object sender, EventArgs e)
        {
            if (HKE.Checked)
            {
                aderezostotal = aderezostotal + 1;
            }
            else if (HKE.Checked == false)
            {
                aderezostotal = aderezostotal - 1;
            }
        }

        private void Salsa_CheckedChanged(object sender, EventArgs e)
        {
            if (Salsa.Checked)
            {
                aderezostotal = aderezostotal + 1;
            }
            else if (Salsa.Checked == false)
            {
                aderezostotal = aderezostotal - 1;
            }
        }

        private void Soya_CheckedChanged(object sender, EventArgs e)
        {
            if (Soya.Checked)
            {
                aderezostotal = aderezostotal + 1;
            }
            else if (Soya.Checked == false)
            {
                aderezostotal = aderezostotal - 1;
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
            {
                aderezostotal = aderezostotal + 1;
            }
            else if (checkBox21.Checked == false)
            {
                aderezostotal = aderezostotal - 1;
            }
        }
    }
}
