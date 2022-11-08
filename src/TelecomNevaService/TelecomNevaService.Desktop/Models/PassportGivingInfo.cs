namespace TelecomNevaService.Desktop.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("PassportGivingInfo")]
public partial class PassportGivingInfo
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PassportGivingInfo()
    {
        UserPassportData = new HashSet<UserPassportData>();
    }

    public int ID { get; set; }

    [Required]
    [StringLength(10)]
    public string DivisionCode { get; set; }

    [Column(TypeName = "ntext")]
    [Required]
    public string GivingPlace { get; set; }

    [Column(TypeName = "date")]
    public DateTime GivingDate { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<UserPassportData> UserPassportData { get; set; }
}
