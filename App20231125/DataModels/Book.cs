namespace App20231125.DataModels
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<Book2Shelf> Book2Shelfs { get; set; }
        public int ShelfId { get; set; }
    }
}
