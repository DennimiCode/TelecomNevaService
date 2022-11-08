namespace TelecomNevaService.Authorization.Models;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("StaffInfo")]
public partial class StaffInfo
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int ID { get; set; }

    public int UserRoleID { get; set; }

    [Column(TypeName = "ntext")]
    [Required]
    public string InfoText { get; set; }

    public DateTime EventDatetime { get; set; }

    public virtual UserRole UserRole { get; set; }
}
