using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
        public class FunctionInsp
        {
            public const string InspectorName = "Автоинспекция г. Чита";
            private string _chiefInspector = "Васильев Василий Иванович";
            private List<string> _employees = new List<string> { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };
            private Random _random = new Random();
            public string GetInspector() => _chiefInspector;

            public string GetCarInspection() => InspectorName;

            public bool SetInspector(string fullName)
            {
                if (_employees.Contains(fullName))
                {
                    _chiefInspector = fullName;
                    return true;
                }
                return false;
            }

            public string GenerateNumber(char symbol, int code = 75)
            {
                int number = _random.Next(1000, 10000); //Генерируем 4-значное число
                return $"{symbol.ToString().ToUpper()}{number}_{code}";
            }

            public string[] GetWorker() => _employees.ToArray();

            public void AddWorker(string employeeName) => _employees.Add(employeeName);
        }
}




