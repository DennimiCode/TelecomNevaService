namespace TelecomNevaService.Desktop.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("UserInfo")]
public partial class UserInfo
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public UserInfo()
    {
        ClientAdress = new HashSet<ClientAdress>();
        ContractInfo = new HashSet<ContractInfo>();
        User = new HashSet<User>();
    }

    public int ID { get; set; }

    [Required]
    [StringLength(200)]
    public string FirstName { get; set; }

    [Required]
    [StringLength(300)]
    public string Surname { get; set; }

    [Required]
    [StringLength(100)]
    public string Patronymic { get; set; }

    public int GenderID { get; set; }

    [Column(TypeName = "date")]
    public DateTime BirthDate { get; set; }

    [Required]
    [StringLength(13)]
    public string PhoneNumber { get; set; }

    [Column(TypeName = "ntext")]
    [Required]
    public string UserEmail { get; set; }

    public int UserPassportDataID { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ClientAdress> ClientAdress { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ContractInfo> ContractInfo { get; set; }

    public virtual Gender Gender { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<User> User { get; set; }

    public virtual UserPassportData UserPassportData { get; set; }
}
