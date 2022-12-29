using System.ComponentModel.DataAnnotations;

namespace Med_Star.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public Person Person { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
    }

}
