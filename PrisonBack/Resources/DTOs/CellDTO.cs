﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Resources
{
    public class CellDTO
    {
        [Required(ErrorMessage = "Ilość łóżek jest wymagana!")]
        public int BedsCount { get; set; }

        [Required(ErrorMessage = "Typ celi jest wymagany")]
        public int IdCellType { get; set; }

        [Required(ErrorMessage = "Numer celi jest wymagany")]
        public string CellNumber { get; set; }
        
    }
}
