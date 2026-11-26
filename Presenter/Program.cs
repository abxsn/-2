using BusinessLogic2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;
using Ninject;
using Shared;
using АИС2;

namespace Presenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKernel ninjectKernel = new StandardKernel(new NinjectModule());
            ILogic logic = ninjectKernel.Get<ILogic>();
            Console.WriteLine("Выберите: \n1. Формы\n2. Консоль");
            int po = 0;
            while(true)
            {
                if(int.TryParse(Console.ReadLine(), out int a))
                {
                    po = a;
                    break;
                }
            }
            switch (po)
            {
                case 1:
                    {
                        Form1 mainForm = new Form1();
                        IPatientViewAdd patientViewAdd = new PatientAdding();
                        IDoctorViewAdd doctorViewAdd = new DoctorAdding();
                        IAppointmentView appointmentView = new Appointment();
                        ITreatmentView treatmentView = new TreatmentForm();
                        IDoctorViewRedactor doctorViewRedactor = new DoctorRedactor();
                        IPatientViewRedactor patientViewRedactor = new PatientRedactor();
                        IPatientViewRemove patientViewRemove = new PatientRemover();
                        IDoctorViewRemove doctorViewRemove = new DoctorRemover();
                        IDoctorsListView doctorsListView = new DoctorListForm();
                        IPatientsListView patientsListView = new PatientListForm();

                        mainForm.AddPatient += patientViewAdd.ShowDialogView;
                        mainForm.AddDoctor += doctorViewAdd.ShowDialogView;
                        mainForm.RemovePatient += patientViewRemove.ShowDialogView;
                        mainForm.RemoveDoctor += doctorViewRemove.ShowDialogView;
                        mainForm.RedactPatient += patientViewRedactor.ShowDialogView;
                        mainForm.RedactDoctor += doctorViewRedactor.ShowDialogView;
                        mainForm.ArrangeAnAppointment += appointmentView.ShowDialogView;
                        mainForm.StartTreatment += treatmentView.ShowDialogView;
                        mainForm.OpenPatientList += patientsListView.ShowDialogView;
                        mainForm.OpenDoctorList += doctorsListView.ShowDialogView;

                        new PatientAddPresenter(patientViewAdd, logic.PatientService);
                        new DoctorAddPresenter(logic.DoctorService, doctorViewAdd);
                        new PatientRemovePresenter(patientViewRemove, logic.PatientService);
                        new DoctorRemovePresenter(logic.DoctorService, doctorViewRemove);
                        new TreatmentPresenter(treatmentView, logic.TreatmentService);
                        new AppointmentPresenter(appointmentView, logic.AppointmentService);
                        new PatientRedactorPresenter(patientViewRedactor, logic.PatientService);
                        new DoctorRedactorPresenter(doctorViewRedactor, logic.DoctorService);
                        new DoctorsListPresenter(logic.DoctorService, doctorsListView);
                        PatientsListPresenter p = new PatientsListPresenter(logic.PatientService, patientsListView, logic.TreatmentService);
                        new MainFormPresenter(mainForm, logic.DoctorService, logic.PatientService);

                        Application.Run(mainForm);

                        break;
                    }
                case 2:
                    {
                        MainViewConsole console = new MainViewConsole();


                        IPatientViewAdd patientViewAddConsole = new AddPatient();
                        IDoctorViewAdd doctorViewAddConsole = new AddDoctor();
                        IAppointmentView appointmentViewConsole = new AppointmentConsole();
                        ITreatmentView treatmentViewConsole = new Treatment();
                        IDoctorViewRedactor doctorViewRedactorConsole = new DoctorRedactorConsole();
                        IPatientViewRedactor patientViewRedactorConsole = new PatientRedactorConsole();
                        IPatientViewRemove patientViewRemoveConsole = new PatientRemoverConsole();
                        IDoctorViewRemove doctorViewRemoveConsole = new DoctorRemoverConsole();
                        IDoctorsListView doctorsListViewConsole = new DoctorsList();
                        IPatientsListView patientsListViewConsole = new PatientsList();


                        console.AddPatient += patientViewAddConsole.ShowDialogView;
                        console.AddDoctor += doctorViewAddConsole.ShowDialogView;
                        console.RemovePatient += patientViewRemoveConsole.ShowDialogView;
                        console.RemoveDoctor += doctorViewRemoveConsole.ShowDialogView;
                        console.RedactPatient += patientViewRedactorConsole.ShowDialogView;
                        console.RedactDoctor += doctorViewRedactorConsole.ShowDialogView;
                        console.ArrangeAnAppointment += appointmentViewConsole.ShowDialogView;
                        console.StartTreatment += treatmentViewConsole.ShowDialogView;
                        console.OpenPatientList += patientsListViewConsole.ShowDialogView;
                        console.OpenDoctorList += doctorsListViewConsole.ShowDialogView;


                        new PatientAddPresenter(patientViewAddConsole, logic.PatientService);
                        new DoctorAddPresenter(logic.DoctorService, doctorViewAddConsole);
                        new PatientRemovePresenter(patientViewRemoveConsole, logic.PatientService);
                        new DoctorRemovePresenter(logic.DoctorService, doctorViewRemoveConsole);
                        new TreatmentPresenter(treatmentViewConsole, logic.TreatmentService);
                        new AppointmentPresenter(appointmentViewConsole, logic.AppointmentService);
                        new PatientRedactorPresenter(patientViewRedactorConsole, logic.PatientService);
                        new DoctorRedactorPresenter(doctorViewRedactorConsole, logic.DoctorService);
                        new DoctorsListPresenter(logic.DoctorService, doctorsListViewConsole);
                        new PatientsListPresenter(logic.PatientService, patientsListViewConsole, logic.TreatmentService);
                        new MainFormPresenter(console, logic.DoctorService, logic.PatientService);

                        console.Run();

                        break;
                    }
            }
        }
    }
}
