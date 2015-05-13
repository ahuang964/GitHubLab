using System;

namespace Exercise17_4
{
    public class CountDownEventArgs : EventArgs
    {
        private string msg;

        public CountDownEventArgs(string msg)
        {
            this.msg = msg;
        }

        public override string ToString()
        {
            return msg;
        }
    }
}