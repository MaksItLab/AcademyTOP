
namespace AcademyTOP.DataAccessLayer.Models
{
	/// <summary>
	/// Заявка
	/// </summary>
	public class Request
	{
		/// <summary>
		/// Идентификатор
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Дата поступления заявки
		/// </summary>
		public DateTime DateSend { get; set; }
		/// <summary>
		/// Вид консультации
		/// false - Консультация платная
		/// true - Консультация бесплатная
		/// </summary>
		public bool PayOrFree { get; set; }
		/// <summary>
		/// Идентификатор студента
		/// </summary>
		public int StudentId { get; set; }
		/// <summary>
		/// Студент
		/// </summary>
		public Student Student { get; set; }
	}
}
