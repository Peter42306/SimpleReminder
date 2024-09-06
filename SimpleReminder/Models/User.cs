namespace SimpleReminder.Models
{
    public class User
    {
        public User()
        {
            this.Reminders=new HashSet<Reminder>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public ICollection<Reminder> Reminders { get; set; }
    }
}
