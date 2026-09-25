using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic2;

namespace АИС2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите число");
                Console.WriteLine("Меню:\n1. Записать пациента к врачу\n2. Просмотреть список пациентов\n3. Изменить информацию о пациентах(или врачах)\n4. Выписать пациента/Уволить врача\n5. Добавить пациента\n6. Добавить врача\n7. Просмотреть список врачей\n8. Начать лечение пациента\n");
                string num = Console.ReadLine();
                switch(num)
                { 
                    case "1":
                        {
                            if (logic.patientCount > 0 && logic.doctorCount > 0)
                            {
                                int patientIdInt = 0;
                                int doctorIdInt = 0;
                                Console.WriteLine($"Введите номер пациента которого вы хотите записать к врачу: \n{logic.AllPatients()}");
                                string patientId = Console.ReadLine();
                                while (int.TryParse(patientId, out patientIdInt) == false || patientIdInt-1 >= logic.PatientCountDoctorCountSpecializationCountSympthomsCount()[0] || patientIdInt < 0)
                                {
                                    Console.WriteLine($"Введите номер пациента которого вы хотите записать к врачу: \n{logic.AllPatients()}");
                                    patientId = Console.ReadLine();
                                }
                                Console.WriteLine($"Введите номер доступного врача: {logic.AllDoctors()}");
                                string doctorId = Console.ReadLine();
                                while (int.TryParse(doctorId, out doctorIdInt) == false || doctorIdInt-1 >= logic.PatientCountDoctorCountSpecializationCountSympthomsCount()[1] || doctorIdInt < 0)
                                {
                                    Console.WriteLine($"Введите номер доступного врача: {logic.AllDoctors()}");
                                    doctorId = Console.ReadLine();
                                }
                                Console.WriteLine(logic.ArrangeAnAppointment(patientIdInt-1, doctorIdInt-1));
                            }
                            else
                            {
                                Console.WriteLine("Нет доступных врачей или пациентов");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            if (logic.patientCount > 0 )
                            {
                                Console.WriteLine(logic.AllPatients());
                            }
                            else
                            {
                                Console.WriteLine("Нет пациентов");
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "3":
                        {
                            if (0 >= logic.patientCount )
                            {
                                Console.WriteLine("Недостаточно пациентов или врачей");
                                Console.ReadKey();
                                break;
                            }
                            int numInt = 0;
                            Console.WriteLine("Изменить информацию о пациентах или врачах?:\n1. О врачах\n2. О пациентах");
                            string num1 = Console.ReadLine();
                            while (int.TryParse(num1, out numInt) == false || numInt > 2 || numInt <= 0)
                            {
                                Console.WriteLine("Изменить информацию о пациентах или врачах?:\n1. О врачах\n2. О пациентах");
                                num1 = Console.ReadLine();
                            }
                            int doctorNumInt = 0;
                            int patientNumInt = 0;
                            switch (numInt)
                            {
                                case 1:
                                    {
                                        if (!(0 >= logic.doctorCount))
                                        {
                                            int numberInt = 0;
                                            Console.WriteLine("Введите номер врача");
                                            Console.WriteLine(logic.AllDoctors());
                                            string doctorNum = Console.ReadLine();
                                            while (int.TryParse(doctorNum, out doctorNumInt) == false || doctorNumInt < 0 || doctorNumInt > logic.doctorCount)
                                            {
                                                Console.WriteLine("Введите номер врача");
                                                Console.WriteLine(logic.AllDoctors());
                                                doctorNum = Console.ReadLine();
                                            }
                                            Console.WriteLine($"Введите номер характеристики, которую вы хотите изменить:\n1. Специализация\n2. Имя\n 3. Опыт работы");
                                            string number = Console.ReadLine();
                                            while (int.TryParse(number, out numberInt) == false || numberInt < 0 || numberInt > 3)
                                            {
                                                Console.WriteLine($"Введите номер характеристики, которую вы хотите изменить:\n1. Специализация\n2. Имя\n 3. Опыт работы");
                                                number = Console.ReadLine();
                                            }
                                            switch (numberInt)
                                            {
                                                case 2:
                                                    {
                                                        Console.WriteLine("Введите имя доктора");
                                                        string doctorName = Console.ReadLine();
                                                        logic.DoctorRedactor(doctorNumInt - 1, 0, doctorName);
                                                        break;
                                                    }
                                                case 1:
                                                    {
                                                        int doctorSpecializationInt = 0;
                                                        Console.WriteLine($"Введите специализацию доктора: {logic.Specializations()}");
                                                        string doctorSpecialization = Console.ReadLine();
                                                        while (int.TryParse(doctorSpecialization, out doctorSpecializationInt) == false || doctorSpecializationInt - 1 >= logic.PatientCountDoctorCountSpecializationCountSympthomsCount()[2] || doctorSpecializationInt < 0)
                                                        {
                                                            Console.WriteLine($"Введите специализацию доктора: {logic.Specializations()}");
                                                            doctorSpecialization = Console.ReadLine();
                                                        }
                                                        logic.DoctorRedactor(doctorNumInt - 1, 1, (doctorSpecializationInt-1).ToString());
                                                        break;
                                                    }
                                                case 3:
                                                    {
                                                        int doctorExperienceInt = 0;
                                                        Console.WriteLine($"Введите опыт доктора: \n1. 1 год\n 2. 2 года\n3. 3 года\n4. 4 года\n5. 5 лет и более");
                                                        string doctorExperience = Console.ReadLine();
                                                        while (int.TryParse(doctorExperience, out doctorExperienceInt) == false || doctorExperienceInt > 5 || doctorExperienceInt <= 0)
                                                        {
                                                            Console.WriteLine($"Введите опыт доктора: \n1. 1 год\n 2. 2 года\n3. 3 года\n4. 4 года\n5. 5 лет и более");
                                                            doctorExperience = Console.ReadLine();
                                                        }
                                                        logic.DoctorRedactor(doctorNumInt - 1, 2, doctorExperienceInt.ToString());
                                                        break;
                                                    }

                                            }
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Недостаточно врачей");
                                            Console.ReadKey();
                                            break;
                                        }
                                    }
                                case 2:
                                    {
                                        if (!(0 >= logic.patientCount))
                                        {
                                            int numberInt = 0;
                                            Console.WriteLine("Введите номер пациента");
                                            Console.WriteLine(logic.AllPatients());
                                            string patientNum = Console.ReadLine();
                                            while (int.TryParse(patientNum, out patientNumInt) == false || patientNumInt < 0 || patientNumInt > logic.patientCount)
                                            {
                                                Console.WriteLine("Введите номер пациента");
                                                Console.WriteLine(logic.AllPatients());
                                                patientNum = Console.ReadLine();
                                            }
                                            Console.WriteLine($"Введите номер характеристики, которую вы хотите изменить:\n1. Жалобы\n2. Имя\n 3. Диагноз");
                                            string number = Console.ReadLine();
                                            while (int.TryParse(number, out numberInt) == false || numberInt < 0 || numberInt > 3)
                                            {
                                                Console.WriteLine($"Введите номер характеристики, которую вы хотите изменить:\n1. Жалобы\n2. Имя\n 3. Диагноз");
                                                number = Console.ReadLine();
                                            }
                                            Console.WriteLine(numberInt);
                                            switch (numberInt)
                                            {
                                                case 2:
                                                    {
                                                        Console.WriteLine("Введите имя пациента");
                                                        string patientName = Console.ReadLine();
                                                        logic.PatientRedactor(patientNumInt - 1, 0, patientName);
                                                        break;
                                                    }
                                                case 1:
                                                    {
                                                        int patientComplaintsInt = 0;
                                                        Console.WriteLine($"Введите жалобы пациента: {logic.AllComplaintsListed()}");
                                                        string patientComplaints = Console.ReadLine();
                                                        while (int.TryParse(patientComplaints, out patientComplaintsInt) == false || patientComplaintsInt - 1 >= logic.PatientCountDoctorCountSpecializationCountSympthomsCount()[3] || patientComplaintsInt - 1 < 0)
                                                        {
                                                            Console.WriteLine($"Введите жалобы пациента: {logic.AllComplaintsListed()}");
                                                            patientComplaints = Console.ReadLine();
                                                        }
                                                        logic.PatientRedactor(patientNumInt - 1, 1, (patientComplaintsInt - 1).ToString());
                                                        break;
                                                    }
                                                case 3:
                                                    {
                                                        Console.WriteLine("Диагноз ставит доктор, а не вы");
                                                        break;
                                                    }

                                            }
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Недостаточно пациентов");
                                            Console.ReadKey();
                                            break;
                                        }
                                    }
                            }
                            break;
                        }
                    case "4":
                        {
                            if (0 >= logic.patientCount || 0 >= logic.doctorCount)
                            {
                                Console.WriteLine("Недостаточно пациентов или врачей");
                                Console.ReadKey();
                                break;
                            }
                            int numInt = 0;
                            Console.WriteLine("Уволить пациента или врача?");
                            string num1 = Console.ReadLine();
                            while(int.TryParse(num1, out numInt) == false || numInt>2 || numInt<=0)
                            {
                                Console.WriteLine("Уволить пациента или врача?:\n1. Врача\n2. Пациента");
                                num1 = Console.ReadLine();
                            }
                            int doctorNumInt = 0;
                            int patientNumInt = 0;
                            switch (numInt)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Введите номер врача");
                                        Console.WriteLine(logic.AllDoctors());
                                        string doctorNum = Console.ReadLine();
                                        while(int.TryParse(doctorNum, out doctorNumInt) == false || doctorNumInt < 0 || doctorNumInt > logic.doctorCount)
                                        {
                                            Console.WriteLine("Введите номер врача");
                                            Console.WriteLine(logic.AllDoctors());
                                            doctorNum = Console.ReadLine();
                                        }
                                        logic.RemoveDoctor(doctorNumInt - 1);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Введите номер пациента");
                                        Console.WriteLine(logic.AllPatients());
                                        string patientNum = Console.ReadLine();
                                        while (int.TryParse(patientNum, out patientNumInt) == false || patientNumInt < 0 || patientNumInt > logic.patientCount)
                                        {
                                            Console.WriteLine("Введите номер пациента");
                                            Console.WriteLine(logic.AllPatients());
                                            patientNum = Console.ReadLine();
                                        }
                                        logic.RemovePatient(patientNumInt - 1);
                                        break;
                                    }
                            }
                            break;
                        }
                    case "5":
                        {
                            int patientComplaintsInt;
                            Console.WriteLine("Введите имя пациента");
                            string patientName = Console.ReadLine();
                            Console.WriteLine($"Введите жалобы пациента: {logic.AllComplaintsListed()}");
                            string patientComplaints = Console.ReadLine();
                            while (int.TryParse(patientComplaints, out patientComplaintsInt) == false || patientComplaintsInt-1 >= logic.PatientCountDoctorCountSpecializationCountSympthomsCount()[3] || patientComplaintsInt-1 < 0)
                            {
                                Console.WriteLine($"Введите жалобы пациента: {logic.AllComplaintsListed()}");
                                patientComplaints = Console.ReadLine();
                            }
                            logic.AddPatient(patientName, patientComplaintsInt-1);
                            break;
                        }
                    case "6":
                        {
                            int doctorExperienceInt;
                            int doctorSpecializationInt;
                            Console.WriteLine("Введите имя доктора");
                            string doctorName = Console.ReadLine();
                            Console.WriteLine($"Введите опыт доктора: \n1. 1 год\n 2. 2 года\n3. 3 года\n4. 4 года\n5. 5 лет и более");
                            string doctorExperience = Console.ReadLine();
                            while (int.TryParse(doctorExperience, out doctorExperienceInt) == false || doctorExperienceInt > 5 || doctorExperienceInt <= 0)
                            {
                                Console.WriteLine($"Введите опыт доктора: \n1. 1 год\n 2. 2 года\n3. 3 года\n4. 4 года\n5. 5 лет и более");
                                doctorExperience = Console.ReadLine();
                            }
                            Console.WriteLine($"Введите специализацию доктора: {logic.Specializations()}");
                            string doctorSpecialization = Console.ReadLine();
                            while (int.TryParse(doctorSpecialization, out doctorSpecializationInt) == false || doctorSpecializationInt-1 >= logic.PatientCountDoctorCountSpecializationCountSympthomsCount()[2] || doctorSpecializationInt < 0)
                            {
                                Console.WriteLine($"Введите специализацию доктора: {logic.Specializations()}");
                                doctorSpecialization = Console.ReadLine();
                            }
                            logic.AddDoctor(doctorName, doctorSpecializationInt-1, doctorExperienceInt);
                            Console.ReadKey();
                            break;
                        }
                    case "8":
                        {
                            Console.WriteLine(logic.StartTreatment());
                            Console.ReadKey();
                            break;
                        }
                    case "7":
                        {
                            if (logic.doctorCount > 0)
                            {
                                Console.WriteLine(logic.AllDoctors());
                            }
                            else
                            {
                                Console.WriteLine("Нет врачей");
                            }
                            Console.ReadKey();
                            break;
                        }
                }
            }
        }
    }
}
