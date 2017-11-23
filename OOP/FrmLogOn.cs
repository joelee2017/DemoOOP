using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace OOP
{
    public partial class FrmLogOn : Form
    {
        public FrmLogOn()
        {
            InitializeComponent();

            this.Paint += FrmLogOn_Paint;

            this.Color1 = Color.ForestGreen;
            this.Color2 = Color.DarkGreen;
        }
        private void FrmLogOn_Resize(object sender, EventArgs e)
        {
            this.Invalidate();//背景重繪 Paint Event
        }

        private void FrmLogOn_Paint(object sender, PaintEventArgs e)
        {
            //GDI +
            Graphics g = e.Graphics; //宣告繪圖圖形
            //SolidBrush brush1 = new SolidBrush(Color.Blue);單一色藍色

            Point pt1 = new Point(0, 0);//宣告第一點
            Point pt2 = new Point(0, this.ClientRectangle.Height);//宣告第二點工作區矩形高
            LinearGradientBrush brush1 = new LinearGradientBrush(pt1, pt2, this.Color1,this.Color2);
            g.FillRectangle(brush1, this.ClientRectangle);
            //宣告漸層圖形初始化(pt1, pt2, Color.Black, Color.OrangeRed);
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

        public Color Color1 { get; set; }//自動實作

        private Color m_Color2;
        public Color Color2
        {
            get
            {
                return m_Color2;
            }
            set
            {
                this.m_Color2 = value;
                this.Invalidate();
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
