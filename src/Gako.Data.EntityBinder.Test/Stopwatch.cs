using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Anything
{
    [DebuggerStepThrough]
    public static class Stopwatch
    {
        public static IReadOnlyList<StopwatchResult> Start(int times, bool gc, params Action[] actions)
        {
            var results = new List<StopwatchResult>();

            int idx = -1;
            foreach (var action in actions)
            {
                idx++;
                var start = DateTime.Now;

                if (gc) { GC.Collect(); };
                for (int i = 0; i < times; i++)
                {
                    action();
                }

                var end = DateTime.Now;
                results.Add(new StopwatchResult(idx, end - start));
            }

            return results.ToArray();
        }
    }

    [DebuggerStepThrough]
    public struct StopwatchResult
    {
        public StopwatchResult(int idx, TimeSpan timeSpan)
        {
            this.Index = idx;
            this.TimeSpan = timeSpan;
        }

        public int Index { get; }

        public TimeSpan TimeSpan { get; }

        public override string ToString()
        {
            return $"{this.Index}: {this.TimeSpan}";
        }
    }
}
