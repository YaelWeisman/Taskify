namespace Taskify.Entities
{
    public class Poject
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private DateTime DueDate { get; set; }
        private DateTime StartDate { get; set; }
        private int ManagerId { get; set; }
        private string Status { get; set; }

        public Poject(int Id, string Name, string Description, DateTime DueDate, DateTime StartDate, int ManagerId, string Status)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.DueDate = DueDate;
            this.StartDate = StartDate;
            this.ManagerId = ManagerId;
            this.Status = Status;
        }

    }
}
