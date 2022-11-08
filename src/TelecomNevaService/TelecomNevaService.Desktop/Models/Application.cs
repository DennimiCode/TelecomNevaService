namespace TelecomNevaService.Desktop.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Application")]
public partial class Application
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Application()
    {
        EmployeeReportCard = new HashSet<EmployeeReportCard>();
    }

    public int ID { get; set; }

    [Column(TypeName = "date")]
    public DateTime CreationDate { get; set; }

    public int UserID { get; set; }

    public int ServiceID { get; set; }

    public int ApplicationTypeID { get; set; }

    public int ApplicationSubtypeID { get; set; }

    public int ApplicationStatusID { get; set; }

    public int EquipmentTypeID { get; set; }

    [Column(TypeName = "ntext")]
    public string IssueDescribtion { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ClosingDate { get; set; }

    public int IssueTypeID { get; set; }

    public virtual ApplicationStatus ApplicationStatus { get; set; }

    public virtual ApplicationSubtype ApplicationSubtype { get; set; }

    public virtual ApplicationType ApplicationType { get; set; }

    public virtual EquipmentType EquipmentType { get; set; }

    public virtual IssueType IssueType { get; set; }

    public virtual Service Service { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<EmployeeReportCard> EmployeeReportCard { get; set; }
}
