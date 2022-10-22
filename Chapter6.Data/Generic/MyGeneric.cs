using Chapter6.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.Data.Generic
{
    public class MyGeneric<T>  where T: IComparable,IConvertible
    {
        public void WriteToConsole<T>(T input) where T : IComparable, IConvertible
        {
            double doulbeValue;
            var isSucess = input.ToDouble(Thread.CurrentThread.CurrentCulture);
           
        }

        public void CompareAble(T input)
        {
            var isSucess = input.CompareTo(input);

        }



    }
}
