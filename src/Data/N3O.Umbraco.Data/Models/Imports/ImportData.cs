﻿using System;
using System.Collections.Generic;

namespace N3O.Umbraco.Data.Models {
    public class ImportData {
        public string Reference { get; set; }
        public Guid? ContentKey { get; set; }
        public IEnumerable<ImportField> Fields { get; set; }
    }
}