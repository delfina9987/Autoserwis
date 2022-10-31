using System.ComponentModel.DataAnnotations;

namespace Autoserwis.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public int CustomerPhoneNr { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerCarRegistration { get; set; }
        public string CustomerCarMark { get; set; }
        public string CustomerCarModel { get; set; }
        public string CustomerCarCapitality { get; set; }
        public string CustomerCarProductionYear { get; set; }
        public string CustomerCarEngine { get; set; }
        public string CustomerCarVIN { get; set; }
        public string CustomerCarMileage { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime CustomerCarDateDayTime { get; set; }
        
        public Service CustomerService { get; set; }
        public Status CustomerStatus { get; set; }
    }

    public enum Service
    {
        PRZEGLĄD_SERWISOWY,
        PRZEGLĄD_OKRESOWY_WEDŁUG_CZYNNOŚCI_KARTY_PRZEGLĄDOWEJ_PO_KONKRETNYM_PRZEBIEGU_LUB_COROCZNY,
        WYMIANA_ROZRZĄDU,
        WYMIANA_SPRZĘGŁA,
        NAPRAWA_ELEMENTÓW_ZAWIESZENIA,
        NAPRAWA_PODZESPOŁÓW_ELEKTRYCZNYCH,
        WYMIANA_OPON,
        WYMIANA_KLOCKÓW_HAMULCOWYCH_LUB_TARCZ,
        WYMIANA_OLEJU,
        NAPRAWA_BLACHARSKO_LAKIERNICZA,
        INNE_USTERKI
    }

    public enum Status
    {
        Niezaakceptowany,
        Zaakceptowany
    }
}
