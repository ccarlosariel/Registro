using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Registro
{
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        string hora;

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            //Estainstancia = true;
            //InstanciaActiva = this;
            
        }   
        private void Estudiantes_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Estudiantes.Estainstancia = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = nacimientotxt.Value;

                if (radioButton1.Checked)
                {
                    hora = "A.M.";
                }
                else if (radioButton2.Checked)
                {
                    hora = "P.M.";
                }

            SqlCommand Comando = new SqlCommand();
Comando.CommandText = "Insert into [Cuentas].[dbo].[Estudiantes] ([Cedula],[Nombre],[Apellido],[Telefono],[Correo],[FecNaci],[Ciudad],[Direccion],[Carrera],[Lugar],[Horario]) values ('" + identxt.Text + "','" + nombretxt.Text + "','" + apellidotxt.Text + "','" + teltxt.Text + "','" + correotxt.Text + "','" + fecha + "','" + ciudadtxt.Text + "','" + direcciontxt.Text + "','" + carreratxt.Text + "','" + sitiotxt.Text + "','" + hora + "')";
            Comando.Connection = MiBD.Conexion();

            Comando.Parameters.Clear();

            int Nfilas = Comando.ExecuteNonQuery();

            if(Nfilas > 0)
            {
                MessageBox.Show("Creado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Comando.Connection.Close();
            
            }    

            catch (SqlException ex)
            {
                MessageBox.Show("Metio la pata" + ex.Message,"Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                    //Enfoque en el 1er texbox
                    this.identxt.Focus();
                }
            }
            mattxt.Clear();
        }

        private void Busqueda2_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mattxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}





//public static bool Estainstancia = false;
//public static Estudiantes InstanciaActiva = null;

//Este codigo sirve para almacenar datos en un txt usando StreamReader
//struct Estudiante
//{
//    public int Identificacion;
//    public string Nombre, Apellido, Telefono, Direccion, Correo, Carrera, Nacimiento, Lugar, Matricula, Ciudad, Horario;
//}

//Estudiante E = new Estudiante();
//StreamWriter sw = new StreamWriter("C:\\TareaC\\Estudiantes.txt", true);
//List<Estudiante> listado = new List<Estudiante>();

//E.Identificacion = int.Parse(identxt.Text);
//E.Nombre = nombretxt.Text;
//E.Apellido = apellidotxt.Text;
//E.Nacimiento = nacimientotxt.Text;
//E.Ciudad = ciudadtxt.Text;
//E.Direccion = direcciontxt.Text;
//E.Correo = correotxt.Text;
//E.Telefono = teltxt.Text;
//E.Carrera = carreratxt.Text;
//E.Lugar = sitiotxt.Text;
//E.Matricula = mattxt.Text;
//E.Horario = chec1txt.Text;
//E.Horario = chec2txt.Text;
//listado.Add(E);

//foreach (var item in listado)
//{
//    sw.WriteLine(item.Identificacion + "," + item.Nombre + "," + item.Apellido + "," + item.Nacimiento + "," + item.Ciudad + "," 
//        + item.Direccion + "," + item.Correo + "," + item.Telefono + "," + item.Carrera + "," + item.Lugar + ","
//         + item.Matricula + "," + item.Horario);
//}

//sw.Flush();
//sw.Close();

//MessageBox.Show("Guardado correctamente" + " " + MessageBoxButtons.OK);