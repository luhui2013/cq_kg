using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CQKG
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String web = System.IO.Path.Combine(Application.StartupPath, @"web\20111031_3t4_sp_cq.swf");
            this.axShockwaveFlash1.Movie = web;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String web = System.IO.Path.Combine(Application.StartupPath, @"web\empty.swf");
            this.axShockwaveFlash1.Movie = web;


        }
    }
}
