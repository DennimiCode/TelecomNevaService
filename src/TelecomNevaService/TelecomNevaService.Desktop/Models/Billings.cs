namespace TelecomNevaService.Desktop.Models;

using System;
using System.ComponentModel.DataAnnotations.Schema;

public partial class Billings
{
    public int ID { get; set; }

    [Column(TypeName = "date")]
    public DateTime PaymentDate { get; set; }

    public decimal PaymentSum { get; set; }

    public decimal ClientBalance { get; set; }

    [Column(TypeName = "date")]
    public DateTime BalanceDate { get; set; }

    public decimal ClientDebt { get; set; }

    public int UserID { get; set; }

    public virtual User User { get; set; }
}
