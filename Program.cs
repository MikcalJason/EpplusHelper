using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace EpplusHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> peopleList = new List<People>(){
                new People(){ name="xx", sex="xx",age=18},
                new People(){ name="xx", sex="xx",age=14},
            };
            EpplusHelper.CreatExcelByClass<People>(@"C:\Users\Jazz\Desktop\1.xlsx", peopleList);
        }
    }

    class People
    {
        public string name;
        public int age;
        public string sex;
    }
}
