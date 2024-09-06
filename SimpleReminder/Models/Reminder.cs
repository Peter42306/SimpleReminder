namespace SimpleReminder.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsValid { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
