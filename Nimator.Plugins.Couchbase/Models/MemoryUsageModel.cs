﻿namespace Nimator.Plugins.Couchbase.Models
{
    public class MemoryUsageModel
    {
        public long Used { get; set; }

        public long Total { get; set; }

        public double PercentageAvailable => 100 - Used * 100 / Total;
    }
}