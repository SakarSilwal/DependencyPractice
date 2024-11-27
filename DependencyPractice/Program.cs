namespace DependencyPractice
{
    interface ISchool
    {
        public void Role();
    }

    class Student : ISchool
    {
        public void Role()
        {
            Console.WriteLine("student role is to study in school");
        }
    }

    class Teacher : ISchool
    {
        public void Role()
        {
            Console.WriteLine("teacher role is to teach in school");
        }
    }

    class PaleDai : ISchool
    {
        public void Role()
        {
            Console.WriteLine("pale dai role is to guard the school");
        }
    }

    class CanteenDidi : ISchool
    {
        public void Role()
        {
            Console.WriteLine("canteen didi role is to cook food in school");
        }
    }

    class School
    {
        private ISchool _school;

        public School(ISchool school)
        {
            this._school = school;
        }

        public void PrintRole()
        {
            _school.Role();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ISchool sr = new Student();
            School s1 = new School(sr);
            s1.PrintRole();

            ISchool tr = new Teacher();
            School s2 = new School(tr);
            s2.PrintRole();

            ISchool pr = new PaleDai();
            School s3 = new School(pr);
            s3.PrintRole();

            ISchool cd = new CanteenDidi();
            School s4 = new School(cd);
            s4.PrintRole();
        }
    }
}
