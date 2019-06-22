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
    public partial class info : Form
    {
        private string tokens;

        public info(String token)
        {
            InitializeComponent();
            WebRequest request = HttpWebRequest.Create("http://buikhoi.com/facebook/info.php?token=" + token);
            request.Method = "GET";
            String source;
            StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
            source = reader.ReadToEnd();
            dynamic stuff = JsonConvert.DeserializeObject(source);
            pic_avt.ImageLocation = stuff.avt;
            lb_name.Text = stuff.name;
            lb_ns.Text = stuff.birthday;
            lb_qq.Text = stuff.hometown;
            tokens = token;

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Pic_avt_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            upstatus stt = new upstatus(tokens);
            this.Hide();
            stt.Show();
        }
    }
}
