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

namespace Registro
{
    public partial class Logon : Form
    {
        public Logon()
        {
            InitializeComponent();
        }

        //private bool CompareStrings(string Cadena1, string Cadena2)
        //{
        //    return String.Compare(Cadena1, Cadena2, true, System.Globalization.CultureInfo.InvariantCulture) == 0 ? true : false;
        //}

        private void Logon_Load(object sender, EventArgs e)
        {
            //label3.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand Comando1 = new SqlCommand("select [Usuario],[Contraseña] from [Cuentas].[dbo].[Usuarios] where Usuario = '" + idbox.Text + "' and Contraseña ='" + contrabox.Text + "'");
                Comando1.Connection = MiBD.Conexion();

                SqlDataReader dr = Comando1.ExecuteReader();

                if (idbox.Text == "" || contrabox.Text == "")
                {
                    MessageBox.Show("No puede haber campos vacios", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (!(dr.Read()))
                {         
                    MessageBox.Show("Cuenta invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }

            }
            catch (EvaluateException ex)
            {
                MessageBox.Show("Valores invalidos" + ex.Message);
            }
            
        }

        private void contrabox_TextChanged(object sender, EventArgs e)
        {
            contrabox.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                if (contrabox.Text == "" || idbox.Text == "")
                {
                    MessageBox.Show("Usuario invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
            try
            {

                SqlCommand Cambio = new SqlCommand();
                Cambio.Connection = MiBD.Conexion();
                Cambio.CommandText = "Update Usuarios set Contraseña = '" + contrabox.Text + "' where Usuario = '" + idbox.Text + "'";
                SqlDataReader dr = Cambio.ExecuteReader();

                MessageBox.Show("Contraseña cambiada", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (DataException ex)
            {

                MessageBox.Show("Valor invalido" + ex.Message);
            }
                
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}



//private bool CompareStrings(string Cadena1, string Cadena2)
//{
//    return String.Compare(Cadena1, Cadena2, true, System.Globalization.CultureInfo.InvariantCulture) == 0 ? true : false;
//}

// if (this.CompareStrings(dr["Usuario"].ToString(), usuariotext) && this.CompareStrings(dr["Contraseña"].ToString(), contratext))
//{

//Registro forma1 = new Registro();
//forma1.Show();

//}
//else if (!this.CompareStrings(dr["Usuario"].ToString(), usuariotext) || this.CompareStrings(dr["Contraseña"].ToString(), contratext))
//{
//    Comando1.Connection.Close();
//    MessageBox.Show("Usuario invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    return;
//}


//Esto es una validacion primitiva para un login
//    if (idbox.Text == "" || contrabox.Text == "")
//    { 
//        MessageBox.Show("No puede haber ningun campo vacio");
//    }
//    if(idbox.Text == Comando1.CommandText && contrabox.Text == Comando1.CommandText)
//    {
//        Comando1.CommandText = ;
//    }
//}
//catch (Exception)
//    {

//        throw;
//    }
//if (idbox.Text == "Carlos" && contrabox.Text == "entrada")
//{
//    //MessageBox.Show("Bienvenio hermanoo!");

//    Registro forma1 = new Registro();
//    forma1.Show();
//    this.Hide();
//}
//else
//{
//    MessageBox.Show("Te equivocaste hermano, intentalo de nuevo.");
//}