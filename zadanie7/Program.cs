﻿
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace zadanie5
    {
        class Program
        {
            static void Main(string[] args)
            {

                Student Andrey = new Student();
                Andrey.AddStudent(1, "Иванов Андрей Владимирович", "19-11-2", "25.12.2001");
                Andrey.ChangeGroup("19-11-1");
                Andrey.StudentWrite();
                Student Eva = new Student();
                Eva.AddStudent(2, "Коновалова Ева Ивановна", "18-11-3", "16.06.2000");
                Student Anna = new Student();
                Anna.AddStudent(3, "Огурцова Анна Николаевна", "18-11-1", "07.01.2000");
                Student Oleg = new Student();
                Oleg.AddStudent(3, "Иванов Олег Сергеевич", "21-11-1", "07.12.2003");
                Student Sasha = new Student();
                Sasha.AddStudent(3, "Иранов Александр Сергеевич", "21-11-1", "08.10.2003");
            //задание6
            Student.WriteAll();
                Student.WriteAllId(2);
                Student.WriteAge(3);
                //задание 7
                Student.StudentWriteFioShort(Andrey);
            List<Student> less18 = Student.Around18('s');
            Student.WriteAll(less18);
            Console.WriteLine("______");
            List<Student> more18 = Student.Around18('a');
                Student.WriteAll(more18);
            Console.WriteLine("______");
            Student.WriteAll(Student.FamSearch("Иванов"));
            Console.WriteLine("______");
            Student.WriteAll(Student.FamStartSearch("И"));
            Console.WriteLine("______");
            Student.WriteAll(Student.FamStartSearch("Ив"));
            Console.ReadKey();


            }
        }
    }

