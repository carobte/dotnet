using System;
using System.Collections.Generic;

namespace CrudStudents.Data;

public partial class DocumentType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public string? Description { get; set; }
}
