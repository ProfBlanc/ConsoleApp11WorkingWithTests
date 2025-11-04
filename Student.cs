using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11WorkingWithTests
{
    public class Student
    {

        /*
         *  Name: at least 3 chars & contains a space
         *      getter and setter
         *  List of int grades (private)
         *  method
         *      addGrade
         *          grade must be within 0-100
         *              if not, throw exception
         *              if so, add grade to the List of grades
         *      countGrade
         *          returns the number of grades in the method
         * 
         */
        private List<int> _grades = new List<int>();
        private static string DEFAULT_NAME = "Student Name";

        private string _name = DEFAULT_NAME;
        public string Name {
            get => _name;
            set {
                if (value.Length < 3 || !value.Contains(" "))
                    throw new Exception($"Sorry, but '{value}' is an invalid name");
                _name = value;
            
            } 
        }

        public int GetNumGrades() {
            return _grades.Count;
        }
        public void AddGrade(int grade) {

            if (grade < 0 || grade > 100)
                throw new Exception($"Grade of {grade} is invalid. The grade must be between 0 and 100");

            _grades.Add(grade);

        }


    }
}
