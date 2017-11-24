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

namespace OOP
{
    public partial class FrmOOP : Form
    {
        public FrmOOP()
        {
            InitializeComponent();
            this.tabControl1.SelectedIndex = 6;
        }
        ClsBanking x = new ClsBanking();

        private void button1_Click(object sender, EventArgs e)
        {
         //  x  = new ClsBanking();
            MessageBox.Show("x Balance = " + x.Balance);
          
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Get Balance
            this.label1.Text = x.Balance.ToString("c2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Set Balance
            x.Balance = decimal.Parse(this.textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //public
            button1.Text = "xxxx";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x.Test();
//            x.A(); 嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
//錯誤  CS0122  'ClsBanking.A()' 由於其保護層級之故，所以無法存取。	OOP c:\C# Advanced\OOP\OOP\Form1.cs	50	使用中


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //x.Balance;

            MessageBox.Show(  SystemInformation.ComputerName);

            //            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
            //錯誤  CS0200 無法指派為屬性或索引子 'SystemInformation.ComputerName'-- 其為唯讀 OOP c:\C# Advanced\OOP\OOP\FrmOOP.cs	62	使用中

            //SystemInformation.ComputerName = "xxxx";

            string s  =SystemInformation.ComputerName;

            // x.P1 = 888;
            MessageBox.Show("x.P1 = " + x.P1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            x.P2 = 100;
//            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
//錯誤  CS0154 屬性或索引子 'ClsBanking.P2' 無法用在此內容中，因為它缺少 get 存取子。	OOP C:\C# Advanced\OOP\OOP\FrmOOP.cs	82	使用中

//            int w =  x.P2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable table = this.northwindDataSet.Products;

            //DataRow dr = new DataRow();
             DataRow dr  = table.Rows[0];
            MessageBox.Show(dr[0].ToString());

            MessageBox.Show(table.Rows[0][0].ToString());

            //===============================

            MessageBox.Show(this.northwindDataSet.Products[0].ProductName);
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void FrmOOP_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'northwindDataSet.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<Point> list = new List<Point>();

            list.Add(new Point(100, 100));
            list.Add(new Point(200, 200));
            list.Add(new Point(300, 100));
           // list.Add(888);

            MessageBox.Show(list[1].X + ", " + list[1].Y);

            this.dataGridView1.DataSource = list;
            
        }

        private void button10_Click(object sender, EventArgs e)
        {   //int i = 100;
            try
               

            {     MessageBox.Show(x[10].ToString());

            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }

        private void button12_Click(object sender, EventArgs e)
        {
            x.P3 = 999;
            MessageBox.Show(x.P3.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //x.P4 = 999;
            MessageBox.Show(x.P4.ToString());
        }
   ClsBanking a = new ClsBanking();
        private void button13_Click(object sender, EventArgs e)
        {
         
            a.Deposit(3000);
            this.label4.Text = a.Balance.ToString("c2");

            ClsBanking b = new ClsBanking();
            b.Deposit(2000);
            MessageBox.Show("b balance = " + b.Balance);


        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                  a.Withdraw(1000);
                this.label4.Text = a.Balance.ToString("c2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void button15_Click(object sender, EventArgs e)
        {

            MessageBox.Show("xxx");
            x.Test();
            x.Test(2100, 333);
            x.Test(22);
            x.Test("dfs");


        }

        private void button16_Click(object sender, EventArgs e)
        {
            int n =  x[1];
            int n1 = x["1"];

            //DataRow dr = new DataRow();
            //dr[]
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ClsBanking a = new ClsBanking();//宣告新實體參數空值預設為 0
            MessageBox.Show("a balance =" + a.Balance);

            ClsBanking b = new ClsBanking(1000);//宣告新實體參數1000，值為10000
            MessageBox.Show("b balance =" + b.Balance);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ClsBanking a = new ClsBanking();//解構子範例
            a.Deposit(1000);

            a = null;
        }

        private void button17_Click(object sender, EventArgs e)// 回收記憶體
        {
            //GC.Collect();//主動啟動Garbage Collection回收使用過的記憶體
        }
        int count = 0;
        private void button41_Click(object sender, EventArgs e)
        {
            count = count + 1;
            label10.Text = count.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Dispose() 範例
            ClsBanking a = new ClsBanking();
            a.Deposit(1000);
            //.....
            //using (ClsBanking b = new ClsBanking())
            //{

            //}//b.Dispose()


            a.Dispose();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            for(int i=1; i<5000; i++)
            {
                ClsMemoryTest x = new ClsMemoryTest();
                this.label9.Text = ClsMemoryTest.count.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label9.Text = ClsMemoryTest.count.ToString();
            timer1.Start();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            MyPoint pt1 = new MyPoint();
            MyPoint pt2 = new MyPoint(1, 2, 3);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //Exception ex =new Exception()
            //Font font1 = new Font();

            MyPoint pt1 = new MyPoint(99, 99);
            MyPoint pt2 = new MyPoint(1, 2, 3);

            List<MyPoint> list = new List<MyPoint>();
            list.Add(pt1);
            list.Add(pt2);
            
            //細節時只有屬性看得到，欄位無法===================以上為建構子方法

            //3.0物件初始化
            MyPoint pt3 = new MyPoint { P1 = 88, P2 = 88, P3 = 77, Field1 = "aaaa", Field2 = "bbbb" };
            MyPoint pt4 = new MyPoint { P1 = 101 };
            list.Add(pt3);
            list.Add(pt4);
            this.dataGridView2.DataSource = list;
            //=====================以上為物件初始化，使用大括號即可

            List<MyPoint> mylist = new List<MyPoint>()
            {
                new MyPoint{P1=1, P2=1, P3=1},
                new MyPoint{P1=3, P2=6, P3=11},
                new MyPoint{P1=15, P2=13, P3=18},
            };
            this.dataGridView3.DataSource = mylist;

            //=======================================
            List<ClsBanking> BankingList = new List<ClsBanking>();
            BankingList.Add(new ClsBanking { Balance = 777, P2 = 8, P3 = 7 });
            BankingList.Add(new ClsBanking { Balance = 888, P2 = 8, P3 = 7 });
            BankingList.Add(new ClsBanking { Balance = 66, P2 = 8, P3 = 7 });
            BankingList.Add(new ClsBanking { Balance = 57, P2 = 7, P3 = 7 });
            this.dataGridView3.DataSource = BankingList;
        }

        class MyPoint
        {
            public MyPoint()
            {

            }

            public MyPoint(int p1)//方法
            {

            }

            public MyPoint(int p1, int p2)//方法
            {
                this.P1 = p1;
                this.P2 = P2;
            }

            public MyPoint(int p1, int p2, int p3)//方法
            {
                this.P1 = p1;
                this.P2 = P2;
                this.P3 = p3;
            }


            private int m_P1;//欄位

            public int P1//屬性
            {
                get
                {
                    return m_P1;
                }
                set
                {
                    m_P1 = value;
                }
            }

            public int P2 { get; set; }//屬性

            public int P3 { get; set; }//屬性

            public string Field1, Field2;//欄位
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //static Method 靜態方法
            File.Copy("a.txt", "a1.txt", true);

            //=======================
            //Instance Method
            FileInfo f = new FileInfo("b.txt");
            MessageBox.Show(f.CreationTime + "\n" + f.FullName + "\n" + f.Extension);
            f.CopyTo("b1.txt", true);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //static class Math
            //static class File
            int n = Math.Abs(-100);
            MessageBox.Show(n.ToString());
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ClsBanking.InterstRate.ToString());
        }

        private void button43_Click(object sender, EventArgs e)
        {
            this.Text = "Hello" + textBox2.Text;
        }

        ClsSpecialBanking b = new ClsSpecialBanking();
        private void button39_Click(object sender, EventArgs e)
        {

            this.label4.Text = b.Deposit(1000).ToString("c2");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.label4.Text = b.Withdraw(1000).ToString("c2");
        }
               
        ClsBanking myBase;//父型別變數
        private void button30_Click(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)//判斷進入父類別 還是 子類別
            {
                myBase = new ClsSpecialBanking();
            }
            else
            {
                myBase = new ClsBanking();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.label4.Text = myBase.Deposit(1000).ToString("c2");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.groupBox4.Controls)
            {
                if (x is Button)
                {
                    x.BackColor = Color.Orange;
                    x.ForeColor = Color.White;
                }
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            List<ClsBanking> bankingList = new List<ClsBanking>();
            bankingList.Add(new ClsBanking { Balance = 999 });
            bankingList.Add(new ClsSpecialBanking { Balance = 1999, P2 = 11, P3 = 6 });

            this.dataGridView5.DataSource = bankingList;
            this.listBox1.DataSource = bankingList;
        }

        private void button38_Click(object sender, EventArgs e)
        {

            ((Button)sender).Text = "xxxxx";
            ClsBanking a = new ClsBanking();
            MessageBox.Show("a balance =" + MyDeposit(a));

            ClsSpecialBanking b = new ClsSpecialBanking();
            MessageBox.Show("b balance =" + MyDeposit(b));
        }

        decimal MyDeposit(ClsBanking x)
        {
            //...Call M1()
            if(x is ClsSpecialBanking)
            {
                (((ClsSpecialBanking)x).M1)();
            }

            return x.Deposit(1000);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + myBase.ToString());
        }
        int acb = 999;//遮蔽(Shadowing)宣告的數質會因區域中宣告改變，以及遮蔽。
        private void button56_Click(object sender, EventArgs e)
        {
            int abc = 888;
            MessageBox.Show("abc =" + abc);
        }

        private void button55_Click(object sender, EventArgs e)//遮蔽範例
        {
            ClsSpecialBanking y = new ClsSpecialBanking();

            //父類方法
            y.Test();
            y.Test(3);
            y.Test("df");

            //父類固有， 子類方法新成立
            y.Test(4, 4);

            y.Test(8, 8, 8);//子類新增
        }

        private void button54_Click(object sender, EventArgs e)//抽象類別範例
        {
                //            嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
                //錯誤  CS0144 無法建立抽象類別或介面 'TextReader' 的執行個體 OOP F:\MSIT11730305\C#Advanced\Starter\1. OOP\OOP\FrmOOP.cs	498	使用中
                
            //System.IO.TextReader tr = new System.IO.TextReader();

            System.IO.StreamReader sr = new StreamReader("a.txt");

            //A a = new A();
            B b = new B();//實作成功

        }

        abstract class A //抽象類別實作
        {
            public void M1()//屬性
            {
                //..........
            }

            public abstract void M2();//方法，只有定義
        }

        class B : A //子承父，抽象類別實作
        {
            public override void M2()//關鍵字子類有override ，父類abstract，方法只定義
            {
                //............
            }
        }

        private void button52_Click(object sender, EventArgs e)//密封類型實作
        {
            //System.IO.FileInfo;
        }

//        嚴重性 程式碼 說明 專案  檔案 行   隱藏項目狀態
//錯誤  CS0509	'FrmOOP.C': 無法衍生自密封類型 'FileInfo'	OOP F:\MSIT11730305\C#Advanced\Starter\1. OOP\OOP\FrmOOP.cs	538	使用中

        //class C: System.IO.FileInfo
        //{

        //}

        sealed class D//密封類型宣告
        {

        }
    }
}
