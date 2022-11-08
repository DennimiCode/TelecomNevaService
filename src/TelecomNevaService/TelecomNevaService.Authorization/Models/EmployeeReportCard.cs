namespace TelecomNevaService.Authorization.Models;

using System;
using System.ComponentModel.DataAnnotations.Schema;

[Table("EmployeeReportCard")]
public partial class EmployeeReportCard
{
    public int ID { get; set; }

    public int EmployeeID { get; set; }

    [Column(TypeName = "date")]
    public DateTime Date { get; set; }

    public int ApplicationID { get; set; }

    public bool IsWeekend { get; set; }

    public virtual Application Application { get; set; }

    public virtual User User { get; set; }
}
