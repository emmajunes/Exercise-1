namespace Exercise_1
{
    internal partial class Program
    {
        public class Stopwatch
        {
            private DateTime _start;
            private DateTime _stop;
            private bool _running;
            public void Start()
            {
             
                if (!_running)
                {
                    _running = true;
                    _start = DateTime.Now;
                }
                else
                {
                    throw new InvalidOperationException("Stopwatch is already running!");
                }
                    
            }

            public TimeSpan Stop()
            {

                if (_running)
                {
                    _running = false;
                    _stop = DateTime.Now;
                    
                }
                else
                {
                    throw new InvalidOperationException("Stopwatch is already running!");
                }
                    

                return (_stop - _start);
            }


        }
    }
}