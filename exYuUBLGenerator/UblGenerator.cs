using System;

namespace exYuUBLGenerator
{
    public class UblGenerator
    {
        private static readonly object ulock = new object();
        private static UblGenerator _generator;
        public static UblGenerator Generator
        {
            get
            {
                lock (ulock)
                {
                    if (_generator == null)
                    {
                        _generator = new UblGenerator();
                    }
                    return _generator;
                }
            }
        }
    }
}
