using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_
{
  
    internal class Program
    {
       


        static void Main(string[] args)
        {
            student st = new student();
            st.getStudentName(StudentDetails);

            studentId dt = new studentId();
            dt.getStudentID(StudentDetail);


            studentAddres adrs = new studentAddres();
            adrs.getStudentaddress(StudentAddress);

        }
        static void StudentDetails(string name)
        {
            Console.WriteLine("\t"+name);
          //  Console.WriteLine(ID);
        }
        static void StudentDetail(int ID)
        {
          
           Console.WriteLine("\t"+ID);
        }

        static void StudentAddress(string address)
        {

            Console.WriteLine("\t" + address);
        }
    }


    class student
    {
        public delegate void StudentDetails(string name);
        public void getStudentName(StudentDetails st)
        {
           
            Console.WriteLine("Students name is \t"+"Mayega Mustafa" );
        }
    }

    class studentId
    {
        public delegate void StudentDetail(int ID);
        public void getStudentID(StudentDetail id)
        {
            Console.WriteLine("Students ID is \t" + 200);
        }
    }

    class studentAddres
    {
        public delegate void StudentAddress(string address);
        public void getStudentaddress(StudentAddress Adress)
        {
            Console.WriteLine("Students Location is \t" + "Entebbe");
        }
    }
}
