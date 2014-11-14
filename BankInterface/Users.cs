using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankInterface
{
    public class Users
    {
       public static int[] accounts = { 12345, 11111, 22222, 33333, 44444, 55555, 66666, 77777, 88888, 99999, 00000 };
       public static int[] pins = { 12345, 11111, 22222, 33333, 44444, 55555, 66666, 77777, 88888, 99999, 00000 };
       public int[] money = { 12345, 11111, 22222, 33333, 44444, 55555, 66666, 77777, 88888, 99999, 00000 };



      public int getMoney(int i)
       {
           return money[i];
       }

      public void addMoney(int i,int moneyz)
       {
           money[i]+=moneyz;
       }

     public  void loseMoney(int i, int moneyz)
       {
           money[i] -= moneyz;
       }


    }
}
