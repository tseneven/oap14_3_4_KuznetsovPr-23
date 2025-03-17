using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt14_3_4_KuznetsovPr_23
{
    class People
    {
        public string name;
        public string surname;
        public string fname;
        public int age;
        public int ves;


        public string Check_name()
        {
            if (name != " ")
            {
                return " ";
            }
            else return " Ошибка: Нету имени в файле";
        }
        public string Check_surname()
        {
            if (surname != " ")
            {
                return " ";
            }
            else return " Ошибка: Нету фамилии в файле";
        }
        public string Check_fname()
        {
            if (fname != " ")
            {
                return " ";
            }
            else return " Ошибка: Нету отчества в файле";
        }
        public string Check_age()
        {
            string str_age = Convert.ToString(age);
            if (str_age != " ")
            {
                return " ";
            }
            else return " Ошибка: Нету возраста в файле";
        }
        public string Check_ves()
        {
            string str_ves = Convert.ToString(ves);
            if (str_ves != " ")
            {
                return " ";
            }
            else return " Ошибка: Нету веса в файле";
        }


    }
}
