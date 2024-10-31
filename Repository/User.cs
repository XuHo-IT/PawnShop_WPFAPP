using System;
using System.Collections.Generic;

namespace Repository;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? UserRealName { get; set; }

    public string? EmailAddress { get; set; }

    public bool Gender { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Address { get; set; }

    public string? Telephone { get; set; }

    public string? Cid { get; set; }

    public byte? UserRole { get; set; }
}
