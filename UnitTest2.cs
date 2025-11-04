using ConsoleApp11WorkingWithTests;

namespace WorkingWithTestsTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        /*
         * 
         *          create a method to initialize a Student object
         *          create test methods that test
         *              create student name process
         *          create data test method
         *              tests adding valid grades
         *          create data test method
         *              tests adding invalid grades
         *                  expect an exception
         *          create a tests method
         *              tests the grade counter method
         * 
         * 
         */

        private Student _student;

        [TestInitialize]
        public void SetUp() {

            _student = new Student();
        }

        [TestMethod]
        public void TestSetName()
        {

            string targetName = "John Smith";
            _student.Name = targetName;
            Assert.AreEqual(targetName, _student.Name);

        }

        [DataTestMethod]
        [DataRow("ben")]
        [DataRow("prof")]
        [DataRow(" ")]
        [DataRow("  ")]
       // [ExpectedException(typeof(Exception))]
        public void TestSetNameIncorrectValues(string name) {

            Assert.ThrowsException<Exception>(  () => _student.Name = name  );
        
        
        }


        [DataTestMethod]
        [DataRow(10)]
        [DataRow(50)]
        [DataRow(70)]
        [DataRow(100)]
        public void TestGradeCountIsWorking(int grade)
        {
            int currentNumGrades = _student.GetNumGrades();
            _student.AddGrade(grade);
            int newNumGrades = _student.GetNumGrades();
            Assert.IsTrue(currentNumGrades + 1 == newNumGrades);
        }
    }
}
