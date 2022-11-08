namespace TelecomNevaService.Desktop.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("UserPassportData")]
public partial class UserPassportData
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public UserPassportData()
    {
        UserInfo = new HashSet<UserInfo>();
    }

    public int ID { get; set; }

    public short PassportSerialNumber { get; set; }

    public int PassportNumber { get; set; }

    [Column(TypeName = "ntext")]
    [Required]
    public string ResidenceAddress { get; set; }

    public int PassportGivingInfoID { get; set; }

    public virtual PassportGivingInfo PassportGivingInfo { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<UserInfo> UserInfo { get; set; }
}
