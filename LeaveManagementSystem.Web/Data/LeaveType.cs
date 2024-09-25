using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Web.Data
{
    public class LeaveType
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(150)")]

        public string Name { get; set; } // e.g. sick, vacation, etc

        public int NumberOfdays { get; set; } // e.g. vacation = 30, sick = 10 
    }
}
