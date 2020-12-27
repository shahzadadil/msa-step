namespace Step.Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Comparisons : IEnumerable<ComparisonInfo>
    {
        List<ComparisonInfo> comparisons = new List<ComparisonInfo>();

        public ComparisonInfo this[Int32 index]
        {
            get { return comparisons[index]; }
            set { comparisons.Insert(index, value); }
        }

        public IEnumerator<ComparisonInfo> GetEnumerator()
        {
            return comparisons.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}