namespace HomeWorkDelegate.Entities
{
    internal class Book
    {
        public Guid Id { get; set; }    
        public string Name { get; set; }    
        public string  AuthorName { get; set; } 
        public int PageCount { get; set; }  
    }
}
