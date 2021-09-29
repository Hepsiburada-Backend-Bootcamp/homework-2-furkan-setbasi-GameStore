﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Domain.Entities
{
  public class Game
  {
    public Guid Id { get; set; }
    public string Name { get; set; }

    public int Price { get; set; }
    public Category Category { get; set; }
    public Developer Developer { get; set; }
  }
}