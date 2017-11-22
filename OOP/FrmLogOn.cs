using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class FrmLogOn : Form
    {
        public FrmLogOn()
        {
            InitializeComponent();
        }

        protected string Title
        {
            get
            {
                return this.label2.Text;
            }
            set
            {
                this.label2.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "sfsd";
            this.label1.Text = "11111111111";

            this.label1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            this.Title = "1111";
            
        }
    }
}
