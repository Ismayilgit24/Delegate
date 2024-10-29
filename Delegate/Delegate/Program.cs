using Delegate.Class;
using System.Threading.Channels;

namespace Delegate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person1 = new Person("Asya", "Osmanova", 25);
			Person person2 = new Person("Nihat", "Abdullayev", 18);
			Person person3 = new Person("Amin", "Salmanov", 21);


			List<Person> people = new List<Person>() { person1, person2, person3 };

			
			people
				.FindAll(person => person.FirstName == "Asya")
				.ForEach(person => Console.WriteLine(string.Concat(person.FirstName, " ", person.LastName)));

			people
				.FindAll(person => person.LastName.EndsWith("ov") || person.LastName.EndsWith("ova"))
				.ForEach(person => Console.WriteLine(string.Concat(person.FirstName, " ", person.LastName)));

			people
				.FindAll(person => person.Age > 20)
				.ForEach(person => Console.WriteLine(string.Concat(person.FirstName, " ", person.LastName, " ", person.Age)));


			
			Exam exam1 = new Exam("Math", 3, new DateTime(2024, 10, 25, 10, 0, 0));
			Exam exam2 = new Exam("Biology", 2, new DateTime(2024, 10, 26, 10, 45, 0));
			Exam exam3 = new Exam("Chemistry", 1, new DateTime(2024, 10, 29, 21, 30, 0));
			Exam exam4 = new Exam("Art", 6, new DateTime(2024, 10, 29, 9, 30, 0));



			List<Exam> exams = new List<Exam>() { exam1, exam2, exam3, exam4 };
			DateTime now = DateTime.Now;
			DateTime previousweek = now.AddDays(-7);

			Console.WriteLine("List of Exams held in the last week\n");
			exams
				.FindAll(exam => exam.StartDate <= now && exam.StartDate >= previousweek)
				.ForEach(exam => Console.WriteLine(string.Concat("Exam: ", exam.Subject, " & ", "Duration: ", exam.ExamDuration)));

			Console.WriteLine("List of Exams with a completion time of more than 2 hours\n");
			exams
				.FindAll(exam => exam.ExamDuration > 2)
				.ForEach(exam => Console.WriteLine(string.Concat("Exam: ", exam.Subject, " & ", "Duration: ", exam.ExamDuration)));

			Console.WriteLine("Currently ongoing exams\n");
			exams
				.FindAll(exam => exam.EndDate >= DateTime.Now)
				.ForEach(exam => Console.WriteLine(string.Concat("Exam: ", exam.Subject, " & ", "Duration: ", exam.ExamDuration)));
		}
	}
}
