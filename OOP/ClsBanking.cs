using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    class ClsBanking : Object
    {
        //Field - Class Var.
        //internal decimal Balance = 0;

        public ClsBanking()//建構子
        {

        }

        public ClsBanking(Decimal money)//參數為接下來方法要使用的
        {
            this.m_Balance += money;//使用參數money
        }

        ~ClsBanking()//解構子
        {
            MessageBox.Show("Destrutor Finalize");
        }

        public void Dispose()
        {
            //......
            Debug.WriteLine("Destructor Finalize");
        }
        //Field - Class Var.
        //internal decimal Balance =0;


        //Property 
        private decimal m_Balance;
        public decimal Balance
        {
            get
            {
                //.............
                return m_Balance;
            }
            set

            {
                //..........
                if (value >=0)
                {
                    m_Balance =  value;
                }
              
            }
        }

        public void Test()
        {
            A();
            B();
            C();
        }

        public void Test(int  i)
        {

        }

        public void Test (int i, int j)
        {

        }
        public void Test(string s)
        {

        }

        private void A()
        {
            
        }
        private void B()
        {

        }
        private void C()
        {

        }

        //ReadOnly Property
        public int P1
        {
            get
            {
                //.....
                return 999;
            }
        }

        int m_P2;
        /// <summary>
        /// 
        /// </summary>
        public int P2
        {
            set
            {
                //.....
                m_P2 =  value;
            }
        }

        private int[] nums = { 101, 44,  2, 3 };

        /// <summary>
        /// Indexer.....
        /// </summary>
        /// <param name="i">i ......</param>
        /// <returns>return ......</returns>
        /// <exception cref="IndexOutOfRangeException"> Index out of range ....  </exception>
        public int this[int i]
        {
            get
            {
                if (i < 0 || i > nums.Length - 1)

                    throw new IndexOutOfRangeException("index out of range.......");

                return nums[i];
            }

        }

        public int this[string s]
        {
            get
            {
                int i = int.Parse(s);
                if (i < 0 || i > nums.Length - 1)

                    throw new IndexOutOfRangeException("index out of range.......");

                return nums[i];
            }

        }

        public int P3 { get; set; }

        public int P4
        {
           get
            {
                return 999;
            }
             private set
            {
                //....
               // value
            }
          
        }

        public decimal Deposit (decimal money)
        {
            this.m_Balance += money;
            return this.m_Balance;

        }
        public decimal Withdraw(decimal money)
        {
             if (this.m_Balance- money<0)
            {
                throw new Exception("餘額不足....");
            }
            this.m_Balance -= money;
            return this.m_Balance;

        }

    }
}
