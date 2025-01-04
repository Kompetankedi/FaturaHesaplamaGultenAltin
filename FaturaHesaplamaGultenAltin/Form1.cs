using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FaturaHesaplamaGultenAltin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public double dolaral()
        {
            // TCMB güncel döviz kurları XML adresi
            string url = "http://www.tcmb.gov.tr/kurlar/today.xml";

            // XML dosyasını indirme
            WebClient client = new WebClient();
            string xmlData = client.DownloadString(url);

            // XML dosyasını parse etme
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlData);

            // Dolar kuru bilgisini alma
            string dolarKuru = doc.SelectSingleNode("//Tarih_Date/Currency[@Kod='USD']/ForexSelling").InnerText;

            double dola = Convert.ToDouble(dolarKuru);
            double yeniSayi = dola / 10000;
            string formatliSayi = yeniSayi.ToString("0.0000");
            double dolar = Convert.ToDouble(formatliSayi);
            return dolar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            lblDolar.Text = dolaral().ToString();
            
            
        }
    }
}
