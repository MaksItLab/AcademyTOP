namespace AcademyTOP.Models
{
    /// <summary>
    /// Класс заявки
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Ункальный идентификатор заявки
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Фамилия студента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Фамилия студента
        /// </summary>
        public string Surname { get; set; } = null;
        /// <summary>
        /// Отчество студента
        /// </summary>
        public string Patronymic { get; set; } = null;
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string NumberPhone { get; set; }
        /// <summary>
        /// Номер группы студента
        /// </summary>
        public string NumberGroup {  get; set; }
        /// <summary>
        /// Название курса
        /// </summary>
        public string Block {  get; set; }
        /// <summary>
        /// Дата пропущенного занятия
        /// </summary>
        public DateTime DataMiss {  get; set; }
        /// <summary>
        /// Время, когда студент может придти
        /// </summary>
        public string FreeTime {  get; set; }
        /// <summary>
        /// Справка студента
        /// </summary>
        public IFormFile FormFile { get; set; }
    }
}
