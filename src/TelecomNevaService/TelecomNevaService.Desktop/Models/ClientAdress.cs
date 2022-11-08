namespace TelecomNevaService.Desktop.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ClientAdress")]
public partial class ClientAdress
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ClientAdress()
    {
        ClientEquipment = new HashSet<ClientEquipment>();
    }

    [Key]
    [StringLength(100)]
    public string Adress { get; set; }

    public int UserInfoID { get; set; }

    public virtual UserInfo UserInfo { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ClientEquipment> ClientEquipment { get; set; }
}
