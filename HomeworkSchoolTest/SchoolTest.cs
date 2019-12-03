using System;
using NUnit.Framework;
using HomeworkUnitTests;

namespace SchoolTest
{
    [TestFixture]
    class SchoolTest
    {
        [Test]
        public void TestSchoolDuplicateId()
        {
            bool callFailed = false;
            try
            {
                School school = new School();
                school.AddStudent(new Student(50000, "Petro"));
                Assert.Throws<ArgumentException>(() => school.AddStudent(new Student(50000, "Petro")));
            }
            catch (ArgumentException)
            {
                callFailed = true;
            }

            Assert.IsTrue(callFailed, "Expected call to MyMethod to fail with ArgumentException");
        }

        [Test]
        public void ReturnNullNameOfStudent()
        {
            bool callFailed = false;
            try
            {
                new Student(50000, null);
            }
            catch (ArgumentNullException)
            {
                callFailed = true;
            }

            Assert.IsTrue(callFailed, "Expected call to MyMethod to fail with ArgumentNullException");
        }

        [Test]
        public void TestStudentIdOutOfRangeLowerLimit()
        {
            bool callFailed = false;
            try
            {
                new Student(0, "Petro");
            }
            catch (ArgumentOutOfRangeException)
            {
                callFailed = true;
            }

            Assert.IsTrue(callFailed, "Expected call to MyMethod to fail with ArgumentOutOfRangeException");
        }

        [Test]
        public void TestStudentIdOutOfRangeUpperLimit()
        {
            bool callFailed = false;
            try
            {
                new Student(100000, "Pesho");
            }
            catch (ArgumentOutOfRangeException)
            {
                callFailed = true;
            }

            Assert.IsTrue(callFailed, "Expected call to MyMethod to fail with ArgumentOutOfRangeException");
        }

        [Test]
        public void TestCourseAddRemoveStudent()
        {
            bool callFailed = false;
            try
            {
                Course course = new Course();

                for (int i = 0; i < Course.Capacity - 1; i++)
                {
                    course.AddStudents(new Student(50000, "Petro"));
                }

                Student student = new Student(50000, "Petro");

                course.AddStudents(student);
                course.AddStudents(student);
                course.AddStudents(student);

                course.RemoveStudent(student);
            }
            catch (Exception)
            {
                callFailed = true;
            }

            Assert.IsTrue(callFailed, "Expected call to MyMethod to fail with Exception");
        }

        [Test]
        public void TestCourseIsFull()
        {
            bool callFailed = false;
            try
            {
                Course course = new Course();

                for (int i = 0; i < Course.Capacity; i++)
                    course.AddStudents(new Student(50000 + i, "Petro"));

                course.AddStudents(new Student(50000 + Course.Capacity, "Petro"));
            }
            catch (ArgumentOutOfRangeException)
            {
                callFailed = true;
            }

            Assert.IsTrue(callFailed, "Expected call to MyMethod to fail with ArgumentException");
        }
    }
}