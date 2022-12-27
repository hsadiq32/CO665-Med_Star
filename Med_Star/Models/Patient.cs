namespace Med_Star.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Appointment> GetAppointments()
        {
            return Appointments;
        }

        public void AddAppointment(Appointment appointment)
        {
            // add the appointment to the Appointments list
        }

        public void RemoveAppointment(int id)
        {
            // remove the appointment with the specified id from the Appointments list
        }
    }
}
