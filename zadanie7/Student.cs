using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace zadanie5
{
    class Student
    {
        static int id;
        static string Fio;
        static string group;
        static string data;

         public ArrayList studinfo = new ArrayList(4);
         static public List<Student> students = new List<Student>();
        public  int Id
        {
            get
            {
                return id;
            }

            set
            {
               if (value>=0) id = value;
            }
        }

       public string FIO
        {
            get
            {
                return Fio;
            }

            set
            {
                if (!value.Trim().Equals("")) Fio = value;
            }
        }

        public string Group
        {
            get
            {
                return group;
            }

            set
            {
                if (!value.Trim().Equals("")) group = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public void AddStudent(int id,string Fio, string group,string data)
        {

            studinfo.Add(id);
            studinfo.Add(Fio);
            studinfo.Add(group);
            studinfo.Add(data);
            students.Add(this);
        }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public void StudentWrite()
        {
            foreach (object o in studinfo)
            {
                Console.WriteLine(o + " ");
            }
        }
        static public void StudentWriteFio(Student s)
        {

            Console.WriteLine(s.studinfo[1]);
            
        }

        static public void StudentWriteFioShort(Student s)
        {
            string[] str = s.studinfo[1].ToString().Split(' ');

            Console.WriteLine(str[0] + " " + str[1][0] + ". " + str[2][0] + ".");

        }

        static public int StudentAge(Student s)
        {

            DateTime Date = DateTime.ParseExact(s.studinfo[3].ToString(), "dd.mm.yyyy", null);
            DateTime now = DateTime.Now;
            TimeSpan age = now.Subtract(Date);
            int years = (int)age.TotalDays;
            years = years / 365;
            return years;

        }
        public void ChangeId(int id)
        {
            studinfo[0] = id;
        }

         public void ChangeFio(string Fio)
        {
            studinfo[1] = Fio;
        }
         public void ChangeGroup(string group)
        {
            studinfo[2] = group;
        }
         public void ChangeData(string data)
        {
            studinfo[3] = data;
        }

         public void RemoveStudent()
        {
            students.Remove(this);
            studinfo.Clear();

        }
        static public void WriteAll()
        {
            
            foreach ( Student o in students)
            {
                StudentWriteFio(o);
            }
        }

        static public void WriteAll(List<Student> st)
        {

            foreach (Student o in st)
            {
                StudentWriteFio(o);
            }
        }

        static public void WriteAllId(int id_)
        {
            foreach (Student o in students)
            {
                if ( id_ == (int)o.studinfo[0])
                {
                    o.StudentWrite();
                }

            }
        }

       static public void WriteAge(int id_)
        {
            foreach (Student o in students)
            {
                if (id_ == (int)o.studinfo[0])
                {
                    Console.WriteLine(StudentAge(o));
                }

            }
        }

        static public List<Student> Around18(char c)
        {
            List<Student> stmas = new List<Student>();
            if (c.Equals('a'))
            {
                foreach (Student o in students)
                {
                    if(StudentAge(o) >= 18)
                    {
                        stmas.Add(o);
                    }
                }

            }
            else if (c.Equals('s'))
            {
                foreach (Student o in students)
                {
                    if (StudentAge(o) < 18)
                    {
                        stmas.Add(o);
                    }
                }
            }
            return stmas;
        }

        static public List<Student> FamSearch(string fam)
        {
            List<Student> stmas = new List<Student>();
            

                foreach (Student o in students)
                {
                string[] str = o.studinfo[1].ToString().Split(' ');
                if (str[0].Trim().Equals(fam))
                    {
                        stmas.Add(o);
                    }
                }

            return stmas;
        }

        static public List<Student> FamStartSearch(string fam)
        {
            List<Student> stmas = new List<Student>();

            foreach (Student o in students)
            {
                string str = o.studinfo[1].ToString();
                int c = 0;
                for (int i = 0; i < fam.Length; i++)
                {
                    if (str[i].Equals(fam[i]))
                    {
                        c++;
                    }
                }
                if (c == fam.Length)
                {
                    stmas.Add(o);
                }
            }

            return stmas;
        }

    }
}
