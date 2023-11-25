namespace App20231125.DataModels
{
    public class Book2Shelf
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int ShelfId { get; set; }
        public Shelf Shelf { get; set; }
    }
}
