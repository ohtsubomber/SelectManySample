using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectManySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var data1 = new Data() { List = new List<string>() { "1", "2" } };
            var data2 = new Data() { List = new List<string>() { "3", "4" } };
            var dataList = new List<Data>() { data1, data2 };

            //data1とdata2のListを結合したListを作成
            var marge = dataList.SelectMany(data => data.List);

            foreach(var val in marge)
            {
                Console.WriteLine($"{val}");
            }

            Console.ReadLine();
        }
    }

    class Data
    {
        public List<string> List { get; set; }
    }
}
