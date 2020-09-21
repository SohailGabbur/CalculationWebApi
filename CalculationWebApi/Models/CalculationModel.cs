using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CalculationWebApi.Models
{
    public class CalculationModel
    {
        [Required(ErrorMessage ="Please enter the number")]
        public int Num1 { get; set; }
        [Required(ErrorMessage ="Please enter the number")]
        public int Num2 { get; set; }
    }
}