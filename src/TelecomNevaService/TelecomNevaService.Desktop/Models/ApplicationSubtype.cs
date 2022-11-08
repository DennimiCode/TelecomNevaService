namespace TelecomNevaService.Desktop.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ApplicationSubtype")]
public partial class ApplicationSubtype
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ApplicationSubtype()
    {
        Application = new HashSet<Application>();
    }

    public int ID { get; set; }

    [Required]
    [StringLength(300)]
    public string Name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Application> Application { get; set; }
}
