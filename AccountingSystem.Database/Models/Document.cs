using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AccountingSystem.Database
{
    public class Document
    {
        public int Id { get; set; }

        [Display(Name = "Номер на документа")]
        public string DocNumber { get; set; }

        [Display(Name = "Дата на издаване")]
        public DateTime Date { get; set; }

        [Display(Name = "Получател")]
        public string Recipient { get; set; }

        [Display(Name = "Подател")]
        public string Publisher { get; set; }

        [Display(Name = "Дата на сделката")]
        public DateTime DealDate { get; set; }

        [Display(Name = "Данъчна основа")]
        public decimal DocumentSum { get; set; }

        [Display(Name = "Общо")]
        public decimal DocumentTotal { get; set; }

        [Display(Name = "ДДС")]
        public decimal DocumentVat { get; set; }

        [Display(Name = "Тип на документа")]
        public DocumentType DocumentType { get; set; }

        [Display(Name = "Партньор")]
        public Partner Partner { get; set; }

        [Display(Name = "Тип на плащане")]
        public PaymentType PaymentType { get; set; }

        public User User { get; set; }

        [Display(Name = "Банкова сметка")]
        public BankAccount BankAccount { get; set; }

        public List<DocumentType> DocumentTypes { get; set; }

    }
}
