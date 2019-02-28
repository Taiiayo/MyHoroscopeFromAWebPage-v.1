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
using NLog;

namespace HoroscopeFromAWebPage
{
    public partial class Form1 : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private string urlToHoroscope;

        public enum Signs
        {
            Aries,
            Taurus,
            Gemini,
            Cancer,
            Leo,
            Virgo,
            Libra,
            Scorpio,
            Sagittarius,
            Capricorn,
            Aquarius,
            Pisces
        }

        public Form1()
        {
            logger.Info("Starting app");
            InitializeComponent();

            comboBox1.Items.Add(Signs.Aries);
            comboBox1.Items.Add(Signs.Taurus);
            comboBox1.Items.Add(Signs.Gemini);
            comboBox1.Items.Add(Signs.Cancer);
            comboBox1.Items.Add(Signs.Leo);
            comboBox1.Items.Add(Signs.Virgo);
            comboBox1.Items.Add(Signs.Libra);
            comboBox1.Items.Add(Signs.Scorpio);
            comboBox1.Items.Add(Signs.Sagittarius);
            comboBox1.Items.Add(Signs.Capricorn);
            comboBox1.Items.Add(Signs.Aquarius);
            comboBox1.Items.Add(Signs.Pisces);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient wbClient = new WebClient { Encoding = Encoding.UTF8 };
                string horoscope = wbClient.DownloadString(urlToHoroscope);
                logger.Info("Horoscope was downloaded succesfully");
                string name = "<p>(.*?)</p>";
                var matches = Regex.Matches(horoscope, name);
                foreach (Match match in matches)
                {
                    mainTextBox.AppendText(match.Groups[1].Value + Environment.NewLine + Environment.NewLine);
                }
            }
            catch (Exception exception)
            {
                logger.Error(exception, "App logic error");
            }           
            LogManager.Flush();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    urlToHoroscope = "https://horo.mail.ru/prediction/aries/today/";
                    break;
                case 1:
                    urlToHoroscope = "https://horo.mail.ru/prediction/taurus/today/";
                    break;
                case 2:
                    urlToHoroscope = "https://horo.mail.ru/prediction/gemini/today/";
                    break;
                case 3:
                    urlToHoroscope = "https://horo.mail.ru/prediction/cancer/today/";
                    break;
                case 4:
                    urlToHoroscope = "https://horo.mail.ru/prediction/leo/today/";
                    break;
                case 5:
                    urlToHoroscope = "https://horo.mail.ru/prediction/virgo/today/";
                    break;
                case 6:
                    urlToHoroscope = "https://horo.mail.ru/prediction/libra/today/";
                    break;
                case 7:
                    urlToHoroscope = "https://horo.mail.ru/prediction/scorpio/today/";
                    break;
                case 8:
                    urlToHoroscope = "https://horo.mail.ru/prediction/sagittarius/today/";
                    break;
                case 9:
                    urlToHoroscope = "https://horo.mail.ru/prediction/capricorn/today/";
                    break;
                case 10:
                    urlToHoroscope = "https://horo.mail.ru/prediction/aquarius/today/";
                    break;
                case 11:
                    urlToHoroscope = "https://horo.mail.ru/prediction/pisces/today/";
                    break;
                default:
                    logger.Error("Switch case wasn't identified");
                    break;
            }
        }
    }
}
