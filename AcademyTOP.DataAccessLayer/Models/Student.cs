namespace AcademyTOP.DataAccessLayer.Models
{
	/// <summary>
	/// Студент
	/// </summary>
	public class Student
	{
		/// <summary>
		/// Идентификатор
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Фамилия Имя Отчество
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Номер телефона
		/// </summary>
		public string Number { get; set; }
		/// <summary>
		/// Учебная группа
		/// </summary>
		public string Group { get; set; }
		/// <summary>
		/// Тема урока
		/// </summary>
		public string Theme { get; set; }
		/// <summary>
		/// Дата пропущенного урока
		/// </summary>
		public DateTime MissedLessonDate { get; set; }
		/// <summary>
		/// Дата и время будущего занятия
		/// </summary>
		public DateTime FutureLessonDate { get; set; }
		/// <summary>
		/// Идентификатор заявки
		/// </summary>
		public int RequestId { get; set; }
		/// <summary>
		/// Заявка
		/// </summary>
		public Request Request { get; set; }
	}
}
