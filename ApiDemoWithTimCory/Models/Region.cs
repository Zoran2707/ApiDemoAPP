using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiDemoWithTimCory.Models
{
    public class Region
    {
        [Key]
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }

        
        [ForeignKey("RegionID")]
        public ICollection<Territorie> territories { get; set; }
    }
}
