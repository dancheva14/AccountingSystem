using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AccountingSystem.Database.Models
{
    public class DocumentDetail
    {
        public int Id { get; set; }

        [Display(Name = "Количество")]
        public decimal Qtty { get; set; }

        [Display(Name = "Продажна цена")]
        public decimal SalePrice { get; set; }

        [Display(Name = "Фиксирана цена")]
        public decimal FixedPrice { get; set; }

        [Display(Name = "Мярка")]
        public string Measure { get; set; }

        public decimal RowSum { get; set; }

        public decimal RowVat { get; set; }

        [Display(Name = "Основание")]
        public string Reference { get; set; }

        public int DocumentId { get; set; }

        public Item Item { get; set; }

        public Document Document { get; set; }
    }
}
