namespace App20231125.DataModels
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Role> Roles { get; set; }

    }
}
