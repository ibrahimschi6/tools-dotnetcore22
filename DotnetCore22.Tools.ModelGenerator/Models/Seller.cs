using System;
using System.Collections.Generic;

namespace DotnetCore22.Domain.Model
{
    public partial class Seller
    {
        public System.Guid Id { get; set; }
        public System.Guid UserId { get; set; }
        public byte SellerType { get; set; }
        public byte[] SubMerchantCode { get; set; }
        public byte CityId { get; set; }
        public string StreetAddress { get; set; }
        public string IBAN { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string TaxOffice { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLegalTitle { get; set; }
        public bool IsAgreementSigned { get; set; }
        public virtual City City { get; set; }
        public virtual User User { get; set; }
    }
}
