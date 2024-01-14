﻿using TezAPI.Domain.Entities.Common;

namespace TezAPI.Domain.Entities;

public class File : BaseEntity
{
    public string FileName { get; set; }
    public string Path { get; set; }
    public string Storage { get; set; }
}
