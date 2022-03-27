using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Singularity_Test.ViewModels
{
    public class StudentInfoViewModel
    {
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        public string Address { get; set; }
    }
}
