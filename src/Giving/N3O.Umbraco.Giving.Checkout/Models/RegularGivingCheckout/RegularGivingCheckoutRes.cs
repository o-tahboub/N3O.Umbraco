﻿using N3O.Umbraco.Financial;
using N3O.Umbraco.Giving.Allocations.Models;
using N3O.Umbraco.Lookups;
using NodaTime;
using System.Collections.Generic;

namespace N3O.Umbraco.Giving.Checkout.Models {
    public class RegularGivingCheckoutRes {
        public IEnumerable<Allocation> Allocations { get; set; }
        public MoneyRes Total { get; set; }
        public DayOfMonth CollectionDay { get; set; }
        public LocalDate? FirstCollectionDate { get; set; }
    }
}