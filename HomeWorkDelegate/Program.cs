using HomeWorkDelegate.Entities;

namespace HomeWorkDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person2 = new Person();
            person2.Id= Guid.NewGuid();  
            person2.Name = "Test";
            person2.Salary = 2384;
           Person person1 = new Person();
            person1.Id= Guid.NewGuid();
            person1.Name = "Test";
            person1.Salary = 1233;

            

            List<Person> person = new List<Person>() {person2,person1};
            foreach (var item in CalculateSalary(p=>p.Salary>1000&&p.Salary<2000,person))
            {
                Console.WriteLine(item);
            }

            List<Person> CalculateSalary (Predicate<Person> predicate,List<Person> person)
            {
                return person.FindAll(predicate);
            }















            //Console.WriteLine(person.Equals(person1));
            //HashSet<Person> list = new HashSet<Person>();   
            //list.Add(person);
            //list.Add(person1);
            //Console.WriteLine(list.Count);
        }

    }
}
