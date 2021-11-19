using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace PUNTO_DE_VENTA_CODIGO369_CSHARP.MODULOS
{
    public partial class GymFabian : Form
    {
        public GymFabian()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {

            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpasword_Enter(object sender, EventArgs e)
        {
            if (txtpasword.Text == "CONTRASEÑA")
            {
                txtpasword.Text = "";
                txtpasword.ForeColor = Color.LightGray;
                txtpasword.UseSystemPasswordChar = true;
            }
        }

        private void txtpasword_Leave(object sender, EventArgs e)
        {
            if (txtpasword.Text == "")
            {
                txtpasword.Text = "CONTRASEÑA";
                txtpasword.ForeColor = Color.DimGray;
                txtpasword.UseSystemPasswordChar = false;
            }
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            usuariosok formusuarios = new usuariosok();

            if (txtpasword.Text == "123" && txtuser.Text == "USUARIO")
            {
                formusuarios.Visible = true;
                Visible = false;
            }
            else
            {
                MessageBox.Show("CONTRASEÑA O USUARIO INCORRECTO!!");

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
