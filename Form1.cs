using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Integradora_5_Problema_3
{
    public partial class Form1 : Form
    {
         Veterinaria[] veterinarias = new Veterinaria[1000];
        public int contador = 0;
        public Form1()
        {
            InitializeComponent();
            rbCitasDia.Checked = true;
            lblRango.Visible = false;
            lblServicio.Visible = false;
            dtFiltroFecha.Visible = false;
            dtFiltroFecha2.Visible = false;
            lblhasta.Visible = false;
            txtFiltroServicio.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            veterinarias[contador] = new(txtNombre.Text, txtTipo.Text, dtpFecha.Value.Date, txtServicio.Text);
            txtNombre.Focus();
            txtNombre.Text = string.Empty;
            txtTipo.Text = string.Empty;
            dtpFecha.Value = DateTime.Now;
            txtServicio.Text = string.Empty;
            contador++;
        }

        private void rbCitasDia_CheckedChanged(object sender, EventArgs e)
        {
            lblRango.Visible = false;
            lblServicio.Visible = false;
            dtFiltroFecha.Visible = false;
            dtFiltroFecha2.Visible = false;
            lblhasta.Visible = false;
            txtFiltroServicio.Visible = false;
        }

        private void rbServicios_CheckedChanged(object sender, EventArgs e)
        {
            lblRango.Visible = true;
            lblServicio.Visible = true;
            dtFiltroFecha.Visible = true;
            dtFiltroFecha2.Visible = true;
            lblhasta.Visible = true;
            txtFiltroServicio.Visible = true;
            txtFiltroServicio.Text = string.Empty;
            dtFiltroFecha.Value = DateTime.Now;
        }

        private void rbIngreso_CheckedChanged(object sender, EventArgs e)
        {
            lblRango.Visible = false;
            lblServicio.Visible = true;
            dtFiltroFecha.Visible = false;
            dtFiltroFecha2.Visible = false;
            lblhasta.Visible = false;
            txtFiltroServicio.Visible = true;
            txtFiltroServicio.Text = string.Empty;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string dato = string.Empty;
            int servicios = 0;
            double ingreso1 = 0, ingreso2 = 0, ingreso3 = 0, ingreso4 = 0;
            if (rbCitasDia.Checked)
            {
                rtbInformacion.Text = string.Empty;
                for (int i = 0; i<contador; i++)
                {
                    if (veterinarias[i].Cita.ToShortDateString() == DateTime.Now.ToShortDateString())
                    {
                        dato = string.Format("{0} \r\n{1} {2}", dato, veterinarias[i].Nombre, veterinarias[i].Servicio);
                    }
                }
                rtbInformacion.Text = dato;
            }
            if (rbServicios.Checked)
            {
                rtbInformacion.Text = string.Empty;
                for (int i = 0; i < contador; i++)
                {
                    if (veterinarias[i].Cita >= dtFiltroFecha.Value.Date && veterinarias[i].Cita <= dtFiltroFecha2.Value.Date
                        && veterinarias[i].Servicio.ToUpper() == txtFiltroServicio.Text.ToUpper())
                    {
                        servicios++;
                    }
                }
                rtbInformacion.Text = "Servicios de " + txtServicio.Text + "Realiados en ese Rango: " + servicios;
            }
            if (rbIngreso.Checked)
            {
                rtbInformacion.Text = string.Empty;
                double costo = 0;
                switch (txtFiltroServicio.Text.ToUpper())
                {
                    case "CORTE DE PELO":
                        costo = 120;
                        break;
                    case "DESPARACITAR":
                        costo = 50;
                        break;
                    case "CORTE DE UÑAS":
                        costo = 30;
                        break;
                    case "VACUNA":
                        costo = 250;
                        break;
                    case "PARTO":
                        costo = 500;
                        break;
                    default:
                        MessageBox.Show("Ingrese una opcion valida","Informativo");
                        txtFiltroServicio.Focus();
                        break;
                }

                rtbInformacion.Text = rtbInformacion.Text + "\r\nEnero: ";
                for (int f = 0; f < contador; f++)
                {
                    ValidarSemana(1, f, ref ingreso1, ref ingreso2, ref ingreso3, ref ingreso4);
                }
                ingreso1 = ingreso1 * costo;
                ingreso2 = ingreso2 * costo;
                ingreso3 = ingreso3 * costo;
                ingreso4 = ingreso4 * costo;
                string cadena = string.Format("Semana 1: {0}\r\nSemana 2: {1}\r\nSemana 3: {2}\r\nSemana 4: {3}", 
                    ingreso1.ToString(), ingreso2.ToString(), ingreso3.ToString(), ingreso4.ToString());
                rtbInformacion.Text = string.Format("{0}\r\n{1}", rtbInformacion.Text, cadena);
                ingreso1 = 0; ingreso2 = 0; ingreso3 = 0; ingreso4 = 0;

                rtbInformacion.Text = rtbInformacion.Text + "\r\nFebrero: ";
                for (int f = 0; f < contador; f++)
                {
                    ValidarSemana(2, f, ref ingreso1, ref ingreso2, ref ingreso3, ref ingreso4);
                }
                ingreso1 = ingreso1 * costo;
                ingreso2 = ingreso2 * costo;
                ingreso3 = ingreso3 * costo;
                ingreso4 = ingreso4 * costo;
                cadena = string.Format("Semana 1: {0}\r\nSemana 2: {1}\r\nSemana 3: {2}\r\nSemana 4: {3}",
                    ingreso1.ToString(), ingreso2.ToString(), ingreso3.ToString(), ingreso4.ToString());
                rtbInformacion.Text = string.Format("{0}\r\n{1}", rtbInformacion.Text, cadena);
                ingreso1 = 0; ingreso2 = 0; ingreso3 = 0; ingreso4 = 0;

                rtbInformacion.Text = rtbInformacion.Text + "\r\nMarzo: ";
                for (int f = 0; f < contador; f++)
                {
                    ValidarSemana(3, f, ref ingreso1, ref ingreso2, ref ingreso3, ref ingreso4);
                }
                ingreso1 = ingreso1 * costo;
                ingreso2 = ingreso2 * costo;
                ingreso3 = ingreso3 * costo;
                ingreso4 = ingreso4 * costo;
                cadena = string.Format("Semana 1: {0}\r\nSemana 2: {1}\r\nSemana 3: {2}\r\nSemana 4: {3}",
                    ingreso1.ToString(), ingreso2.ToString(), ingreso3.ToString(), ingreso4.ToString());
                rtbInformacion.Text = string.Format("{0}\r\n{1}", rtbInformacion.Text, cadena);
                ingreso1 = 0; ingreso2 = 0; ingreso3 = 0; ingreso4 = 0;


                rtbInformacion.Text = rtbInformacion.Text + "\r\nAbril: ";
                for (int f = 0; f < contador; f++)
                {
                    ValidarSemana(4, f, ref ingreso1, ref ingreso2, ref ingreso3, ref ingreso4);
                }
                ingreso1 = ingreso1 * costo;
                ingreso2 = ingreso2 * costo;
                ingreso3 = ingreso3 * costo;
                ingreso4 = ingreso4 * costo;
                cadena = string.Format("Semana 1: {0}\r\nSemana 2: {1}\r\nSemana 3: {2}\r\nSemana 4: {3}",
                    ingreso1.ToString(), ingreso2.ToString(), ingreso3.ToString(), ingreso4.ToString());
                rtbInformacion.Text = string.Format("{0}\r\n{1}", rtbInformacion.Text, cadena);
                ingreso1 = 0; ingreso2 = 0; ingreso3 = 0; ingreso4 = 0;

                rtbInformacion.Text = rtbInformacion.Text + "\r\nMayo: ";
                for (int f = 0; f < contador; f++)
                {
                    ValidarSemana(5, f, ref ingreso1, ref ingreso2, ref ingreso3, ref ingreso4);
                }
                ingreso1 = ingreso1 * costo;
                ingreso2 = ingreso2 * costo;
                ingreso3 = ingreso3 * costo;
                ingreso4 = ingreso4 * costo;
                cadena = string.Format("Semana 1: {0}\r\nSemana 2: {1}\r\nSemana 3: {2}\r\nSemana 4: {3}",
                    ingreso1.ToString(), ingreso2.ToString(), ingreso3.ToString(), ingreso4.ToString());
                rtbInformacion.Text = string.Format("{0}\r\n{1}", rtbInformacion.Text, cadena);
                ingreso1 = 0; ingreso2 = 0; ingreso3 = 0; ingreso4 = 0;

                rtbInformacion.Text = rtbInformacion.Text + "\r\nJunio: ";
                for (int f = 0; f < contador; f++)
                {
                    ValidarSemana(6, f, ref ingreso1, ref ingreso2, ref ingreso3, ref ingreso4);
                }
                ingreso1 = ingreso1 * costo;
                ingreso2 = ingreso2 * costo;
                ingreso3 = ingreso3 * costo;
                ingreso4 = ingreso4 * costo;
                cadena = string.Format("Semana 1: {0}\r\nSemana 2: {1}\r\nSemana 3: {2}\r\nSemana 4: {3}",
                    ingreso1.ToString(), ingreso2.ToString(), ingreso3.ToString(), ingreso4.ToString());
                rtbInformacion.Text = string.Format("{0}\r\n{1}", rtbInformacion.Text, cadena);
                ingreso1 = 0; ingreso2 = 0; ingreso3 = 0; ingreso4 = 0;

                rtbInformacion.Text = rtbInformacion.Text + "\r\nJulio: ";
                for (int f = 0; f < contador; f++)
                {
                    ValidarSemana(7, f, ref ingreso1, ref ingreso2, ref ingreso3, ref ingreso4);
                }
                ingreso1 = ingreso1 * costo;
                ingreso2 = ingreso2 * costo;
                ingreso3 = ingreso3 * costo;
                ingreso4 = ingreso4 * costo;
                cadena = string.Format("Semana 1: {0}\r\nSemana 2: {1}\r\nSemana 3: {2}\r\nSemana 4: {3}",
                    ingreso1.ToString(), ingreso2.ToString(), ingreso3.ToString(), ingreso4.ToString());
                rtbInformacion.Text = string.Format("{0}\r\n{1}", rtbInformacion.Text, cadena);
                ingreso1 = 0; ingreso2 = 0; ingreso3 = 0; ingreso4 = 0;

                rtbInformacion.Text = rtbInformacion.Text + "\r\nAgosto: ";
                for (int f = 0; f < contador; f++)
                {
                    ValidarSemana(8, f, ref ingreso1, ref ingreso2, ref ingreso3, ref ingreso4);
                }
                ingreso1 = ingreso1 * costo;
                ingreso2 = ingreso2 * costo;
                ingreso3 = ingreso3 * costo;
                ingreso4 = ingreso4 * costo;
                cadena = string.Format("Semana 1: {0}\r\nSemana 2: {1}\r\nSemana 3: {2}\r\nSemana 4: {3}",
                    ingreso1.ToString(), ingreso2.ToString(), ingreso3.ToString(), ingreso4.ToString());
                rtbInformacion.Text = string.Format("{0}\r\n{1}", rtbInformacion.Text, cadena);
                ingreso1 = 0; ingreso2 = 0; ingreso3 = 0; ingreso4 = 0;

                rtbInformacion.Text = rtbInformacion.Text + "\r\nSeptiembre: ";
                for (int f = 0; f < contador; f++)
                {
                    ValidarSemana(9, f, ref ingreso1, ref ingreso2, ref ingreso3, ref ingreso4);
                }
                ingreso1 = ingreso1 * costo;
                ingreso2 = ingreso2 * costo;
                ingreso3 = ingreso3 * costo;
                ingreso4 = ingreso4 * costo;
                cadena = string.Format("Semana 1: {0}\r\nSemana 2: {1}\r\nSemana 3: {2}\r\nSemana 4: {3}",
                    ingreso1.ToString(), ingreso2.ToString(), ingreso3.ToString(), ingreso4.ToString());
                rtbInformacion.Text = string.Format("{0}\r\n{1}", rtbInformacion.Text, cadena);
                ingreso1 = 0; ingreso2 = 0; ingreso3 = 0; ingreso4 = 0;

                rtbInformacion.Text = rtbInformacion.Text + "\r\nOctubre: ";
                for (int f = 0; f < contador; f++)
                {
                    ValidarSemana(10, f, ref ingreso1, ref ingreso2, ref ingreso3, ref ingreso4);
                }
                ingreso1 = ingreso1 * costo;
                ingreso2 = ingreso2 * costo;
                ingreso3 = ingreso3 * costo;
                ingreso4 = ingreso4 * costo;
                cadena = string.Format("Semana 1: {0}\r\nSemana 2: {1}\r\nSemana 3: {2}\r\nSemana 4: {3}",
                    ingreso1.ToString(), ingreso2.ToString(), ingreso3.ToString(), ingreso4.ToString());
                rtbInformacion.Text = string.Format("{0}\r\n{1}", rtbInformacion.Text, cadena);
                ingreso1 = 0; ingreso2 = 0; ingreso3 = 0; ingreso4 = 0;

                rtbInformacion.Text = rtbInformacion.Text + "\r\nNoviembre: ";
                for (int f = 0; f < contador; f++)
                {
                    ValidarSemana(11, f, ref ingreso1, ref ingreso2, ref ingreso3, ref ingreso4);
                }
                ingreso1 = ingreso1 * costo;
                ingreso2 = ingreso2 * costo;
                ingreso3 = ingreso3 * costo;
                ingreso4 = ingreso4 * costo;
                cadena = string.Format("Semana 1: {0}\r\nSemana 2: {1}\r\nSemana 3: {2}\r\nSemana 4: {3}",
                    ingreso1.ToString(), ingreso2.ToString(), ingreso3.ToString(), ingreso4.ToString());
                rtbInformacion.Text = string.Format("{0}\r\n{1}", rtbInformacion.Text, cadena);
                ingreso1 = 0; ingreso2 = 0; ingreso3 = 0; ingreso4 = 0;

                rtbInformacion.Text = rtbInformacion.Text + "\r\nDiciembre: ";
                for (int f = 0; f < contador; f++)
                {
                    ValidarSemana(12, f, ref ingreso1, ref ingreso2, ref ingreso3, ref ingreso4);
                }
                ingreso1 = ingreso1 * costo;
                ingreso2 = ingreso2 * costo;
                ingreso3 = ingreso3 * costo;
                ingreso4 = ingreso4 * costo;
                cadena = string.Format("Semana 1: {0}\r\nSemana 2: {1}\r\nSemana 3: {2}\r\nSemana 4: {3}",
                    ingreso1.ToString(), ingreso2.ToString(), ingreso3.ToString(), ingreso4.ToString());
                rtbInformacion.Text = string.Format("{0}\r\n{1}", rtbInformacion.Text, cadena);
                ingreso1 = 0; ingreso2 = 0; ingreso3 = 0; ingreso4 = 0;
            }
        }
        public void ValidarSemana(int mes, int posicion, ref double ingreso1, ref double ingreso2, ref double ingreso3, ref double ingreso4)
        {

            if (veterinarias[posicion].Cita.Day <= 7 && veterinarias[posicion].Cita.Month == mes &&
                veterinarias[posicion].Servicio.ToUpper() == txtFiltroServicio.Text.ToUpper())
            {
                ingreso1++;
            }
            if (veterinarias[posicion].Cita.Day > 7 && veterinarias[posicion].Cita.Day <= 15 && 
                veterinarias[posicion].Cita.Month == mes && veterinarias[posicion].Servicio.ToUpper() == txtFiltroServicio.Text.ToUpper())
            {
                ingreso2++;
            }
            if (veterinarias[posicion].Cita.Day > 13 && veterinarias[posicion].Cita.Day <= 23 && 
                veterinarias[posicion].Cita.Month == mes && veterinarias[posicion].Servicio.ToUpper() == txtFiltroServicio.Text.ToUpper())
            {
                ingreso3++;
            }
            if (veterinarias[posicion].Cita.Day > 23 && veterinarias[posicion].Cita.Day <= 30 && 
                veterinarias[posicion].Cita.Month == mes && veterinarias[posicion].Servicio.ToUpper() == txtFiltroServicio.Text.ToUpper())
            {
                ingreso4++;
            }
        }
    }
}
