using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AccountingSystem.Database.Models
{
    public class VatRate
    {
        public int Id { get; set; }

        [Display(Name = "Код")]
        public string Code { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Процент")]
        public decimal Rate { get; set; }

    }
}
