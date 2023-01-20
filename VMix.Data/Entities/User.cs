﻿namespace VMix.Data.Entities;

[Table("Users")]
public class User : BaseEntity
{
    [Required]
    [MaxLength(32)]
    public string fullName { get; set; }
    public string userName { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public string passwordHash { get; set; }
    public string token { get; set; }
    public string? qrToken { get; set; }
    public string? profilePicture { get; set; }
    public int? roleId { get; set; }
    public Guid refreshToken { get; set; }
    public DateTime? expiresInMinutes { get; set; }
    public DateTime? lastLoginDate { get; set; }
    public DateTime? firstLoginDate { get; set; }
}