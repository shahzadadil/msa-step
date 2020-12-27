namespace Step.Core
{
    using System;
    using Step.Core.Enums;

    public class ComparisonInfo
    {
        public ComparisonInfo(
            String key, 
            String value, 
            CompareType compareType = CompareType.Equal) 
        {
            this.Key = key;
            this.Value = value;
            this.CompareType = compareType;   
        }
        
        public String Key { get; private set; }
        public String Value { get; private set; }
        public CompareType CompareType { get; private set; }
    }
}