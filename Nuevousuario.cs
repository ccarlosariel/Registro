using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.Common;

namespace Registro
{
    public partial class Nuevo_usuario : Form
    {
        public Nuevo_usuario()
        {
            InitializeComponent();
        }

        
        private void Nuevo_usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cuentasDataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            
            //Este codigo es util para mostrar los datos de una tabla en un datagrid de forma simple
            //dataGridView1.ClearSelection();
            //DataTable dt = new DataTable();
            //SqlDataAdapter sda = new SqlDataAdapter("select Nombre, Usuario from dbo.Usuarios", Enchufe);
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;

            //--------------------------------------------------------------------

            //SqlConnection Enchufe = MiBD.Conexion();
            SqlCommand Lector = new SqlCommand("Select Nombre, Usuario, ID from dbo.Usuarios");
            Lector.Connection = MiBD.Conexion();

            SqlDataReader data = Lector.ExecuteReader();

            while (data.Read())
            {
                ListViewItem items = new ListViewItem(data["Nombre"].ToString());
                items.SubItems.Add(data["Usuario"].ToString());
                items.SubItems.Add(data["ID"].ToString());

                ListaUsuarios.Items.Add(items);
            } 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            upasstxt.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (nusuartxt.Text == "" || idusuariotxt.Text == "" || upasstxt.Text == "")
            {
                MessageBox.Show("No puede haber ningun campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                return;
            }

            try
            {
                SqlCommand Comando1 = new SqlCommand();

                Comando1.Connection = MiBD.Conexion();
                Comando1.CommandText = "INSERT INTO [Cuentas].[dbo].[Usuarios]([Usuario],[Contraseña],[Nombre])VALUES('" + idusuariotxt.Text + "','" + upasstxt.Text + "','" + nusuartxt.Text + "')";
                Comando1.Parameters.Clear();

                int NFilas = Comando1.ExecuteNonQuery();

                if (NFilas > 0)
                {
                    MessageBox.Show("Usuario creado!", "Nuevo usuario", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
    
            }
            catch (InvalidOperationException ex)
            {

                    MessageBox.Show("Valor invalido" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nuevo_usuario_Shown(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ListaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if(idusuariotxt.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un usuario para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DialogResult Respuesta = MessageBox.Show("Se eliminara el usuario, esta seguro?", "Alerta!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
                if(Respuesta == DialogResult.OK)
                {
                SqlCommand eliminar = new SqlCommand();
                eliminar.CommandText = "delete from dbo.Usuarios where Usuario = '" + idusuariotxt.Text + "'";
                eliminar.Connection = MiBD.Conexion();
                eliminar.ExecuteNonQuery();
                
                eliminar.Parameters.Clear();

                MessageBox.Show("Usuario eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                eliminar.Connection.Close();
                }
                else
                {
                    return;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Ya no existe el usuario");
            }
        }

    }
}




//private void listView1_SelectedIndexChanged(object sender, EventArgs e)
//{


//    listView1.View = View.Details;


//    SqlCommand Comando3 = new SqlCommand();
//    Comando3.Connection = MiBD.Conexion();

//    Comando3.CommandText = "Select * from [Cuentas].[dbo].[Usuarios]"; 
//        //"select [Nombre],[Usuario] from [Cuentas].[dbo].[Usuarios]"; 
//        //where [Nombre] ='" + Columna1 + "','" + Columna2 + "'";

//    SqlDataReader dr1 = Comando3.ExecuteReader();

//    while (dr1.Read())
//    {

//    ListViewItem item = new ListViewItem(dr1["Usuarios"].ToString());
//    item.SubItems.Add(dr1["Nombre"].ToString());
//    item.SubItems.Add(dr1["Usuario"].ToString());

//    listView1.Items.Add(item);
//    }


//}

//private void button3_Click(object sender, EventArgs e)
//{

//   SqlConnection Enchufe = MiBD.Conexion();

//   DataTable dt = new DataTable();
//   SqlDataAdapter sda = new SqlDataAdapter("select Nombre, Usuario from dbo.Usuarios", Enchufe);
//   sda.Fill(dt);
//   dataGridView1.DataSource = dt;
//}