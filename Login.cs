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
using Examen2Parcial.Sql;
using System.Threading;

namespace Examen2Parcial
{
    public partial class Login : Form
    {

        private readonly SqlClient _clientu;

        public Login()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            {

                Fin FinForm = new Fin();
                this.Hide();

                FinForm.ShowDialog(this);
                this.Dispose();


                //bool error1 = false;

                //try
                //{
                //    var eMailValidator = new System.Net.Mail.MailAddress(correoLogin.Text);
                //}
                //catch (FormatException )
                //{
                //    MessageBox.Show("Introduce un email válido.");
                //    return;
                //}

                //try
                //{
                //    if (_clientu.Open())
                //    {
                //        var command = new SqlCommand
                //        {
                //            Connection = _clientu.Connection,
                //            CommandText = "SacarContra",
                //            CommandType = CommandType.StoredProcedure
                //        };

                //        var par1 = new SqlParameter("@correo", SqlDbType.NVarChar)
                //        {
                //            Direction = ParameterDirection.Input,
                //            Value = correoLogin.Text,
                //        };

                //        command.Parameters.Add(par1);

                //        var reader = command.ExecuteReader();

                //        while (reader.Read())
                //        {
                //            string pass = Convert.ToString(reader["contraseña"]);
                //            if (pass == contraseñaLogin.Text)
                //                error1 = true;
                //        }
                //    }
                //}
                //catch (Exception)
                //{
                //    //result = false;
                //}
                //finally
                //{
                //    _clientu.Close();
                //    if (error1)
                //    {
                //        //string aux = correoLogin.Text;
                //        //MessageBox.Show("Iniciando sesión.");
                //        //var t = new Thread(() => Application.Run(new DashBoard(aux)));
                //        //t.Start();
                //        //this.Close();
                //    }
                //    else
                //        MessageBox.Show("Contraseña Incorrecta. Inténtalo de nuevo.");
                //}
            }
        }

        private void IrARegistro_Click(object sender, EventArgs e)
        {
            Form1 miForm1 = new Form1();
            this.Hide();

            miForm1.ShowDialog(this);
            this.Dispose();
        }
    }
}
