﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TezAPI.Application.DTOs;

public class AddAllergy
{
    //public Guid UserId { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
}
