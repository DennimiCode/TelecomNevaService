using System;

namespace TelecomNevaService.Desktop.Models;

public record UserRecord
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    public string FullName { get; set; }
    public DateTime BirthDate { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public int UserRoleId { get; set; }
}
