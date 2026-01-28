namespace todolist.Model
{
    public class TodoTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

       public TodoTask(int id, string title, bool isCompleted)
        {
            this.Id = id;
            this.Title = title;
            this.IsCompleted = isCompleted;
        }
    }
}
