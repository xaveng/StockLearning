using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 로그인_Click(object sender, EventArgs e)
        {
            if (axKHOpenAPI1.CommConnect() == 0)
            {
                this.Text = "성공";
            } else
            {
                this.Text = "실패";
            }

        }
    }
}
