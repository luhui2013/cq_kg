using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CQKG
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Width = 490;
            this.webBrowser1.Height = 222;

            String web = System.IO.Path.Combine(Application.StartupPath, @"web\KG.html");

            this.webBrowser1.Navigate(web);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;


            String xml = readXml();

            if (xml != null)
            {
                webBrowser.Document.InvokeScript("loadData", new Object[] { xml });
            }

        }

        private string readXml()
        {
            String result=null;

            String flightInfo = System.IO.Path.Combine(Application.StartupPath, @"web\FireInfo.xml");
            StreamReader rd = null;

            try
            {
                rd = new StreamReader(flightInfo);
                result = rd.ReadToEnd();
            }
            catch{}
            finally
            {
                if (rd != null) rd.Close();
            }


            return result;
        }

       
    }
}
