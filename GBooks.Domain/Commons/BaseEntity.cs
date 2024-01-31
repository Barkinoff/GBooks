﻿

namespace GBooks.Domain.Commons;

public class BaseEntity
{
    public long Id { get; set; }    

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
