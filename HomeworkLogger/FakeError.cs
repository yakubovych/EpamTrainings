namespace HomeworkLogger
{
    using System;

    class FakeError
    {
        public void DoSomeMath()
        {
            int a = 2;
            if (a > 0)
            {
                throw new ArgumentException("Parameter should be greater than 0");
            }
        }
    }
}
