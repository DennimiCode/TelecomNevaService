namespace TelecomNevaService.Authorization.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("District")]
public partial class District
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public District()
    {
        BaseStationLocation = new HashSet<BaseStationLocation>();
    }

    public int ID { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    public decimal Area { get; set; }

    public int Population { get; set; }

    public byte SubwayStationsCount { get; set; }

    public int BuildingTypeID { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<BaseStationLocation> BaseStationLocation { get; set; }

    public virtual BuildingType BuildingType { get; set; }
}
