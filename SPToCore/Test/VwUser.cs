using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwUser
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserFull { get; set; }
        public string RoleName { get; set; }
        public int? IdSalesArea { get; set; }
        public string CodSalesArea { get; set; }
        public string SalesArea { get; set; }
        public int IdUser { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public int IdLanguage { get; set; }
        public string CodLanguage { get; set; }
        public string Language { get; set; }
        public int? IdCulture { get; set; }
        public string CodCulture { get; set; }
        public string Culture { get; set; }
        public int? IdCurrency { get; set; }
        public string CodCurrency { get; set; }
        public string Currency { get; set; }
        public bool? IsActive { get; set; }
        public int? IdTimeZone { get; set; }
        public string IdTimeZoneDotNet { get; set; }
        public string TimeZoneDisplayName { get; set; }
    }
}
