namespace Med_Star.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string County { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public ICollection<Doctor> Doctors { get; set; }

        public String GetDoctor(int id)
        {
            // return the doctor with the specified id
            return "Test";
        }

        public ICollection<Doctor> GetDoctors()
        {
            return Doctors;
        }

        public void AddDoctor(Doctor doctor)
        {
            // add the doctor to the Doctors list
        }

        public void RemoveDoctor(int id)
        {
            // remove the doctor with the specified id from the Doctors list
        }
    }
}
