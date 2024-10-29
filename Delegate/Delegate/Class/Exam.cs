using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Class
{
	internal class Exam
	{
        public string Subject { get; set; }
        public int ExamDuration { get; set; }
        public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }

        public Exam(string subject, int examduration, DateTime startdate)
        {
            Subject = subject;
            ExamDuration = examduration;
            StartDate = startdate;
            EndDate = StartDate.AddHours(examduration);
        }

    }
}
