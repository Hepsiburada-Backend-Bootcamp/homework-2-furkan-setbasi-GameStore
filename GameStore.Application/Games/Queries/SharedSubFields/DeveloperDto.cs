﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Games.Queries.SharedSubFields
{
  public class DeveloperDto
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
  }
}
