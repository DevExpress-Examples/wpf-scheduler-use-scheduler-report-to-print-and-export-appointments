using System.Collections.Generic;
using System.Data.Entity;

namespace PrintingExample {
    public class ReceptionDeskDBInitializer : CreateDatabaseIfNotExists<ReceptionDeskContext> {
        protected override void Seed(ReceptionDeskContext context) {
            base.Seed(context);
            List<Doctor> Doctors = new List<Doctor>() {
            new Doctor(1,"Stomatologist"),
            new Doctor(2, "Ophthalmologist"),
            new Doctor(3, "Surgeon"),
            };
            Doctors.ForEach(x => context.Doctors.Add(x));
            context.SaveChanges();
        }
    }
}