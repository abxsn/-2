using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public static class MedicalCatalog
    {
        /// <summary>
        /// По названию специализации находит её айди
        /// </summary>
        /// <param name="name">Название специализации</param>
        /// <returns>Айди специализации</returns>
        public static int GetSpecializationId(string name)
        {
            var a = MedicalCatalog.AllPossibleComplaints.Keys.ToList().IndexOf(MedicalCatalog.AllPossibleComplaints.Keys.ToList().FirstOrDefault(s => s == name));
            return a;
        }
        /// <summary>
        /// По названию жалобы находит её айди
        /// </summary>
        /// <param name="name">Название жалобы</param>
        /// <returns>Айди жалобы</returns>
        public static int GetComplaintId(string name)
        {
            var a = MedicalCatalog.AllPossibleComplaints.Values.SelectMany(s => s).ToList().IndexOf(MedicalCatalog.AllPossibleComplaints.Values.SelectMany(s => s).ToList().FirstOrDefault(s1 => s1 == name));
            return a;
        }
        /// <summary>
        /// Словарь всех возможных диагнозов (ключ - группа, значение - диагноз)
        /// </summary>
        public static Dictionary<string, List<Illness>> AllPossibleDiagnosis = new Dictionary<string, List<Illness>>()
{
    {
        "Общие симптомы", new List<Illness>
        {
            new Illness(){Name = "Хроническая усталость", Destructivity = 1, ExperienceRequired = 0, Cathegory = "Общие симптомы" },
            new Illness(){Name = "Авитаминоз", Destructivity = 2, ExperienceRequired = 1, Cathegory = "Общие симптомы" },
            new Illness(){Name = "Переутомление", Destructivity = 1, ExperienceRequired = 0, Cathegory = "Общие симптомы" }
        }
    },
    {
        "Органы дыхания (ЛОР)", new List<Illness>
        {
            new Illness(){Name = "ОРВИ (Простуда)", Destructivity = 2, ExperienceRequired = 0, Cathegory = "Органы дыхания (ЛОР)" },
            new Illness(){Name = "Острый бронхит", Destructivity = 4, ExperienceRequired = 2, Cathegory = "Органы дыхания (ЛОР)" },
            new Illness(){Name = "Пневмония (Воспаление легких)", Destructivity = 7, ExperienceRequired = 4, Cathegory = "Органы дыхания (ЛОР)" },
            new Illness(){Name = "Ангина (Тонзиллит)", Destructivity = 4, ExperienceRequired = 2, Cathegory = "Органы дыхания (ЛОР)" }
        }
    },
    {
        "Нервная система", new List<Illness>
        {
            new Illness(){Name = "Мигрень", Destructivity = 3, ExperienceRequired = 2, Cathegory = "Нервная система" },
            new Illness(){Name = "Вегетососудистая дистония (ВСД)", Destructivity = 2, ExperienceRequired = 1, Cathegory = "Нервная система" },
            new Illness(){Name = "Невралгия", Destructivity = 3, ExperienceRequired = 2, Cathegory = "Нервная система" }
        }
    },
    {
        "Сердечно-сосудистая система", new List<Illness>
        {
            new Illness(){Name = "Гипертония (Высокое давление)", Destructivity = 6, ExperienceRequired = 4, Cathegory = "Сердечно-сосудистая система" },
            new Illness(){Name = "Стенокардия", Destructivity = 7, ExperienceRequired = 5, Cathegory = "Сердечно-сосудистая система" },
            new Illness(){Name = "Аритмия", Destructivity = 5, ExperienceRequired = 3, Cathegory = "Сердечно-сосудистая система" }
        }
    },
    {
        "Желудочно-кишечный тракт (ЖКТ)", new List<Illness>
        {
            new Illness(){Name = "Острый гастрит", Destructivity = 4, ExperienceRequired = 2, Cathegory = "Желудочно-кишечный тракт (ЖКТ)" },
            new Illness(){Name = "Язва желудка", Destructivity = 6, ExperienceRequired = 4, Cathegory = "Желудочно-кишечный тракт (ЖКТ)" },
            new Illness(){Name = "Панкреатит", Destructivity = 7, ExperienceRequired = 4, Cathegory = "Желудочно-кишечный тракт (ЖКТ)" },
            new Illness(){Name = "Пищевое отравление", Destructivity = 3, ExperienceRequired = 1, Cathegory = "Желудочно-кишечный тракт (ЖКТ)" }
        }
    }
};
        /// <summary>
        /// Всевозможные жалобы
        /// </summary>
        public static Dictionary<string, List<string>> AllPossibleComplaints = new Dictionary<string, List<string>>()
{
    {
        "Общие симптомы", new List<string>
        {
            "Повышенная температура тела (жар)",
            "Озноб и повышенная потливость",
            "Общая слабость и быстрая утомляемость",
            "Потеря аппетита"
        }
    },
    {
        "Органы дыхания (ЛОР)", new List<string>
        {
            "Сухой приступообразный кашель",
            "Влажный кашель с мокротой",
            "Насморк и сильная заложенность носа",
            "Боль и першение в горле при глотании",
            "Одышка при ходьбе или в покое"
        }
    },
    {
        "Нервная система", new List<string>
        {
            "Острая пульсирующая головная боль",
            "Давящая головная боль (мигрень)",
            "Бессонница и нарушение сна",
            "Головокружение и предобморочное состояние"
        }
    },
    {
        "Сердечно-сосудистая система", new List<string>
        {
            "Боль или давящее чувство в груди",
            "Учащенное сердцебиение (тахикардия)",
            "Перепады артериального давления",
            "Отеки нижних конечностей (ног)"
        }
    },
    {
        "Желудочно-кишечный тракт (ЖКТ)", new List<string>
        {
            "Острая боль в области живота",
            "Тошнота и рвота",
            "Изжога и тяжесть в желудке после еды"
        }
    }
};
    }
}
