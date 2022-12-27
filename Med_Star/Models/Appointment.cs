namespace Med_Star.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public string Description { get; set; }
        public AppointmentType Type { get; set; }

        public DateTime GetDate()
        {
            return Date;
        }

        public Doctor GetDoctor()
        {
            return Doctor;
        }

        public Patient GetPatient()
        {
            return Patient;
        }

        public string GetDescription()
        {
            return Description;
        }

        public AppointmentType GetType()
        {
            return Type;
        }

        public void SetDate(DateTime date)
        {
            Date = date;
        }

        public void SetDoctor(Doctor doctor)
        {
            Doctor = doctor;
        }

        public void SetPatient(Patient patient)
        {
            Patient = patient;
        }

        public void SetDescription(string description)
        {
            Description = description;
        }

        public void SetType(AppointmentType type)
        {
            Type = type;
        }
    }

    public enum AppointmentType
    {
        CHECKUP,
        SURGERY,
        CONSULTATION
    }
}

