namespace TelecomNevaService.Desktop.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("User")]
public partial class User
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public User()
    {
        Billings = new HashSet<Billings>();
        EmployeeReportCard = new HashSet<EmployeeReportCard>();
        EmployeeVacation = new HashSet<EmployeeVacation>();
    }

    public int ID { get; set; }

    [Required]
    [StringLength(100)]
    public string Login { get; set; }

    [Required]
    [StringLength(100)]
    public string Password { get; set; }

    public int UserRoleID { get; set; }

    public int UserInfoID { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Billings> Billings { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<EmployeeReportCard> EmployeeReportCard { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<EmployeeVacation> EmployeeVacation { get; set; }

    public virtual UserInfo UserInfo { get; set; }

    public virtual UserRole UserRole { get; set; }
}
