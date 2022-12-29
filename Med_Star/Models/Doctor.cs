using System.ComponentModel.DataAnnotations;

namespace Med_Star.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public Person Person { get; set; }
        public Specialty Specialty { get; set; }
        public Branch Branch { get; set; }

    }

    public enum Specialty
    {
        Pediatrics,
        InternalMedicine,
        Cardiology,
        Orthopedics,
        Dermatology,
        Neurology,
        Oncology,
        Ophthalmology,
        Gastroenterology,
        Endocrinology,
        Rheumatology,
        Urology,
        Anesthesiology,
        Gynecology,
        FamilyMedicine,
        Psychiatry,
        Rehabilitation,
        Pulmonology
    }
}