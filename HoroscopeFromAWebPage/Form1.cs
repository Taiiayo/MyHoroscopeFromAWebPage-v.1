using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoroscopeFromAWebPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            WebClient wbClient = new WebClient();
            wbClient.Encoding = Encoding.UTF8;
            string page = wbClient.DownloadString("https://horo.mail.ru/prediction/capricorn/today/");
            string name = "<p>(.*?)</p>";
            var matches = Regex.Matches(page, name);
            foreach (Match match in matches)
            {
                 textBox1.AppendText(match.Groups[1].Value + Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
