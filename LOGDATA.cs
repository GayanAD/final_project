using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace final_project
{
    class LOGDATA
    {

        public void logsave(string un)
        {


          //  StreamWriter ft = new StreamWriter (@"E:\final_project\logdata");
           
       //     FileStream gg=File.Open(@"E:\final_project\logdata",FileMode.OpenOrCreate,FileAccess.Write);


            string date = DateTime.Now.ToString();


            using (StreamWriter sw = File.AppendText(@"E:\final_project\logdata\logdata.log"))
            {
                sw.WriteLine("====================LOG====================");
                sw.WriteLine("User name = " + un);
                sw.WriteLine(date);
                sw.WriteLine("===========================================");
                
            }



        }


        public void readdata()
        {

       //   System.Console.ReadKey();
            


           

        }

    }
}
