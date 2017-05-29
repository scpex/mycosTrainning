using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Training.Collection.Model;
using System.Linq;

namespace Training.Collection.Test
{
	[TestClass]
	public class CollectionExercise
	{
		/// <summary>
		/// Initialized students data for exercise.
		/// Plase don't change this
		/// </summary>
		private IEnumerable<StudentInfo> Students
		{
			get
			{
				return new List<StudentInfo>()
				{
					new StudentInfo() { Id = "001", Name = "Ant", Birthday = new DateTime(2005, 1, 1), Score = 65 },
					new StudentInfo() { Id = "002", Name = "Bird", Birthday = new DateTime(2006, 1, 1), Score = 75 },
					new StudentInfo() { Id = "003", Name = "Cat", Birthday = new DateTime(2004, 1, 1), Score = 55 },
					new StudentInfo() { Id = "004", Name = "Dog", Birthday = new DateTime(2010, 1, 1), Score = 60 },
					new StudentInfo() { Id = "005", Name = "Elephant", Birthday = new DateTime(2000, 1, 1), Score = 45 },
				};
			}
		}

		/// <summary>
		/// Exercise of Dictionary. you need to create Dictionary and do the test unit valid.
		/// </summary>
		[TestMethod]
		public void Exercise_Of_Dictionary()
		{
			//Initialize Dictionary
			Dictionary<string, StudentInfo> students = new Dictionary<string, StudentInfo>();

			//Exercise: Add Item into Dictionary


			//Student who has Id is 004 should be "Dog"
			Assert.AreEqual("Dog", students["004"].Name);
		}

		/// <summary>
		/// Exercise of List. you need to create List and do the test unit valid.
		/// </summary>
		[TestMethod]
		public void Exercise_Of_List()
		{
			//Initialize List
			List<StudentInfo> students = new List<StudentInfo>();

			//Exercise: Need a student list that assign "Grade" following below condition
			// 1. Grade "F" when student's Score < 50
			// 2. Grade "D" when 50 >= student's Score < 60
			// 3. Grade "C" when 60 >= student's Score < 70
			// 4. Grade "B" when 70 >= student's Score < 80
			// 5. Grade "A" when student's Score >= 80


			//Number of students who has grade "B" should be 1
			Assert.AreEqual(1, students.FindAll(s => s.Grade == "B").Count);
		}

		/// <summary>
		/// Exercise of IEnumberable, you need to create IEnumberable from Student List by using System.Linq and do the test unit valid.
		/// </summary>
		[TestMethod]
		public void Exercise_Of_IEnumberable()
		{
			//Initialze List of student who has Age > 7 year
			IEnumerable<StudentInfo> seniorStudents = Students.Where(s => DateTime.Now.Year - s.Birthday.Year > 7);

			//Exercise: Find students who has Age > 7 year and Score > 60 by using 'seniorStudents' from above


			//Number of students who has Age > 7 year and Score > 60 shoulbe be 2
			Assert.AreEqual(2, seniorStudents.Count());
		}
	}
}
