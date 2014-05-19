using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;

namespace Registro
{
    public partial class Maestros : Form
    {
        public Maestros()
        {
            InitializeComponent();
        }

        SqlCommand Comando = new SqlCommand();

        private void Maestros_Load(object sender, EventArgs e)
        {    
            SqlCommand Mlista = new SqlCommand();
            Mlista.Connection = MiBD.Conexion();

            Mlista.CommandText = "Select Cedula, Nombre, Apellido, Telefono, Direccion, Correo, Profesion, FecNaci from dbo.Maestros";

            SqlDataReader lectorm = Mlista.ExecuteReader();

            while(lectorm.Read())
            {

            ListViewItem items = new ListViewItem(lectorm["Cedula"].ToString());
            items.SubItems.Add(lectorm["Nombre"].ToString());
            items.SubItems.Add(lectorm["Apellido"].ToString());
            items.SubItems.Add(lectorm["Telefono"].ToString());
            items.SubItems.Add(lectorm["Direccion"].ToString());
            items.SubItems.Add(lectorm["Correo"].ToString());
            items.SubItems.Add(lectorm["Profesion"].ToString());
            items.SubItems.Add(lectorm["FecNaci"].ToString());
            
            ListaMaestros.Items.Add(items);

            }
        }

        //private object PadLeft(string p)
        //{
        //    throw new NotImplementedException();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = dateTimePicker1.Value;
                Comando.Connection = MiBD.Conexion();
                
                Comando.CommandText = "INSERT INTO [Cuentas].[dbo].[Maestros]([Cedula],[Nombre],[Apellido],[Telefono],[Direccion],[Correo],[Profesion],[FecNaci])VALUES('" + Convert.ToString(identificacionlbl.Text) + "','" + nombrelbl.Text + "', '" + apellidolbl.Text + "','" + telefonolbl.Text + "','" + direccionlbl.Text + "','" + correolbl.Text + "','" + profesionlbl.Text + "','" + fecha + "')";
    
                Comando.Parameters.Clear();
 
                int Nfilas = Comando.ExecuteNonQuery();

                if (Nfilas > 0)
                {
                    MessageBox.Show("Nuevo maestro registrado","Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                Comando.Connection.Close();
            }
            catch (SqlException)
            {

                MessageBox.Show("Valor invalido, demasadiados caracteres en alguna linea");
            }
        }

        private void Maestros_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Maestros.EstaInstancia1 = false;
        }

        private void limpiarcmd_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";

                    //Enfoque en el 1er texbox
                    this.identificacionlbl.Focus();
                }
            }
        }

        private void cerrarcmd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarcmd_Click(object sender, EventArgs e)
        {
            try
            {

                Comando.Connection = MiBD.Conexion();

                Comando.CommandText = "INSERT INTO [Cuentas].[dbo].[Maestros]([Nombre])VALUES('" + nombrelbl.Text +"')";

                Comando.Parameters.Clear();

                //Comando.Parameters.AddWithValue("@nombre", nombrelbl.Text);

                    int Nfilas = Comando.ExecuteNonQuery();

                    if (Nfilas >0)
                    {
                        MessageBox.Show("Registro creado carajo!");
                    }
                }
                catch (SqlException No)
                {

                    MessageBox.Show("Se jodio la esta cuestion" + No);
                }
        }

        private void nombrelbl_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(identificacionlbl.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un Maestro para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                DialogResult Respuesta = MessageBox.Show("Se eliminara el Maestro", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (Respuesta == DialogResult.OK)
                {
                    SqlCommand Eliminar = new SqlCommand();
                    Eliminar.CommandText = "delete from dbo.Maestros where Cedula = '" + Convert.ToInt32(identificacionlbl.Text) + "'";
                    Eliminar.Connection = MiBD.Conexion();
                    Eliminar.ExecuteNonQuery();

                    Eliminar.Parameters.Clear();

                    MessageBox.Show("Maestro eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Eliminar.Connection.Close();
                }
                else
                {
                    return;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ya no existe el maestro" + ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlCommand Mlista = new SqlCommand();
            Mlista.Connection = MiBD.Conexion();
            //(Cedula,Nombre,Apellido,Telefono,Correo,FecNaci,Ciudad,Direccion,Carrera,Lugar,Horario) values
            Mlista.CommandText = "Select * from dbo.Estudiantes where Cedula ='" + identificacionlbl.Text + "'";
            //SqlDataReader lectorm = Mlista.ExecuteReader();
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(Mlista);

            adaptador.Fill(tabla);

            
            string Nombre = tabla.Rows[0]["Nombre"].ToString();
            string Apellido = tabla.Rows[0]["Apellido"].ToString();
            string Telefono = tabla.Rows[0]["Telefono"].ToString();
            string Direccion = tabla.Rows[0]["Direccion"].ToString();
            string Correo = tabla.Rows[0]["Correon"].ToString();
            string Profesion = tabla.Rows[0]["Profesion"].ToString();
            //string FecNaci = tabla.Rows[0]["FecNaci"].ToString();

            nombrelbl.Text = Nombre;
            apellidolbl.Text = Apellido;
            telefonolbl.Text = Telefono;
            direccionlbl.Text = Direccion;
            correolbl.Text = Correo;
            profesionlbl.Text = Profesion;
            //dateTimePicker1 = DateTime.Compare(FecNaci);
            
            //string Fecha = tabla.Rows[0]["Nombre"].ToString();
            
            //istViewItem items = new ListViewItem(lectorm["Cedula"].ToString());
            //    items.SubItems.Add(lectorm["Nombre"].ToString());
            //    items.SubItems.Add(lectorm["Apellido"].ToString());
            //    items.SubItems.Add(lectorm["Telefono"].ToString());
            //    items.SubItems.Add(lectorm["Direccion"].ToString());
            //    items.SubItems.Add(lectorm["Correo"].ToString());
            //    items.SubItems.Add(lectorm["Profesion"].ToString());
            //    items.SubItems.Add(lectorm["FecNaci"].ToString());
            //    ListaMaestros.Items.Add(items




            
            
            //if(lectorm.Read())
            //{
            //    nombrelbl.Text = Convert.ToString(lectorm["Nombre"]);
            //}



            //stViewItem items = new ListViewItem(lectorm["Cedula"].ToString());
            //items.SubItems.Add(lectorm["Nombre"].ToString());
            //items.SubItems.Add(lectorm["Apellido"].ToString());
            //items.SubItems.Add(lectorm["Telefono"].ToString());
            //items.SubItems.Add(lectorm["Correo"].ToString());
            //items.SubItems.Add(lectorm["FecNaci"].ToString());
            //items.SubItems.Add(lectorm["Ciudad"].ToString());
            //items.SubItems.Add(lectorm["Direccion"].ToString());
            //items.SubItems.Add(lectorm["Carrera"].ToString());
            //items.SubItems.Add(lectorm["Lugar"].ToString());
            //items.SubItems.Add(lectorm["Horario"].ToString());
            //items.SubItems.Add(lectorm["Matricula"].ToString());
            //ListaEstudiantes.Items.Add(items);


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}



//public static bool EstaInstancia1 = false;
//public static Maestros InstanciaActiva = null;

//Este codigo permite guardar datos en un tx usando StreamReader
//struct Maestro
//{
//public int Identificacion;
//public string Nombre, Apellido, Telefono, Direccion, Correo, Profesion, Nacimiento;
//}

//Maestro M = new Maestro();
//StreamWriter sw = new StreamWriter("C:\\TareaC\\Maestros.txt", true);
//List<Maestro> listado = new List<Maestro>();

//    M.Identificacion = int.Parse(identificacionlbl.Text);
//    M.Nombre = nombrelbl.Text;
//    M.Apellido = apellidolbl.Text;
//    M.Telefono = telefonolbl.Text;
//    M.Direccion = direccionlbl.Text;
//    M.Correo = correolbl.Text;
//    M.Profesion = profesionlbl.Text;
//    M.Nacimiento = dateTimePicker1.Text;
//    listado.Add(M);

//    foreach (var item in listado)
//    {
//        sw.WriteLine(item.Identificacion + ", " + item.Nombre + ", " + item.Apellido + ", " + item.Telefono + ", " + 
//                     item.Direccion + ", " + item.Correo + ", " + item.Profesion + "," + item.Nacimiento);
//    }
//    sw.Flush();
//    sw.Close();

//MessageBox.Show("Guardado correctamente" + " " + MessageBoxButtons.OK);