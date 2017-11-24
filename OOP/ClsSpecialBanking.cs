using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class ClsSpecialBanking : ClsBanking
    {
        public override decimal Deposit(decimal money)//override關鍵字修改父類別方法
        {
            this.m_Balance = this.m_Balance + money - 100;

            return this.m_Balance;
            //m_Balance父類別已改成protected所以子類別可以使用。
        }

        public override decimal Withdraw(decimal money)
        {
            if (this.m_Balance - money - 100 < 0)
            {
                throw new Exception("餘額不足....");
            }
            this.m_Balance = this.m_Balance - money - 100;
            return this.m_Balance;
        }

        public void M1()
        {

        }

        public override string ToString()
        {
            return "ClsSpecialBanking" + this.Balance;
        }

        //遮蔽範例===========================================17/11/24

        //overloads
        public void Test(int i, int j, int k)//新建不同於父類的方法
        {

        }

        //Shadows
        public new void Test(int i,int j)//當於父類同樣方法時，會遮蔽父類方法，除非使用 NEW 新成立
        {

        }
           
    }
}
