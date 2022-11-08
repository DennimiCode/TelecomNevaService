namespace TelecomNevaService.Authorization.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ContractInfo")]
public partial class ContractInfo
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ContractInfo()
    {
        ClientComboRate = new HashSet<ClientComboRate>();
        ClientRate = new HashSet<ClientRate>();
        UserService = new HashSet<UserService>();
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int PersonalAccountNumber { get; set; }

    public int UserID { get; set; }

    [Required]
    [StringLength(300)]
    public string ContractNumber { get; set; }

    [Column(TypeName = "date")]
    public DateTime ConclusionDate { get; set; }

    public bool ContractType { get; set; }

    public int? ContractTerminationReasonID { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ContractTerminationDate { get; set; }

    public int EquipmentID { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ClientComboRate> ClientComboRate { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ClientRate> ClientRate { get; set; }

    public virtual ContractTerminationReason ContractTerminationReason { get; set; }

    public virtual UserInfo UserInfo { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<UserService> UserService { get; set; }
}
