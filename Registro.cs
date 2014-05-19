using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Data.SqlClient;

namespace Registro
{
    public partial class Registro : Form
    {
        //private int childFormNumber = 0;
        
        public Registro()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            //Form childForm = new Form();
            //childForm.MdiParent = this;
            //childForm.Text = "Ventana " + childFormNumber++;
            //childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void maestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Maestros forma1 = new Maestros();
            forma1.MdiParent = this;
            forma1.Show();
            
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if(!Estudiantes.Estainstancia)
            //{
            //    Estudiantes forma2 = new Estudiantes();
            //    forma2.MdiParent = this;
            //    forma2.Show();
            //}

            //else
            //{
            //    Estudiantes.InstanciaActiva.Activate();
            //}



            Estudiantes forma2 = new Estudiantes();
            forma2.MdiParent = this;
            forma2.Show();
            
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            //Estudiantes.Estainstancia = false;
            //Maestros.EstaInstancia1 = false;
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscador forma3 = new Buscador();
            forma3.MdiParent = this;
            forma3.Show();
            
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nuevo_usuario forma4 = new Nuevo_usuario();
            forma4.MdiParent = this;
            forma4.Show();

        }

        private void Registro_Shown(object sender, EventArgs e)
        {
            Logon forma5 = new Logon();
            this.Show();
            forma5.ShowDialog();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logon forma5 = new Logon();
            this.Show();
            forma5.ShowDialog();
        }
    }
}

//Esta instruccion sirve para abrir una ventaba maximizada
//this.WindowState = FormWindowState.Maximized;