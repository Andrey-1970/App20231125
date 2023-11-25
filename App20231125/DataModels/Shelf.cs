namespace App20231125.DataModels
{
    public class Shelf
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Book2Shelf> Book2Shelfs { get; set; }
        public int BookId { get; set; }
    }
}
