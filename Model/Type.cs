﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Raktar
{
    public class Type
    {
        //Adattagok
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
