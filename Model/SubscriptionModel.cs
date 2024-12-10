namespace vuTest.Model
{
    public class SubscriptionModel
    {
        public string Amount { get; set; }
        public string FirstPaymentIncludedInCycle { get; set; }
        public string ServiceId { get; set; }
        public string Currency { get; set; }
        public string StartDate { get; set; }
        public string ExpiryDate { get; set; }
        public string Frequency { get; set; }
        public string SubscriptionType { get; set; }
        public string MaxCapRequired { get; set; }
        public string MerchantShortCode { get; set; }
        public string PayerType { get; set; }
        public string PaymentType { get; set; }
        public string RedirectUrl { get; set; }
        public string SubscriptionRequestId { get; set; }
        public string SubscriptionReference { get; set; }
        public string CKey { get; set; }
    }
}
