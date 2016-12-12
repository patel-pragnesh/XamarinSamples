﻿using System.Collections.Generic;

namespace IoCSample.Services
{
    public class DataCacheService : IDataCacheService
    {
        public Dictionary<string, object> DataCache { get; } = new Dictionary<string, object>();
    }
}
