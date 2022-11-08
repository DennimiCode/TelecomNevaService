namespace TelecomNevaService.Desktop.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("HighwayEquipment")]
public partial class HighwayEquipment
{
    public int ID { get; set; }

    public int EquipmentID { get; set; }

    public int Frequency { get; set; }

    public int? AttenuationCoefficient { get; set; }

    public int DataTransmissionTechnologyID { get; set; }

    [Column(TypeName = "ntext")]
    [Required]
    public string Location { get; set; }

    public virtual DataTransmissionTechnolony DataTransmissionTechnolony { get; set; }

    public virtual Equipment Equipment { get; set; }
}
