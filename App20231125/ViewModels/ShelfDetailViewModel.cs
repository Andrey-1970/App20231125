using App20231125.DataModels;

namespace App20231125.ViewModels
{
    public class ShelfDetailViewModel
    {
        public Shelf Shelf { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
