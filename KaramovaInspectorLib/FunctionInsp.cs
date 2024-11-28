using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaramovaInspectorLib
{
    public class FunctionInsp
    {
        private const string InspectionName = "Автоинспекция г. Чита";
        private string chiefInspector = "Васильев Василий Иванович";
        private List<string> workers = new List<string>
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",
            "Васильев В.И."
        };

        public string GetInspector()
        {
            return chiefInspector;
        }

        public string GetCarInspection()
        {
            return InspectionName;
        }

        public void SetInspector(string fullName)
        {
            if (workers.Contains(fullName))
            {
                chiefInspector = fullName; 
            }
            else
            {
                throw new ArgumentException("ФИО не найдено в списке сотрудников.");
            }
        }

        public string GenerateNumber(string number, char symbol, string code)
        {
            return $"{char.ToUpper(symbol)}{number}_{code}";
        }

        public List<string> GetWorker()
        {
            return workers;
        }

        public void AddWorker(string fullName)
        {
            if (!workers.Contains(fullName))
            {
                workers.Add(fullName);
            }
            else
            {
                throw new ArgumentException("Сотрудник уже существует.");
            }
        }
    }
}
