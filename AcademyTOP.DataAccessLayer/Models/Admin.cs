using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyTOP.DataAccessLayer.Models
{
    /// <summary>
    /// класс администраторов
    /// </summary>
    public class Admin
    {
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        public string Password { get; set; }
    }
}
