using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_lab_10
{
    // Класс стиль
    public class Style
    {
        /// <summary>
        /// Заголовок
        /// </summary>
        public string title;

        /// <summary>
        /// Описание
        /// </summary>
        public string description;

        /// <summary>
        /// Код
        /// </summary>
        public string code;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="title">Заголовок</param>
        /// <param name="description">Описание</param>
        /// <param name="code">Код</param>
        public Style(string title, string description, string code)
        {
            this.title = title;
            this.description = description;
            this.code = code;
        }
    }
}
