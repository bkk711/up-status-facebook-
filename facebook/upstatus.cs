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
    public partial class upstatus : Form
    {
        private string tokens;

        public upstatus(String token)
        {
            InitializeComponent();
            tokens = token;
           
        }

        private void Upstatus_Load(object sender, EventArgs e)
        {

        }

        private void Tb_nd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_dang_Click(object sender, EventArgs e)
        {
            string noidung = tb_nd.Text;
            if(noidung == "")
            {
                MessageBox.Show("Không Được Để Trống ", "Thông Báo");

            }
            else
            {
                WebRequest request = HttpWebRequest.Create("http://buikhoi.com/facebook/stt.php?msg="+ noidung +"&token=" + tokens
                    );
                request.Method = "GET";
                String source;
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                source = reader.ReadToEnd();
                dynamic stuff = JsonConvert.DeserializeObject(source);
                if(stuff.id == "")
                {
                    MessageBox.Show("Đăng Không Thành Công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Đăng Thành Công", "Thông Báo");
                    tb_nd.Text = " ";
                }
            }
        }
    }
}
