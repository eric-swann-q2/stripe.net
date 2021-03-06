﻿using Newtonsoft.Json;

namespace Stripe
{
    public class StripeTokenCreateOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("card")]
        public StripeCreditCardOptions Card { get; set; }
    }

    public class StripeTokenCreateFromCardOptions
    {
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        [JsonProperty("card")]
        public string Card { get; set; }
    }
}