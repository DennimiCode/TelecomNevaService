namespace TelecomNevaService.Desktop.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("BaseStationLocation")]
public partial class BaseStationLocation
{
    public int ID { get; set; }

    public int BaseStationID { get; set; }

    public int DistrictID { get; set; }

    [Column(TypeName = "ntext")]
    [Required]
    public string PlatformAddress { get; set; }

    [Column(TypeName = "ntext")]
    [Required]
    public string LocationPlace { get; set; }

    public virtual BaseStation BaseStation { get; set; }

    public virtual District District { get; set; }
}
