namespace TelecomNevaService.Desktop.Models;

using System;
using System.ComponentModel.DataAnnotations.Schema;

[Table("EmployeeVacation")]
public partial class EmployeeVacation
{
    public int ID { get; set; }

    public int EmployeeID { get; set; }

    [Column(TypeName = "date")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime EndDate { get; set; }

    public virtual User User { get; set; }
}
