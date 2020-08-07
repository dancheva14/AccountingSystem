using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AccountingSystem.Database.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Display(Name = "Наименование")]
        public string Name { get; set; }

        [Display(Name = "Наименование на чужд език")]
        public string NameInOtherLanguage { get; set; }

        [Display(Name = "Код")]
        public string Code { get; set; }

        [Display(Name = "Мярка")]
        public string Meaasure { get; set; }

        [Display(Name = "Продажна цена")]
        public decimal SalePrice { get; set; }

        [Display(Name = "Фиксирана цена")]
        public decimal FixedPrice { get; set; }

        [Display(Name = "ДДС група")]
        public VatRate VatRate { get; set; }

    }
}
