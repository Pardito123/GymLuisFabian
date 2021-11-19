using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;

namespace PUNTO_DE_VENTA_CODIGO369_CSHARP
{
    public partial class usuariosok : Form
    {
        public usuariosok()
        {
            InitializeComponent();
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {





        }
        private void mostrar()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_usuario", con);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();

                datalistado.Columns[1].Visible = false;
                datalistado.Columns[13].Visible = false;
                //datalistado.Columns[5].Visible = false;
                //datalistado.Columns[6].Visible = false;
                //datalistado.Columns[7].Visible = false;
                //datalistado.Columns[13].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref datalistado);
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

            //ICONO.Image = pictureBox3.Image;
            //lblnumeroicono.Text = "1";
            //LblAnuncioIcono.Visible = false;
            //panelICONO.Visible = false;

        }

        private void LblAnuncioIcono_Click(object sender, EventArgs e)
        {

            // panelICONO.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //ICONO.Image = pictureBox4.Image;
            //lblnumeroicono.Text = "2";
            //LblAnuncioIcono.Visible = false;
            //panelICONO.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //ICONO.Image = pictureBox5.Image;
            //lblnumeroicono.Text = "3";
            //LblAnuncioIcono.Visible = false;
            //panelICONO.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //ICONO.Image = pictureBox6.Image;
            //lblnumeroicono.Text = "4";
            //LblAnuncioIcono.Visible = false;
            //panelICONO.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //ICONO.Image = pictureBox7.Image;
            //lblnumeroicono.Text = "5";
            //LblAnuncioIcono.Visible = false;
            //panelICONO.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //ICONO.Image = pictureBox8.Image;
            //lblnumeroicono.Text = "6";
            //LblAnuncioIcono.Visible = false;
            //panelICONO.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //ICONO.Image = pictureBox9.Image;
            //lblnumeroicono.Text = "7";
            //LblAnuncioIcono.Visible = false;
            //panelICONO.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //ICONO.Image = pictureBox10.Image;
            //lblnumeroicono.Text = "8";
            //LblAnuncioIcono.Visible = false;
            //panelICONO.Visible = false;
        }

        private void usuariosok_Load(object sender, EventArgs e)
        {
            //  panel4.Visible = false;
            //  panelICONO.Visible = false;
            mostrar();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //dtpinicio.Visible = false;
            //dtpdeprueba.Visible = true;
            btnagregar.Visible = true;
            btnEditar.Visible = false;
            panel5.Visible = true;
            txtnombre.Text = "";
            txtplazo.Text = "";
            txtcodigo.Text = "";
            txtpaquete.Text = "";
            txtplan.Text = "0";
            txtclases.Text = "";
            txtpago.Text = "";
            txtobservacion.Text = "";
            txthorario.Text = "";
            dtpinicio.Value = DateTime.Today;
            lbldiasrestantes.Text = "";
            //LblAnuncioIcono.Visible = true;
            //txtnombre.Text = "";
            //txtlogin.Text = "";
            //txtPassword.Text = "";
            //txtcorreo.Text = "";

        }

        private void datalistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datalistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //lblid_usuario.Text = datalistado.SelectedCells[1].Value.ToString();
            //txtnombre.Text = datalistado.SelectedCells[2].Value.ToString();
            //txtlogin.Text = datalistado.SelectedCells[3].Value.ToString();

            //txtPassword.Text = datalistado.SelectedCells[4].Value.ToString();

            //ICONO.BackgroundImage = null;
            //byte[] b = (Byte[])datalistado.SelectedCells[5].Value;
            //MemoryStream ms = new MemoryStream(b);
            //ICONO.Image = Image.FromStream(ms);
            //LblAnuncioIcono.Visible = false;

            //lblnumeroicono.Text = datalistado.SelectedCells[6].Value.ToString();
            //txtcorreo.Text = datalistado.SelectedCells[7].Value.ToString();
            //txtrol.Text = datalistado.SelectedCells[8].Value.ToString();
            //panel4.Visible = true;
            //btnGuardar.Visible = false;
            //btnGuardarCambios.Visible = true;     
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //panel4.Visible = false;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            //if (txtnombre.Text != "")
            //{
            //    try
            //    {
            //        SqlConnection con = new SqlConnection();
            //        con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
            //        con.Open();
            //        SqlCommand cmd = new SqlCommand();
            //        cmd = new SqlCommand("editar_usuario", con);
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@idUsuario", lblid_usuario.Text);
            //        cmd.Parameters.AddWithValue("@nombres", txtnombre.Text);
            //        cmd.Parameters.AddWithValue("@Login", txtlogin.Text);
            //        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            //        cmd.Parameters.AddWithValue("@Correo", txtcorreo.Text);
            //        cmd.Parameters.AddWithValue("@Rol", txtrol.Text);
            //      //  cmd.Parameters.AddWithValue("@fecha", dtpfecha.Text);

            //        System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //        ICONO.Image.Save(ms, ICONO.Image.RawFormat);

            //        cmd.Parameters.AddWithValue("@Icono", ms.GetBuffer());
            //        cmd.Parameters.AddWithValue("@Nombre_de_icono", lblnumeroicono.Text);
            //        cmd.ExecuteNonQuery();
            //        con.Close();
            //        mostrar();
            //        panel4.Visible = false;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}


        }

        private void ICONO_Click(object sender, EventArgs e)
        {
            // panelICONO.Visible = true;
        }

        private void datalistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.datalistado.Columns["Eli"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("Realmente desea eliminr este usuario?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    SqlCommand cmd;
                    try
                    {
                        foreach (DataGridViewRow row in datalistado.SelectedRows)
                        {
                            int onekey = Convert.ToInt32(row.Cells["idUsuario"].Value);
                            string usuario = Convert.ToString(row.Cells["Login"].Value);

                            try
                            {
                                try
                                {
                                    SqlConnection con = new SqlConnection();
                                    con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                                    con.Open();
                                    cmd = new SqlCommand("eliminar_usuario", con);
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@idusuario", onekey);
                                    cmd.Parameters.AddWithValue("@login", usuario);
                                    cmd.ExecuteNonQuery();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.Message);
                                }
                            }

                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }
                        }
                        mostrar();

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de Imagenes ADA 369";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //ICONO.BackgroundImage = null;
                //ICONO.Image = new Bitmap(dlg.FileName);
                //ICONO.SizeMode = PictureBoxSizeMode.Zoom;
                //lblnumeroicono.Text = Path.GetFileName(dlg.FileName);
                //LblAnuncioIcono.Visible = false;
                //panelICONO.Visible = false;
            }
        }


        private void buscar_usuario()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_usuario", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", txtbuscar.Text);
                da.Fill(dt);
                datalistado.DataSource = dt;
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref datalistado);

        }



        public void Numeros(System.Windows.Forms.TextBox CajaTexto, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;

            }


        }


        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar_usuario();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Numeros(txtbuscar, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click_1(object sender, EventArgs e)
        {

        }

      
        private void btnMostrar_Click(object sender, EventArgs e)
        {
           
        }

     

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datalistado_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void datalistado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datalistado_CellDoubleClick_2(object sender, DataGridViewCellEventArgs e)
        {
            //dtpinicio.Visible = true;
            //dtpdeprueba.Visible = false;
            CaluculardiasRestantes();
            txtnombre.Text = datalistado.SelectedCells[0].Value.ToString();
            txtplazo.Text = datalistado.SelectedCells[1].Value.ToString();
            txtcodigo.Text = datalistado.SelectedCells[2].Value.ToString();
            txtplan.Text = datalistado.SelectedCells[5].Value.ToString();
            txtpaquete.Text = datalistado.SelectedCells[3].Value.ToString();
            txtclases.Text = datalistado.SelectedCells[7].Value.ToString();
            txtobservacion.Text = datalistado.SelectedCells[9].Value.ToString();
            txtpago.Text = datalistado.SelectedCells[8].Value.ToString();
            txthorario.Text = datalistado.SelectedCells[10].Value.ToString();
            txttelefono.Text = datalistado.SelectedCells[11].Value.ToString();

            dtpinicio.Text = datalistado.SelectedCells[4].Value.ToString();
            dtpfin.Text = datalistado.SelectedCells[6].Value.ToString();

            dtphoraderegistro.Text = datalistado.SelectedCells[13].Value.ToString();
            txtdni.Text = datalistado.SelectedCells[12].Value.ToString();
            panel5.Visible = true;

            btnagregar.Visible = false;
            btnEditar.Visible = true;
            dtpinicio.Enabled = false;
            label18.Visible = false;
            label19.Visible = true;
            panel8.Visible = false;
            txtpago.Enabled = false;
        }

 

        private void label1_Click_1(object sender, EventArgs e)
        {


        }

        private void CaluculardiasRestantes()
        {
            DateTime FechaActual1 = dtpfechaactual.Value.Date;
            DateTime FechaFinal1 = dtpfin.Value.Date;


            TimeSpan tSpan = FechaFinal1 - FechaActual1;
            int Dias = tSpan.Days;
            lbldiasrestantes.Text = Dias.ToString();


            DateTime FechaInicio1 = dtpinicio.Value.Date;
            TimeSpan tSpan1 = FechaInicio1 - FechaActual1;
            int diaz = tSpan1.Days;
           // int j = Dias - diaz;
            lblrestantes.Text = diaz.ToString();
            double num = Convert.ToDouble(lblrestantes.Text);
            if (num < 0)
            {
                lblrestantes.Visible = false;
                label2.Visible = false;
                label16.Visible = false;
            }
            else
            {
                lblrestantes.Visible = true;
                label2.Visible = true;
                label16.Visible = true;
            }

        }
        private void RestriccionDeFecha()
        {
            
        }

        private void dtpfechaactual_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            CaluculardiasRestantes();
        }

        private void dtpprueba_ValueChanged(object sender, EventArgs e)
        {
            //DateTime fechactual = dtpfechaactual.Value.Date;
            //DateTime fechainicio = dtpinicio.Value.Date;
            ////DateTime fechainicio1 = dtpinicio.Value.Date;
            ////dtpprueba.Value = fechainicio1;
            ////dtpprueba.Enabled = false;
            //if (fechainicio < fechactual)
            //{


            //    MessageBox.Show("NO PUEDES REGISTRAR EN UNA FECHA PASADA, SE CERRARÁ ESTA VENTANA", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    //dtpinicio.Value = dtpprueba.Value;
            //    // dtpinicio.Enabled = false;

            //    //dtpfin.Value = dtpinicio.Value.AddDays(dias);

            //}


        }

      


        private void dtpdeprueba_ValueChanged(object sender, EventArgs e)
        {

        }



        private void dtppruebaa1_ValueChanged(object sender, EventArgs e)
        {

            

        }

        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {
        
        }

        private void buscar_x_fecha()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("buscar_usuario_fecha", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", afsdfsdfsd.Value.Date);
                da.Fill(dt);
                dtrgmostrarcuotas.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // CONEXION.letras.Multilinea(ref dtrgmostrarcuotas);

            dtrgmostrarcuotas.Columns[13].Visible = false;
            dtrgmostrarcuotas.Columns[12].Visible = false;
            dtrgmostrarcuotas.Columns[11].Visible = false;

            dtrgmostrarcuotas.Columns[1].Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
           
        }
        public void exportar(DataGridView datalistaddo)
        {

            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();
            exportarexcel.Application.Workbooks.Add(true);
            int indicecolumna = 0;
            foreach (DataGridViewColumn columna in datalistaddo.Columns)
            {
                indicecolumna++;

                exportarexcel.Cells[1, indicecolumna] = columna.Name;
            }
            int indicefilas = 0;
            foreach (DataGridViewRow fila in datalistaddo.Rows)
            {
                indicefilas++;
                indicecolumna = 0;
                foreach (DataGridViewColumn columna in datalistaddo.Columns)
                {
                    indicecolumna++;
                    exportarexcel.Cells[indicefilas + 1, indicecolumna] = fila.Cells[columna.Name].Value;

                }
            }
            exportarexcel.Visible = true;
        }

            private void button2_Click(object sender, EventArgs e)
             {
          
              }

        private void btncerrar2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel8.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnagregar_Click_1(object sender, EventArgs e)
        {

            if (txtnombre.Text != "")
            {


            }

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
       
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel21.Visible = false;
            btnEditar.Visible = false;
            panel5.Visible = true;
            txtnombre.Text = "";
            txtplazo.Text = "";
            txtcodigo.Text = "";
            txtpaquete.Text = "";
            txtplan.Text = "0";
            txtclases.Text = "";
            txtpago.Text = "";
            txtobservacion.Text = "";
            txthorario.Text = "";
            dtpinicio.Value = DateTime.Today;
            lbldiasrestantes.Text = "";
            btnagregar.Visible = true;
            panel8.Visible = false;
            label18.Visible = true;
            label19.Visible = false;
            dtpinicio.Enabled = true;
            panel2.Visible = false;
            txtpago.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            panel21.Visible = false;
            panel8.Visible = true;
            panel5.Visible = false;
            panel2.Visible = false;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label17.Text = DateTime.Now.ToLongTimeString();
            label15.Text = DateTime.Now.ToShortDateString();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtpasword.Text = "";
            panel21.Visible = true;
          // panel2.Visible = true;
            panel8.Visible = false;
            panel5.Visible = false;
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_usuario", con);
                da.Fill(dt);
                dtrgmostrarcuotas.DataSource = dt;
                con.Close();

                dtrgmostrarcuotas.Columns[1].Visible = false;
                dtrgmostrarcuotas.Columns[13].Visible = false;
                //datalistado.Columns[5].Visible = false;
                //datalistado.Columns[6].Visible = false;
                //datalistado.Columns[7].Visible = false;
                //datalistado.Columns[13].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref dtrgmostrarcuotas);

        }

        private void btnVolver_Click_2(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel8.Visible = true;
        }

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {

            dtpinicio.Enabled = true;
            MessageBox.Show("RECUERDA QUE SI PONES UNA FECHA MENOR A LA DE HOY, LA VENTANA SE CERRARÁ");
        }

        private void txtplan_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = dtpinicio.Value.Date;
                double dias = Convert.ToDouble(txtplan.Text);
                dtpfin.Value = dtpinicio.Value.AddDays(dias);
                CaluculardiasRestantes();

            }
            catch (Exception ex)
            {
            }


          
        }

        private void dtpinicio_CloseUp_1(object sender, EventArgs e)
        {
            DateTime fechactual = dtpfechaactual.Value.Date;
            DateTime fechainicio = dtpinicio.Value.Date;
            // DateTime fechainicio1 = dtpinicio.Value.Date;
            //dtpprueba.Value = fechainicio1;
            // dtpprueba.Enabled = false;
            if (fechainicio < fechactual)
            {


                MessageBox.Show("NO PUEDES REGISTRAR EN UNA FECHA PASADA, SE CERRARÁ ESTA VENTANA", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panel5.Visible = false;
                // dtpinicio.Value = dtpprueba.Value;
                //dtpinicio.Enabled = false;

                // dtpfin.Value = dtpinicio.Value.AddDays(dias);

            }
        }

        private void dtpinicio_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {

                DateTime fecha = dtpinicio.Value.Date;
                double dias = Convert.ToDouble(txtplan.Text);
                dtpfin.Value = dtpinicio.Value.AddDays(dias);
            }
            catch (Exception ex)
            {
            }

        }

        private void dtpfin_ValueChanged_1(object sender, EventArgs e)
        {
            CaluculardiasRestantes();
        }

        private void panel5_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void txtnombre_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtpago_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpaquete_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtobservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthorario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtclases_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void TXTCALCULAR_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();

                da = new SqlDataAdapter("mostrar_usuario", con);
                da.Fill(dt);
                dtrgmostrarcuotas.DataSource = dt;
                con.Close();

                dtrgmostrarcuotas.Columns[1].Visible = false;
                dtrgmostrarcuotas.Columns[13].Visible = false;
                //datalistado.Columns[5].Visible = false;
                //datalistado.Columns[6].Visible = false;
                //datalistado.Columns[7].Visible = false;
                //datalistado.Columns[13].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CONEXION.Tamaño_automatico_de_datatables.Multilinea(ref dtrgmostrarcuotas);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            exportar(dtrgmostrarcuotas);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dtrgmostrarcuotas.Rows)
            {
                total += Convert.ToDouble(row.Cells["pago"].Value);
            }
            TXTCALCULAR.Text = Convert.ToString(total);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void afsdfsdfsd_ValueChanged(object sender, EventArgs e)
        {
            buscar_x_fecha();
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

            if (txtpasword.Text == "wedsa#12" && txtuser.Text == "PERSONAL")
            {
                panel21.Visible = false;
                panel2.Visible = true;
            }
            else
            {
                MessageBox.Show("CONTRASEÑA O USUARIO INCORRECTO!!");

            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("insertar_usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                cmd.Parameters.AddWithValue("@Plazo", txtplazo.Text);
                cmd.Parameters.AddWithValue("@Codigo", txtcodigo.Text);
                cmd.Parameters.AddWithValue("@Paquete", txtpaquete.Text);
                cmd.Parameters.AddWithValue("@Fecha_de_inicio", dtpinicio.Value.Date);
                cmd.Parameters.AddWithValue("@Plann", txtplan.Text);
                cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", dtpfin.Value.Date);
                cmd.Parameters.AddWithValue("@Clases", txtclases.Text);
                cmd.Parameters.AddWithValue("@Pago", txtpago.Text);
                cmd.Parameters.AddWithValue("@Observacion", txtobservacion.Text);
                cmd.Parameters.AddWithValue("@Horario", txthorario.Text);
                cmd.Parameters.AddWithValue("@Telefono", txttelefono.Text);
                cmd.Parameters.AddWithValue("@DNI", txtdni.Text);
                cmd.Parameters.AddWithValue("@Hora_registro", dtphoraderegistro.Value.Date);

                cmd.ExecuteNonQuery();
                con.Close();
                mostrar();
                //   panel4.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            panel5.Visible = false;
            panel8.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = CONEXION.CONEXIONMAESTRA.conexion;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("editar_usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@Nombre", txtnombre.Text);
                cmd.Parameters.AddWithValue("@Plazo", txtplazo.Text);
                cmd.Parameters.AddWithValue("@Codigo", txtcodigo.Text);
                cmd.Parameters.AddWithValue("@Paquete", txtpaquete.Text);
                cmd.Parameters.AddWithValue("@Fecha_de_inicio", dtpinicio.Value.Date);
                cmd.Parameters.AddWithValue("@Plann", txtplan.Text);
                cmd.Parameters.AddWithValue("@Fecha_de_vencimiento", dtpfin.Value.Date);
                cmd.Parameters.AddWithValue("@Clases", txtclases.Text);
                cmd.Parameters.AddWithValue("@Pago", txtpago.Text);
                cmd.Parameters.AddWithValue("@Observacion", txtobservacion.Text);
                cmd.Parameters.AddWithValue("@Horario", txthorario.Text);
                cmd.Parameters.AddWithValue("@Telefono", txttelefono.Text);
                cmd.Parameters.AddWithValue("@DNI", txtdni.Text);
                cmd.Parameters.AddWithValue("@Hora_registro", dtphoraderegistro.Value.Date);

                cmd.ExecuteNonQuery();
                con.Close();
                mostrar();
                //   panel4.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            panel5.Visible = false;
            panel8.Visible = true;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            dtphoraderegistro.Value = DateTime.Today;
            txtpago.Enabled = true;
        }
    }

  
}
