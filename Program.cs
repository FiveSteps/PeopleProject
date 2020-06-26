using System;

namespace PeopleProject
{
    class Program
    {
        class People
        {
            private int population;
            private string nation;



            public int Population
            {
                get { return population; }
                set
                {
                    if (population > 0) population = value;
                }
            }

            public string Nation
            {
                get { return nation; }
                set
                {
                    if (nation != "") nation = value;
                }
            }



            public People() { }

            public People(int Population)
            {
                population = Population;
            }

            public People(string Nation)
            {
                nation = Nation;
            }

            public People(int Population, string Nation)
            {
                population = Population;
                nation = Nation;
            }



            public void ChangePopulation(int Population)
            {
                Console.Write("Вы изменили значение population на ");
                population = Population;
                Console.WriteLine(population + "\n");
            }

            public void ChangeNation(string Nation)
            {
                Console.Write("Вы изменили значение nation на ");
                nation = Nation;
                Console.WriteLine(nation + "\n");
            }

            public void MakeAWar(bool b)
            {
                if (b == true) Console.WriteLine("Ваше государство разожгло войну\n");
                if (b == false) Console.WriteLine("Война не началась\n");
            }
        }

        class Student : People
        {
            private bool wellLearningAbility;
            private string name;



            public bool WellLearningAbility
            {
                get { return wellLearningAbility; }
                set
                {
                    if (wellLearningAbility == true) wellLearningAbility = value;
                }
            }

            public string Name
            {
                get { return name; }
                set
                {
                    if (name != "") name = value;
                }
            }



            public Student() { }

            public Student(bool WellLearningAbility)
            {
                wellLearningAbility = WellLearningAbility;
            }

            public Student(string Name)
            {
                name = Name;
            }

            public Student(bool WellLearningAbility, string Name)
            {
                wellLearningAbility = WellLearningAbility;
                name = Name;
            }



            public void LearningInformation()
            {
                Console.Write("Информация о студенте(способности): ");
                if (wellLearningAbility == true) Console.WriteLine("студент " + name + " является способным учеником\n");
                if (wellLearningAbility == false) Console.WriteLine("студент " + name + " плохой ученик\n");
            }

            public void NameInformation()
            {
                Console.Write("Информация о студенте(имя): ");
                Console.WriteLine("Имя студента " + name + "\n");
            }

            public void GoToStudy(bool choose)
            {
                if (choose == true) Console.WriteLine("Студент пошёл на учёбу\n");
                if (choose == false) Console.WriteLine("Студент не пошёл на учёбу\n");
            }
        }

        class Vendor : People
        {
            private string surname;
            private bool politeness;



            public string Surname
            {
                get { return surname; }
                set
                {
                    if (surname != "") surname = value;
                }
            }

            public bool Politeness
            {
                get { return politeness; }
                set
                {
                    if (politeness == true) politeness = value;
                }
            }



            public Vendor() { }

            public Vendor(string Surname)
            {
                surname = Surname;
            }

            public Vendor(bool Politeness)
            {
                politeness = Politeness;
            }

            public Vendor(string Surname, bool Politeness)
            {
                surname = Surname;
                politeness = Politeness;
            }



            public void NumberOfSalesInfo(int number)
            {
                Console.WriteLine("За текущий день было продано " + number + " единиц товара\n");
            }

            public void VendorInfo()
            {
                Console.WriteLine("Информация о продавце\n" + "Фамилия: " + surname);
                if (politeness == true) Console.WriteLine("Продавец вежливый\n");
                if (politeness == false) Console.WriteLine("Продавец грубый\n");
            }

            public void Income(double myIncome)
            {
                Console.WriteLine("Доход от продаж за день составляет " + myIncome + " рублей\n");
            }
        }

        static void Main(string[] args)
        {
            People people = new People(50_000, "Ubermensh");
            Student student = new Student(true, "Кенни");
            Vendor vendor = new Vendor("Майерс", true);

            people.ChangePopulation(49_768);
            people.ChangeNation("Untermensh");
            people.MakeAWar(true);

            student.NameInformation();
            student.LearningInformation();
            student.GoToStudy(false);

            vendor.NumberOfSalesInfo(87);
            vendor.VendorInfo();
            vendor.Income(67390);
        }
    }
}
