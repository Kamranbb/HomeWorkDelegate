﻿using HomeWorkDelegate.Entities;

namespace HomeWorkDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Person person2 = new Person();
            person2.Id= Guid.NewGuid();  
            person2.Name = "Test";
            person2.Salary = 2384;
           Person person1 = new Person();
            person1.Id= Guid.NewGuid();
            person1.Name = "Test";
            person1.Salary = 1233;

            

            //List<Person> person = new List<Person>() {person2,person1};
            //foreach (var item in CalculateSalary(p=>p.Salary>1000&&p.Salary<2000,person))
            //{
            //    Console.WriteLine(item);
            //}

            //List<Person> CalculateSalary (Predicate<Person> predicate,List<Person> person)
            //{
            //    return person.FindAll(predicate);
            //}

            //Console.WriteLine(person.Equals(person1));
            //HashSet<Person> list = new HashSet<Person>();   
            //list.Add(person);
            //list.Add(person1);
            //Console.WriteLine(list.Count);
            #endregion
            #region Task2 
            Book book = new Book();
            book.Id = Guid.NewGuid();
            book.Name = "Test";
            book.AuthorName = "Nizami";
            Book book2 = new Book();    
            book2.Id = Guid.NewGuid();
            book2.Name = "Test1";
            book2.AuthorName = "Nizami";
            List<Book> books = new();
            books.Add(book);
            books.Add(book2);
            //Console.WriteLine(FindBooksOfNizami(b => b.AuthorName == "Nizami", books));

            //int FindBooksOfNizami (Predicate<Book> predicate,List<Book> list)
            //{
            //    return list.FindAll(predicate).Count;
            //}

            #endregion 
        }

    }
}
