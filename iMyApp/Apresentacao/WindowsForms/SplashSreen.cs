using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WindowsForms
{
    public partial class SplashSreen : Form
    {
        public SplashSreen()
        {
            InitializeComponent();
        }

        private void SplashSreen_Load(object sender, EventArgs e)
        {
            Thread.Sleep(10000);  
            
            this.Close();
        }


    }
}
