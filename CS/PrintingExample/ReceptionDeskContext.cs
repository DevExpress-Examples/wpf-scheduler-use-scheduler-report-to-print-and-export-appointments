namespace PrintingExample {
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;

    public class ReceptionDeskContext: DbContext {
        // Your context has been configured to use a 'ReceptionDeskContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'EntityFrameworkExample.ReceptionDeskContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ReceptionDeskContext' 
        // connection string in the application configuration file.
        public ReceptionDeskContext()
            : base("name=ReceptionDeskContext") {
            Database.SetInitializer(new ReceptionDeskDBInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<MedicalAppointment> MedicalAppointments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
    }

    public class Doctor {
        public Doctor() { }
        public Doctor(int id, string name) {
            Id = Id;
            Name = name;
        }
        [Key()]
        public  int Id { get; set; }
        public  string Name { get; set; }
    }

    public class MedicalAppointment {
        protected MedicalAppointment() { }
        [Key()]
        public int Id { get; set; }
        public bool AllDay { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        public string PatientName { get; set; }
        public string Notes { get; set; }
        public string Subject { get; set; }
        public int PaymentStateId { get; set; }
        public int IssueId { get; set; }
        public int Type { get; set; }
        public string Location { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public int? DoctorId { get; set; }
        public string InsuranceNumber { get; set; }
        public bool FirstVisit { get; set; }
    }
}