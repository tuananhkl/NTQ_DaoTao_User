using System.ComponentModel.DataAnnotations;

namespace User.Domain.Entities;

public class Group
{
    [Key] public int Id { get; set; }
    public string GroupName { get; set; } = null!;
    public bool Status { get; set; }
}