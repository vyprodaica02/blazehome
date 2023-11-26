namespace TodoList.Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime NgaySinh { get; set; }
    }
}
