using System.ComponentModel.DataAnnotations;

namespace ApiDemoWithTimCory.Models
{
    public class Region
    {
        [Key]
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
    }
}
