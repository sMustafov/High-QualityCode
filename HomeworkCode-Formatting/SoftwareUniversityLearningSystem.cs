using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem4.SoftwareUniversityLearningSystem
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public string FirstName {
            get { return firstName; }
            set { this.firstName = value; }
            }

        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            return string.Format("{3}:\nName: {0} {1}\n{2} years old", this.FirstName, this.LastName, this.Age, GetType().Name);
        }

    }

    class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            
        }
        public static void CreateCourse(string courseName)
        {
            Console.WriteLine("The course {0} has been created!",courseName);
        }
    }

    class JuniorTrainer : Trainer
    {
        public JuniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {

        }
    }

    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            
        }

        public static void DeleteCourse(string courseName)
        {
            Console.WriteLine("The course {0} has been deleted!", courseName);
        }
    }

    class Student : Person
    {
        private long studentNum;
        private double averageGrade;

        public Student(string firstName, string lastName, int age, long studentNum, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.studentNum = studentNum;
            this.averageGrade = averageGrade;
        }
        public long StudentNum
        {
            get { return studentNum; }
            set { this.studentNum = value; } }

        public double AverageGrade
        {
            get { return averageGrade; }
            set { this.averageGrade = value; }
        }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format("\nStudent number: {0}\nAverage grade: {1}", this.StudentNum, this.AverageGrade);
        }
    }
    class GraduateStudent : Student
    {

        public GraduateStudent(string firstName, string lastName, int age, long studentNum, double averageGrade)
            : base(firstName, lastName, age, studentNum, averageGrade)
        {

        }
    }

    class CurrentStudent : Student
    {
        private string currentCourse;

        public CurrentStudent(string firstName, string lastName, int age, long studentNum, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNum, averageGrade)
        {
            this.currentCourse = currentCourse;
        }
        public string CurrentCourse {
            get
            {
                return currentCourse;
            }
            set { this.currentCourse = value; } }

        public override string ToString()
        {
            string baseStr = base.ToString();
            return baseStr + string.Format("\nCurrent Course: {0}\n", CurrentCourse);
        }
    }

    class OnsiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnsiteStudent(string firstName, string lastName, int age, long studentNum, double averageGrade, string currentCourse, 
            int numberOfVisits)
            : base(firstName, lastName, age, studentNum, averageGrade, currentCourse)
        {
            this.numberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get { return numberOfVisits; }
            set { this.numberOfVisits = value; }
        }
    }

    class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, int age, long studentNum, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNum, averageGrade, currentCourse)
        {

        }
    }

    class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, long studentNum, double averageGrade,
            string dropoutReason)
            : base(firstName, lastName, age, studentNum, averageGrade)
        {
            this.dropoutReason = dropoutReason;
        }

        public string DropoutReason
        {
            get { return dropoutReason; }
            set { this.dropoutReason = dropoutReason; }
        }

        public void Reapply()
        {
            Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\n" +
                "Student Number: {3}\nAverage Grade: {4}\nDropout Reason: {5}",
                FirstName, LastName,Age,StudentNum,AverageGrade,DropoutReason);
        }
    }

    class SoftwareUniversityLearningSystem
    {
        static void Main()
        {
            Student Toshko = 
                new Student("Toshko", "Toshkov", 19, 456123, 5.12);
            DropoutStudent Pesho = 
                new DropoutStudent("Pesho", "Peshov", 30, 210012, 5.32, "WAT Program");
            CurrentStudent Marin = 
                new CurrentStudent("Marin", "Markov", 20, 945678, 5.33, "C++"); // Current Student
            OnsiteStudent Mariika = 
                new OnsiteStudent("Mariika", "Petrova", 29, 666555, 4.95, "JAVA", 12); //Current Student
            OnlineStudent Kiril = 
                new OnlineStudent("Kiril", "Kirilov", 35, 111222, 5.32, "C#"); //Current Student
            CurrentStudent Ivelina = 
                new CurrentStudent("Ivelina", "Lubenova", 26, 232399, 5.89, "C"); // Current Student
            GraduateStudent Gosho = 
                new GraduateStudent("Gosho", "Goshow", 25, 456789, 4.59);
            CurrentStudent Svetlio = 
                new CurrentStudent("Svetlio", "Petrov", 22, 998899, 4.66, "JavaScript"); // Current Student
            Trainer Petq = 
                new Trainer("Petq", "Georgieva", 24);
            JuniorTrainer Ivanka = 
                new JuniorTrainer("Ivanka", "Ivanova", 40);
            CurrentStudent Dimitrichka = 
                new CurrentStudent("Dimitrichka", "Marcheva", 35, 203059, 4.50, "HTML5&CCS3"); // Current Student
            SeniorTrainer Angel = 
                new SeniorTrainer("Angel", "Angelov", 31);
            CurrentStudent Ivko = 
                new CurrentStudent("Ivko", "Kirilkov", 29, 990009, 4.98, "PHP"); // Current Student

            List<Person> peopleList = 
                new List<Person>(){Toshko,Pesho,Marin,Mariika, Kiril, Ivelina, Gosho, Svetlio, Petq, Ivanka, Dimitrichka, Angel, Ivko};


            peopleList.Where(p => p is CurrentStudent).
                OrderBy(p => ((CurrentStudent)p).AverageGrade).Reverse().ToList().
                ForEach(p => Console.WriteLine(((CurrentStudent)p).ToString()));
 
        }
    }
}
