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
using System.Data;

namespace sifremi_unuttum
{
    public partial class ResetPassword : Form
    {
        string username = sendCode.to;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResetPass.Text == txtResetPassVer.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=ILAYDA\\SQLEXPRESS;Initial Catalog=forgetPassword;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[forgotPassword] SET[password] ='" + txtResetPassVer.Text + "' WHERE username='" + username + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Şifre Sırıflama Başarılı ");
            }
            else
            {
                MessageBox.Show("Yeni Şifre Eşleşmedi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
