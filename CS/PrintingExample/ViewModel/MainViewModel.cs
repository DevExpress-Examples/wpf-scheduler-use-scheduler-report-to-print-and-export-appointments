using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpf.Scheduling;
using System.Collections.ObjectModel;
using System.Data.Entity;

namespace PrintingExample {
    [POCOViewModel]
    public class MainViewModel {
        ReceptionDeskContext receptionDeskContext;
        public virtual ObservableCollection<Doctor> Doctors { get; set; }
        public virtual ObservableCollection<MedicalAppointment> Appointments { get; set; }

        protected MainViewModel() {
            receptionDeskContext = new ReceptionDeskContext();
            receptionDeskContext.Doctors.Load();
            Doctors = receptionDeskContext.Doctors.Local;
            receptionDeskContext.MedicalAppointments.Load();
            Appointments = receptionDeskContext.MedicalAppointments.Local;
        }
        public static MainViewModel Create() {
            return ViewModelSource.Create(() => new MainViewModel());
        }
        public void AppointmentsUpdated() {
            receptionDeskContext.SaveChanges();
        }

        #region #PrintScheduler
        public void PrintScheduler(SchedulerControl scheduler) {
            MyPrintHelper.PrintScheduler(scheduler);
        }
        #endregion #PrintScheduler
    }
}
