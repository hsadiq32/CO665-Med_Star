using Med_Star.Models;
using System.Diagnostics;

namespace Med_Star.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Appointment.Any())
            {
                return;   // DB has been seeded
            }

            var medStarBranches = new List<MedStarBranch>
        {
            new MedStarBranch { Name = "MedStar Branch 1" },
            new MedStarBranch { Name = "MedStar Branch 2" },
            new MedStarBranch { Name = "MedStar Branch 3" }
        };

            medStarBranches.ForEach(s => context.MedStarBranch.Add(s));
            context.SaveChanges();

            var doctors = new List<Doctor>
        {
            new Doctor { Name = "Dr. John Smith", Specialty = "General Practice", MedStarBranch = medStarBranches[0] },
            new Doctor { Name = "Dr. Jane Doe", Specialty = "Pediatrics", MedStarBranch = medStarBranches[0] },
            new Doctor { Name = "Dr. Michael Jordan", Specialty = "Orthopedics", MedStarBranch = medStarBranches[1] },
            new Doctor { Name = "Dr. Rachel Green", Specialty = "Dermatology", MedStarBranch = medStarBranches[1] },
            new Doctor { Name = "Dr. Tom Hanks", Specialty = "Cardiology", MedStarBranch = medStarBranches[2] },
            new Doctor { Name = "Dr. Emily Blunt", Specialty = "OB-GYN", MedStarBranch = medStarBranches[2] },
            new Doctor { Name = "Dr. Brad Pitt", Specialty = "Oncology", MedStarBranch = medStarBranches[0] },
            new Doctor { Name = "Dr. Angelina Jolie", Specialty = "Psychiatry", MedStarBranch = medStarBranches[1] },
            new Doctor { Name = "Dr. Morgan Freeman", Specialty = "Surgery", MedStarBranch = medStarBranches[2] },
            new Doctor { Name = "Dr. Meryl Streep", Specialty = "Internal Medicine", MedStarBranch = medStarBranches[0] }
        };

            doctors.ForEach(s => context.Doctor.Add(s));
            context.SaveChanges();


            var patients = new List<Patient>
        {
            new Patient { Name = "Alice Smith" },
            new Patient { Name = "Bob Johnson" },
            new Patient { Name = "Charlie Williams" },
            new Patient { Name = "Donna Brown" },
            new Patient { Name = "Emily Davis" },
            new Patient { Name = "Frank Thompson" },
            new Patient { Name = "Gina Rodriguez" },
            new Patient { Name = "Hannah Jackson" },
            new Patient { Name = "Ian Scott" },
            new Patient { Name = "Julia Taylor" },
            new Patient { Name = "Katie White" },
            new Patient { Name = "Laura Lee" },
            new Patient { Name = "Mike Davis" },
            new Patient { Name = "Nancy Anderson" },
            new Patient { Name = "Olivia Taylor" },
            new Patient { Name = "Patricia Johnson" },
            new Patient { Name = "Quincy Williams" },
            new Patient { Name = "Rachel Brown" },
            new Patient { Name = "Samuel Scott" },
            new Patient { Name = "Tara Thompson" },
            new Patient { Name = "Ursula Rodriguez" }
        };

            patients.ForEach(s => context.Patient.Add(s));
        context.SaveChanges();

            var appointments = new List<Appointment>
        {
            new Appointment { Date = DateTime.Parse("2022-01-01 10:00:00"), Doctor = doctors[0], Patient = patients[0], Description = "Annual checkup", Type = AppointmentType.CHECKUP },
            new Appointment { Date = DateTime.Parse("2022-01-02 11:00:00"), Doctor = doctors[1], Patient = patients[1], Description = "Sick visit", Type = AppointmentType.CONSULTATION },
            new Appointment { Date = DateTime.Parse("2022-01-03 12:00:00"), Doctor = doctors[2], Patient = patients[2], Description = "Broken bone", Type = AppointmentType.SURGERY },
            new Appointment { Date = DateTime.Parse("2022-01-04 13:00:00"), Doctor = doctors[3], Patient = patients[3], Description = "Acne treatment", Type = AppointmentType.CONSULTATION },
            new Appointment { Date = DateTime.Parse("2022-01-05 14:00:00"), Doctor = doctors[4], Patient = patients[4], Description = "Heart attack follow-up", Type = AppointmentType.CHECKUP },
            new Appointment { Date = DateTime.Parse("2022-01-06 15:00:00"), Doctor = doctors[5], Patient = patients[5], Description = "Pregnancy checkup", Type = AppointmentType.CHECKUP },
            new Appointment { Date = DateTime.Parse("2022-01-07 16:00:00"), Doctor = doctors[6], Patient = patients[6], Description = "Cancer treatment", Type = AppointmentType.SURGERY },
            new Appointment { Date = DateTime.Parse("2022-01-08 17:00:00"), Doctor = doctors[7], Patient = patients[7], Description = "Depression therapy", Type = AppointmentType.CONSULTATION },
            new Appointment { Date = DateTime.Parse("2022-01-09 18:00:00"), Doctor = doctors[8], Patient = patients[8], Description = "Appendectomy", Type = AppointmentType.SURGERY },
            new Appointment { Date = DateTime.Parse("2022-01-10 19:00:00"), Doctor = doctors[9], Patient = patients[9], Description = "Flu shot", Type = AppointmentType.CHECKUP },
            new Appointment { Date = DateTime.Parse("2022-01-14 13:00:00"), Doctor = doctors[3], Patient = patients[13], Description = "Acne treatment", Type = AppointmentType.CONSULTATION },
            new Appointment { Date = DateTime.Parse("2022-01-15 14:00:00"), Doctor = doctors[4], Patient = patients[14], Description = "Heart attack follow-up", Type = AppointmentType.CHECKUP },
            new Appointment { Date = DateTime.Parse("2022-01-16 15:00:00"), Doctor = doctors[5], Patient = patients[15], Description = "Pregnancy checkup", Type = AppointmentType.CHECKUP },
            new Appointment { Date = DateTime.Parse("2022-01-17 16:00:00"), Doctor = doctors[6], Patient = patients[16], Description = "Cancer treatment", Type = AppointmentType.SURGERY },
            new Appointment { Date = DateTime.Parse("2022-01-18 17:00:00"), Doctor = doctors[7], Patient = patients[17], Description = "Depression therapy", Type = AppointmentType.CONSULTATION },
            new Appointment { Date = DateTime.Parse("2022-01-19 18:00:00"), Doctor = doctors[8], Patient = patients[18], Description = "Appendectomy", Type = AppointmentType.SURGERY },
            new Appointment { Date = DateTime.Parse("2022-01-20 19:00:00"), Doctor = doctors[9], Patient = patients[19], Description = "Flu shot", Type = AppointmentType.CHECKUP }
        };
            appointments.ForEach(s => context.Appointment.Add(s));
            context.SaveChanges();
        }
    }
}
