using Med_Star.Models;
using Microsoft.AspNetCore.Identity;


namespace Med_Star.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            // Look for any branches
            if (context.Branch.Any())
            {
                return;   // DB has been seeded
            }

            // Create three branches
            var branches = new Branch[]
            {
            new Branch{Name="Liverpool", County="Merseyside", Address="123 Main St", Postcode="L1 1AA"},
            new Branch{Name="Manchester", County="Greater Manchester", Address="456 Second Ave", Postcode="M1 2BB"},
            new Branch{Name="Leeds", County="West Yorkshire", Address="789 Third St", Postcode="LS3 4CC"}
            };
            foreach (Branch b in branches)
            {
                context.Branch.Add(b);
            }
            context.SaveChanges();

            // Create 35 persons (ASP.NET identity users)
            var persons = new Person[]
            {
            new Person{FirstName="John", LastName="Smith", DoB=DateTime.Parse("1990-01-01"), Gender=Gender.Male, Email="john@example.com", UserName="john@example.com"},
            new Person{FirstName="Jane", LastName="Doe", DoB=DateTime.Parse("1995-01-01"), Gender=Gender.Female, Email="jane@example.com", UserName="jane@example.com"},
            new Person{FirstName="Bob", LastName="Johnson", DoB=DateTime.Parse("1985-01-01"), Gender=Gender.Male, Email="bob@example.com", UserName="bob@example.com"},
            new Person{FirstName="Sally", LastName="Smith", DoB=DateTime.Parse("1980-01-01"), Gender=Gender.Female, Email="sally@example.com", UserName="sally@example.com"},
            new Person{FirstName="Tom", LastName="Jones", DoB=DateTime.Parse("1995-01-01"), Gender=Gender.Male, Email="tom@example.com", UserName="tom@example.com"},
            new Person{FirstName="Emily", LastName="Williams", DoB=DateTime.Parse("1992-01-01"), Gender=Gender.Female, Email="emily@example.com", UserName="emily@example.com"},
            new Person{FirstName="David", LastName="Brown", DoB=DateTime.Parse("1988-01-01"), Gender=Gender.Male, Email="david@example.com", UserName="david@example.com"},
            new Person{FirstName="Jessica", LastName="Jones", DoB=DateTime.Parse("1981-01-01"), Gender=Gender.Female, Email="jessica@example.com", UserName="jessica@example.com"},
            new Person{FirstName="James", LastName="Smith", DoB=DateTime.Parse("1995-01-01"), Gender=Gender.Male, Email="james@example.com", UserName="james@example.com"},
            new Person{FirstName="Emma", LastName="Williams", DoB=DateTime.Parse("1990-01-01"), Gender=Gender.Female, Email="emma@example.com", UserName="emma@example.com"},
            new Person{FirstName="Michael", LastName="Johnson", DoB=DateTime.Parse("1987-01-01"), Gender=Gender.Male, Email="michael@example.com", UserName="michael@example.com"},
            new Person{FirstName="Samantha", LastName="Smith", DoB=DateTime.Parse("1982-01-01"), Gender=Gender.Female, Email="samantha@example.com", UserName="samantha@example.com"},
            new Person{FirstName="Christopher", LastName="Jones", DoB=DateTime.Parse("1995-01-01"), Gender=Gender.Male, Email="christopher@example.com", UserName="christopher@example.com"},
            new Person{FirstName="Ashley", LastName="Williams", DoB=DateTime.Parse("1991-01-01"), Gender=Gender.Female, Email="ashley@example.com", UserName="ashley@example.com"},
            new Person{FirstName="Matthew", LastName="Brown", DoB=DateTime.Parse("1989-01-01"), Gender=Gender.Male, Email="matthew@example.com", UserName="matthew@example.com"},
            new Person{FirstName="Megan", LastName="Jones", DoB=DateTime.Parse("1983-01-01"), Gender=Gender.Female, Email="megan@example.com", UserName="megan@example.com"},
            new Person{FirstName="Andrew", LastName="Smith", DoB=DateTime.Parse("1996-01-01"), Gender=Gender.Male, Email="andrew@example.com", UserName="andrew@example.com"},
            new Person{FirstName="Amanda", LastName="Williams", DoB=DateTime.Parse("1992-01-01"), Gender=Gender.Female, Email="amanda@example.com", UserName="amanda@example.com"},
            new Person{FirstName="Robert", LastName="Johnson", DoB=DateTime.Parse("1988-01-01"), Gender=Gender.Male, Email="robert@example.com", UserName="robert@example.com"},
            new Person{FirstName="Sarah", LastName="Smith", DoB=DateTime.Parse("1981-01-01"), Gender=Gender.Female, Email="sarah@example.com", UserName="sarah@example.com"},
            new Person{FirstName="Richard", LastName="Jones", DoB=DateTime.Parse("1995-01-01"), Gender=Gender.Male, Email="richard@example.com", UserName="richard@example.com"},
            new Person{FirstName="Rachel", LastName="Williams", DoB=DateTime.Parse("1990-01-01"), Gender=Gender.Female, Email="rachel@example.com", UserName="rachel@example.com"},
            new Person{FirstName="Jonathan", LastName="Brown", DoB=DateTime.Parse("1987-01-01"), Gender=Gender.Male, Email="jonathan@example.com", UserName="jonathan@example.com"},
            new Person{FirstName="Rebecca", LastName="Jones", DoB=DateTime.Parse("1982-01-01"), Gender=Gender.Female, Email="rebecca@example.com", UserName="rebecca@example.com"},
            new Person{FirstName="Kevin", LastName="Smith", DoB=DateTime.Parse("1996-01-01"), Gender=Gender.Male, Email="kevin@example.com", UserName="kevin@example.com"},
            new Person{FirstName="Melissa", LastName="Williams", DoB=DateTime.Parse("1991-01-01"), Gender=Gender.Female, Email="melissa@example.com", UserName="melissa@example.com"},
            new Person{FirstName="William", LastName="Johnson", DoB=DateTime.Parse("1989-01-01"), Gender=Gender.Male, Email="william@example.com", UserName="william@example.com"},
            new Person{FirstName="Nicole", LastName="Smith", DoB=DateTime.Parse("1983-01-01"), Gender=Gender.Female, Email="nicole@example.com", UserName="nicole@example.com"},
            new Person{FirstName="Daniel", LastName="Jones", DoB=DateTime.Parse("1995-01-01"), Gender=Gender.Male, Email="daniel@example.com", UserName="daniel@example.com"},
            new Person{FirstName="Ashley", LastName="Williams", DoB=DateTime.Parse("1993-01-01"), Gender=Gender.Female, Email="ashley@example.com", UserName="ashley@example.com"},
            new Person{FirstName="Jason", LastName="Brown", DoB=DateTime.Parse("1987-01-01"), Gender=Gender.Male, Email="jason@example.com", UserName="jason@example.com"},
            new Person{FirstName="Stephanie", LastName="Jones", DoB=DateTime.Parse("1983-01-01"), Gender=Gender.Female, Email="stephanie@example.com", UserName="stephanie@example.com"},
            new Person{FirstName="Eric", LastName="Smith", DoB=DateTime.Parse("1995-01-01"), Gender=Gender.Male, Email="eric@example.com", UserName="eric@example.com"},
            new Person{FirstName="Jessica", LastName="Williams", DoB=DateTime.Parse("1991-01-01"), Gender=Gender.Female, Email="jessica@example.com", UserName="jessica@example.com"},
            new Person{FirstName="Stephen", LastName="Johnson", DoB=DateTime.Parse("1989-01-01"), Gender=Gender.Male, Email="stephen@example.com", UserName="stephen@example.com"},
            new Person{FirstName="Laura", LastName="Smith", DoB=DateTime.Parse("1983-01-01"), Gender=Gender.Female, Email="laura@example.com", UserName="laura@example.com"},
            new Person{FirstName="Mark", LastName="Jones", DoB=DateTime.Parse("1996-01-01"), Gender=Gender.Male, Email="mark@example.com", UserName="mark@example.com"},
            new Person{FirstName="Jennifer", LastName="Williams", DoB=DateTime.Parse("1992-01-01"), Gender=Gender.Female, Email="jennifer@example.com", UserName="jennifer@example.com"}
            };
            foreach (Person p in persons)
            {
                context.Person.Add(p);
            }
            context.SaveChanges();

            // Create ten doctors
            var doctors = new Doctor[]
            {
            new Doctor{Person=persons[0], Specialty=Specialty.InternalMedicine, Branch=branches[0]},
            new Doctor{Person=persons[1], Specialty=Specialty.Pediatrics, Branch=branches[0]},
            new Doctor{Person=persons[2], Specialty=Specialty.Cardiology, Branch=branches[1]},
            new Doctor{Person=persons[3], Specialty=Specialty.Orthopedics, Branch=branches[1]},
            new Doctor{Person=persons[4], Specialty=Specialty.Dermatology, Branch=branches[2]},
            new Doctor{Person=persons[5], Specialty=Specialty.Neurology, Branch=branches[2]},
            new Doctor{Person=persons[6], Specialty=Specialty.Oncology, Branch=branches[0]},
            new Doctor{Person=persons[7], Specialty=Specialty.Ophthalmology, Branch=branches[1]},
            new Doctor{Person=persons[8], Specialty=Specialty.Gastroenterology, Branch=branches[2]},
            new Doctor{Person=persons[9], Specialty=Specialty.Endocrinology, Branch=branches[0]}
            };
            foreach (Doctor d in doctors)
            {
                context.Doctor.Add(d);
            }
            context.SaveChanges();

            // Create 25 patients
            var patients = new Patient[]
            {
            new Patient{Person=persons[10], County="Merseyside", Address="123 Main St", Postcode="L1 1AA"},
            new Patient{Person=persons[11], County="Greater Manchester", Address="456 Second Ave", Postcode="M1 2BB"},
            new Patient{Person=persons[12], County="West Yorkshire", Address="789 Third St", Postcode="LS3 4CC"},
            new Patient{Person=persons[13], County="Merseyside", Address="456 Fourth Ave", Postcode="L1 5DD"},
            new Patient{Person=persons[14], County="Greater Manchester", Address="789 Fifth St", Postcode="M1 6EE"},
            new Patient{Person=persons[15], County="West Yorkshire", Address="123 Sixth Ave", Postcode="LS3 7FF"},
            new Patient{Person=persons[16], County="Merseyside", Address="789 Seventh St", Postcode="L1 8GG"},
            new Patient{Person=persons[17], County="Greater Manchester", Address="123 Eighth Ave", Postcode="M1 9HH"},
            new Patient{Person=persons[18], County="West Yorkshire", Address="456 Ninth St", Postcode="LS3 0II"},
            new Patient{Person=persons[19], County="Merseyside", Address="789 Tenth Ave", Postcode="L1 1JJ"},
            new Patient{Person=persons[20], County="Greater Manchester", Address="123 Eleventh St", Postcode="M1 2KK"},
            new Patient{Person=persons[21], County="West Yorkshire", Address="456 Twelfth Ave", Postcode="LS3 3LL"},
            new Patient{Person=persons[22], County="Merseyside", Address="789 Thirteenth St", Postcode="L1 4MM"},
            new Patient{Person=persons[23], County="Greater Manchester", Address="123 Fourteenth Ave", Postcode="M1 5NN"},
            new Patient{Person=persons[24], County="West Yorkshire", Address="456 Fifteenth St", Postcode="LS3 6OO"},
            new Patient{Person=persons[25], County="Merseyside", Address="789 Sixteenth Ave", Postcode="L1 7PP"},
            new Patient{Person=persons[26], County="Greater Manchester", Address="123 Seventeenth St", Postcode="M1 8QQ"},
            new Patient{Person=persons[27], County="West Yorkshire", Address="456 Eighteenth Ave", Postcode="LS3 9RR"},
            new Patient{Person=persons[28], County="Merseyside", Address="789 Nineteenth St", Postcode="L1 0SS"},
            new Patient{Person=persons[29], County="Greater Manchester", Address="123 Twentieth Ave", Postcode="M1 1TT"},
            new Patient{Person=persons[30], County="West Yorkshire", Address="456 Twenty-First St", Postcode="LS3 2UU"},
            new Patient{Person=persons[31], County="Merseyside", Address="789 Twenty-Second Ave", Postcode="L1 3VV"},
            new Patient{Person=persons[32], County="Greater Manchester", Address="123 Twenty-Third St", Postcode="M1 4WW"},
            new Patient{Person=persons[33], County="West Yorkshire", Address="456 Twenty-Fourth Ave", Postcode="LS3 5XX"},
            new Patient{Person=persons[34], County="Merseyside", Address="789 Twenty-Fifth St", Postcode="L1 6YY"}
            };
            foreach (Patient p in patients)
            {
                context.Patient.Add(p);
            }
            context.SaveChanges();

            // Create 35 appointments
            var appointments = new Appointment[]
            {
            new Appointment{Date=DateTime.Parse("2022-01-01 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[0], Patient=patients[0], Description="Annual checkup", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-01 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[1], Patient=patients[1], Description="Sore throat", Type=AppointmentType.Consultation},
            new Appointment{Date=DateTime.Parse("2022-01-02 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[2], Patient=patients[2], Description="Broken arm", Type=AppointmentType.Surgery},
            new Appointment{Date=DateTime.Parse("2022-01-02 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[3], Patient=patients[3], Description="Eczema treatment", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-03 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[4], Patient=patients[4], Description="Headache", Type=AppointmentType.Consultation},
            new Appointment{Date=DateTime.Parse("2022-01-03 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[5], Patient=patients[5], Description="Back pain", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-04 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[6], Patient=patients[6], Description="Cancer screening", Type=AppointmentType.Consultation},
            new Appointment{Date=DateTime.Parse("2022-01-04 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[7], Patient=patients[7], Description="Eye exam", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-05 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[8], Patient=patients[8], Description="Stomach pain", Type=AppointmentType.Consultation},
            new Appointment{Date=DateTime.Parse("2022-01-05 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[9], Patient=patients[9], Description="Diabetes check", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-06 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[0], Patient=patients[10], Description="Annual checkup", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-06 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[1], Patient=patients[11], Description="Sore throat", Type=AppointmentType.Consultation},
            new Appointment{Date=DateTime.Parse("2022-01-07 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[2], Patient=patients[12], Description="Broken arm", Type=AppointmentType.Surgery},
            new Appointment{Date=DateTime.Parse("2022-01-07 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[3], Patient=patients[13], Description="Eczema treatment", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-08 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[4], Patient=patients[14], Description="Headache", Type=AppointmentType.Consultation},
            new Appointment{Date=DateTime.Parse("2022-01-08 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[5], Patient=patients[15], Description="Back pain", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-09 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[6], Patient=patients[16], Description="Cancer screening", Type=AppointmentType.Consultation},
            new Appointment{Date=DateTime.Parse("2022-01-09 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[7], Patient=patients[17], Description="Eye exam", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-10 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[8], Patient=patients[18], Description="Stomach pain", Type=AppointmentType.Consultation},
            new Appointment{Date=DateTime.Parse("2022-01-10 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[9], Patient=patients[19], Description="Diabetes check", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-11 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[0], Patient=patients[20], Description="Annual checkup", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-11 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[1], Patient=patients[21], Description="Sore throat", Type=AppointmentType.Consultation},
            new Appointment{Date=DateTime.Parse("2022-01-12 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[2], Patient=patients[22], Description="Broken arm", Type=AppointmentType.Surgery},
            new Appointment{Date=DateTime.Parse("2022-01-12 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[3], Patient=patients[23], Description="Eczema treatment", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-13 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[4], Patient=patients[24], Description="Headache", Type=AppointmentType.Consultation},
            new Appointment{Date=DateTime.Parse("2022-01-13 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[5], Patient=patients[15], Description="Back pain", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-14 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[6], Patient=patients[12], Description="Cancer screening", Type=AppointmentType.Consultation},
            new Appointment{Date=DateTime.Parse("2022-01-14 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[7], Patient=patients[13], Description="Eye exam", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-15 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[8], Patient=patients[20], Description="Stomach pain", Type=AppointmentType.Consultation},
            new Appointment{Date=DateTime.Parse("2022-01-15 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[9], Patient=patients[16], Description="Diabetes check", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-16 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[0], Patient=patients[18], Description="Annual checkup", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-16 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[1], Patient=patients[8], Description="Sore throat", Type=AppointmentType.Consultation},
            new Appointment{Date=DateTime.Parse("2022-01-17 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[2], Patient=patients[2], Description="Broken arm", Type=AppointmentType.Surgery},
            new Appointment{Date=DateTime.Parse("2022-01-17 10:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[3], Patient=patients[1], Description="Eczema treatment", Type=AppointmentType.Checkup},
            new Appointment{Date=DateTime.Parse("2022-01-18 9:00 AM"), Length=TimeOnly.Parse("0:30"), Doctor=doctors[4], Patient=patients[2], Description="Headache", Type=AppointmentType.Consultation}
            
            };
            foreach (Appointment a in appointments)
            {
                context.Appointment.Add(a);
            }
            context.SaveChanges();
        }
    }
}