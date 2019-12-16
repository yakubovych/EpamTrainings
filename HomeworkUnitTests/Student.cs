namespace HomeworkUnitTests
{
    using System;

    public class Student : IComparable<Student>
    {
        public string Name
        {
            get
            {
                return this.Name;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name");
                }
            }
        }

        public int Id
        {
            get
            {
                return this.Id;
            }

            private set
            {
                if (!(10000 <= value && value <= 99999))
                {
                    throw new ArgumentOutOfRangeException("Id");
                }
            }
        }

        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int CompareTo(Student st)
        {
            return this.Id.CompareTo(st.Id);
        }
    }
}