namespace TelecomNevaService.Desktop.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("BaseStation")]
public partial class BaseStation
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public BaseStation()
    {
        BaseStationLocation = new HashSet<BaseStationLocation>();
    }

    public int ID { get; set; }

    [Required]
    [StringLength(300)]
    public string Name { get; set; }

    public decimal CoverageArea { get; set; }

    public int Frequency { get; set; }

    public int AntennaTypeID { get; set; }

    public int StartHandoverIndicator { get; set; }

    public int EndHandoverIndicator { get; set; }

    public int WirelessCommunicationStandartID { get; set; }

    public virtual AntennaType AntennaType { get; set; }

    public virtual WirelessCommunicationStandart WirelessCommunicationStandart { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<BaseStationLocation> BaseStationLocation { get; set; }
}
