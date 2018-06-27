using MvcTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTutorial.ViewModels {
	public class ClassesForStudent {
		public Student Student { get; set; }
		public IEnumerable<Grade> Grades { get; set; }

	}
}