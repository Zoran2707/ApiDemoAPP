using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ApiDemoWithTimCory.Models
{
    public class Suplier
    {
        [Key]
       public int SupplierID { get; set; }
        [Required]
       public string CompanyName { get; set; }
       public string? ContactName { get; set; }
       public string? ContactTitle { get; set; }
       public string? Address { get; set; }
       public string? City { get; set; }
       public string? Region { get; set; }
       public string? PostalCode { get; set; }
       public string? Country { get; set; }
       public string? Phone { get; set; }
       public string? Fax { get; set; }
       public string? HomePage { get; set; }
    }
}
