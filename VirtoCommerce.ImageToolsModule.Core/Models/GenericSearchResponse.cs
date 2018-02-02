﻿using System.Collections.Generic;

namespace VirtoCommerce.ImageToolsModule.Core.Models
{
    using System;

    public class GenericSearchResponse<TItem>
    {
        public IEnumerable<TItem> Results { get; set; }
        public int TotalCount { get; set; }
    }
}