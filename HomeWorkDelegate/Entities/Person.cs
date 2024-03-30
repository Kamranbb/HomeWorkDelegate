

namespace HomeWorkDelegate.Entities
{
    internal class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id {Id} Salary {Salary}";
        }
        //public override bool Equals(object? obj)
        //{
        //    if (obj == null|| obj is not Person) return false;
        //    Person person = obj as Person;
        //    return person.Name.Equals(Name);
        //}
        //public override int GetHashCode()
        //{
        //    return Name.GetHashCode();
        //}
    }
}
