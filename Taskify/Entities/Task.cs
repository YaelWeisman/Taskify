namespace Taskify.Entities
{
    public class Task
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private string Type { get; set; }
        private int ProjectID { get; set; }
        private int UserID { get; set; }
        private int Priority { get; set; }
        public Task(string Name, string Description, string Type, int ProjectID, int UserID, int Priority) { 
            this.Name = Name;
            this.Description = Description;
            this.Type = Type;
            this.ProjectID = ProjectID; 
            this.UserID = UserID;   
            this.Priority = Priority;    
        }
    }
}
