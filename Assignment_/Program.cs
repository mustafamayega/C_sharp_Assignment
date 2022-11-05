using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment_
{
   

    public delegate String StudentDetails(String name);
    public delegate int StudentId(int id);
    class Student_Details
    {
        String Adress;
        static void Main(string[] args)
        {
            String Name = "MAYEGA MUSTAFA";
            int ID = 776003035;
            string studentID = ID.ToString();

            StudentDetails objStudentDetails = new StudentDetails(getStudentName);
            StudentId objstudentId = new StudentId(student_Id);
            Console.WriteLine("Student's Name:\t\t" + objStudentDetails(Name));
            Console.WriteLine("Student's identity number:\t" + objstudentId(ID));

            Student_Details objstd = new Student_Details();
            objstd.StudentAddress = "ENTEBBE";

            Console.WriteLine("Student's Address or location is:\t" + objstd.StudentAddress);



            Dictionary<string, string> objdctnry = new System.Collections.Generic.Dictionary<string, string>();
            objdctnry.Add("Student's ID:\t\t", studentID);
            objdctnry.Add("Student's Name:\t\t", Name);
            objdctnry.Add("Student's Address:\t\t", objstd.StudentAddress);
            Console.WriteLine();
            ICollection objcollection = objdctnry.Keys;
            foreach (String a in objcollection)
            {
                Console.WriteLine(a + "\t" + objdctnry[a]);
               // Console.WriteLine(a + "\n\t\tthis is my work thank your\n mayegamustafa");
                
            }

            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.ReadKey();

        }
        public static String getStudentName(String studName)
        {
            return studName;
        }
        public static int student_Id(int id)
        {
            return id;
        }
        

        public String StudentAddress
        {
            get
            {
                return Adress;
            }

            set
            {
                Adress = value;
            }
        }
    }
}
