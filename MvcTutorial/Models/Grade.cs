using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTutorial.Models {
	public class Grade {
		public int Id { get; set; }
		public string ClassName { get; set; }
		public int StudentId { get; set; }
		public virtual Student Student { get; set; }


		public Grade() {

		}
	}
}