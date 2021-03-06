﻿using System.Collections.Generic;
using Watchman.Common.Models;

namespace Watchman.DomainModel.Commons.Calculators.Statistics.Splitters
{
    public interface ISplitter
    {
        public IEnumerable<KeyValuePair<TimeRange, IEnumerable<T>>> Split<T>(IEnumerable<T> collection) where T : ISplittable;
    }
}
