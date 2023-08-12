using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10
{
    internal class Consultant
    {
        private string surName = "Sailau";
        private string name = "Nurbek";
        private string patronymic = "Alibekuly";
        private string number = "+01234567890";
        private string pasportId = "123456789123456789";

        /// <summary>
        /// Свойство для просмотра имени
        /// </summary>
        public string Name { get { return name; } }

        /// <summary>
        /// Свойство для просмотра фамилий
        /// </summary>
        public string SurName { get { return surName; } }

        /// <summary>
        /// Свойство для просмотра отчества
        /// </summary>
        public string Patronymic { get { return patronymic; } }

        /// <summary>
        /// 
        /// </summary>
        public string Number { get { return number; } set { setNumber(); } }

        //Консультант может изменить «Номер телефона», но при этом поле должно быть всегда заполнено.
        public void setNumber()
        {
            this.number = Console.ReadLine();
            while (this.number.Length < 11 || this.number.Length > 11 || this.number == String.Empty)
            {
                Console.WriteLine("Не корректный номер или отсутсутвуют данные. Введите номер заново");
                this.number = Console.ReadLine();
            }            
        }

        /// <summary>
        /// string method wich retutn Id of pasport
        /// </summary>
        /// <returns></returns>
        public string showId()
        {
            if (pasportId == String.Empty)
            {
                return "Не корректный номер паспорта или отсутсутвуют данные";
            }
            else
            {
                return"******************";
            }
        }
    }
}
