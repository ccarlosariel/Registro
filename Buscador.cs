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

namespace Registro
{
    public partial class Buscador : Form
    {
        public Buscador()
        {
            InitializeComponent();
        }

        public struct Estudiante
        {
            public int Identificacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ListaEstudiantes.Items.Clear();

            SqlCommand Mlista = new SqlCommand();
            Mlista.Connection = MiBD.Conexion();
            //(Cedula,Nombre,Apellido,Telefono,Correo,FecNaci,Ciudad,Direccion,Carrera,Lugar,Horario) values
            Mlista.CommandText = "Select * from dbo.Estudiantes where Cedula ='" +textBox1.Text+ "'";
            SqlDataReader lectorm = Mlista.ExecuteReader();

            if (lectorm.Read())
            {
                ListViewItem items = new ListViewItem(lectorm["Cedula"].ToString());
                items.SubItems.Add(lectorm["Nombre"].ToString());
                items.SubItems.Add(lectorm["Apellido"].ToString());
                items.SubItems.Add(lectorm["Telefono"].ToString());
                items.SubItems.Add(lectorm["Correo"].ToString());
                items.SubItems.Add(lectorm["FecNaci"].ToString());
                items.SubItems.Add(lectorm["Ciudad"].ToString());
                items.SubItems.Add(lectorm["Direccion"].ToString());
                items.SubItems.Add(lectorm["Carrera"].ToString());
                items.SubItems.Add(lectorm["Lugar"].ToString());
                items.SubItems.Add(lectorm["Horario"].ToString());
                items.SubItems.Add(lectorm["Matricula"].ToString());
                ListaEstudiantes.Items.Add(items);
            } 
            
            
            //Lista1.Items.Clear(); 
            
            ////string busqueda = textBox1.Text;

            //Estudiante[] Estudiantes = new Estudiante[11];
           
            //StreamReader sr = new StreamReader("C:\\TareaC\\Estudiantes1.txt");
            
            //while (!sr.EndOfStream )
            //{
            //    string Estudiante = sr.ReadLine();

            //    string[] datos = Estudiante.Split(',');
                
            //    if(datos[0] == textBox1.Text)
            //    { 
            //    Lista1.Items.Add(Estudiante);
            //    }

            //}

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaMaestros.Items.Clear();
            
            SqlCommand Mlista = new SqlCommand();
            Mlista.Connection = MiBD.Conexion();

            Mlista.CommandText = "Select Cedula, Nombre, Apellido, Telefono, Direccion, Correo, Profesion, FecNaci from dbo.Maestros where Cedula = '"+ textBox2.Text+ "'";

            SqlDataReader lectorm = Mlista.ExecuteReader();

            if (lectorm.Read())
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
    }
}


//Lista1.Items.Clear();

////string busqueda = textBox1.Text;

//Estudiante[] Estudiantes = new Estudiante[8];

//StreamReader sr = new StreamReader("C:\\TareaC\\Maestros.txt");

//while (!sr.EndOfStream)
//{
//    string Maestro = sr.ReadLine();

//    string[] datos = Maestro.Split(',');

//    if (datos[0] == textBox2.Text)
//    {
//        Lista2.Items.Add(Maestro);
//    }

//}