using System;
using System.Collections.Generic;

namespace CrudStudents.Data;

public partial class Student
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int Age { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Clan { get; set; } = null!;

    public string Leader { get; set; } = null!;

    public string Language { get; set; } = null!;
}
