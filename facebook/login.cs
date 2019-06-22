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
using System.Net;
using Newtonsoft.Json;

namespace facebook
{
    public partial class login : Form
    {
       
        public login()
        {
            InitializeComponent();
        }
        


        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txt_user.Text;
            pass = txt_pass.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản hoặc mật khẩu", "Thông báo");
            }
            else
            {

            
            WebRequest request = HttpWebRequest.Create("http://buikhoi.com/facebook/login.php?user=" + user + "&pass=" + pass);
            request.Method = "GET";
            String source;
            StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
            source = reader.ReadToEnd();
                dynamic stuff = JsonConvert.DeserializeObject(source);
                string token = stuff.token;
                string text = stuff.text;
                if (token == "") //neu sai ten dang nhap thi bao loi
                {
                    MessageBox.Show(text, "Thông Báo");
                }
                else // neu dusng thi mo form info
                {
                    MessageBox.Show(text, "Thông Báo");
                    info Child = new info(token);
                    this.Hide();
                    Child.Show();
                    
                   
                }
            MessageBox.Show(text);
            }
        }
    }
}
