using System;

namespace Tests.Profiling
{
    [AttributeUsage(AttributeTargets.Method)]
    public abstract class ProfilingAttribute : Attribute
    {
        public int Iterations { get; set; }

        protected ProfilingAttribute(int iterations = 1)
        {
            Iterations = iterations;
        }
    }
}