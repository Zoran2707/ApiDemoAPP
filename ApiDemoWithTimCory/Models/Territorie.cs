using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiDemoWithTimCory.Models
{
    public class Territorie
    {
        [Key]
        public string TerritoryID { get; set; }
        [Required]
        public string TerritoryDescription { get; set; }

        [Required]
        public int RegionID { get; set; }

       
        //public  virtual Region Region { get; }



        

    }
}
