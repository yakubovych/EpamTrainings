namespace HomeworkUnitTests
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private readonly SortedSet<Student> students = new SortedSet<Student>();

        private const int MaxStudents = 30;

        public static int Capacity
        {
            get
            {
                return Course.MaxStudents;
            }
        }

        public Course AddStudents(params Student[] students)
        {
            foreach (Student student in students)
            {
                if (this.students.Count > 30)
                {
                    throw new ArgumentException("Course is full!");
                }

                this.students.Add(student);
            }

            return this;
        }

        public Course RemoveStudent(Student student)
        {
            this.students.Remove(student);

            return this;
        }
    }
}
