using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrisonBack.Resources.DTOs
{
    public class EditIsolationDTO
    {
        [Required(ErrorMessage = "Data zakończenia jest wymagana")]
        public DateTime EndDate { get; set; }
    }
}
