using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ServiceItem
    {
        public int Id { get; set; }
        public string InsComCode { get; set; }
        public string InsItemCode { get; set; }
        public string ItemOld { get; set; }
        public string RxItemNameEn { get; set; }
        public string RxItemName { get; set; }
        public string Item { get; set; }
        public string ItemOldCurrent { get; set; }
        public string Molecule { get; set; }
        public string GenericNamePt { get; set; }
        public string GenericNameEn { get; set; }
        public string GenericName { get; set; }
        public string OtherCartegory { get; set; }
        public string InsCompany { get; set; }
        public string ChkAnaes { get; set; }
        public string RxItemNamePt { get; set; }
        public string AuthorizationRequired { get; set; }
        public string Memonics { get; set; }
        public string Maincartegory { get; set; }
        public string Subcartegory { get; set; }
        public string MaincategoryCode { get; set; }
        public string SubcartegoryCode { get; set; }
        public string ItemClass { get; set; }
        public string TopLevelTherapyArea { get; set; }
        public string MidLevelTherapyArea { get; set; }
        public string BestBrandInt { get; set; }
        public string BrandOwnerInt { get; set; }
        public string DosageForm { get; set; }
        public string Typeofdrug { get; set; }
        public string TypeofdrugId { get; set; }
        public string Service { get; set; }
        public string MoleculeSortedNoSpace { get; set; }
        public string ImsId { get; set; }
        public string ImsMolecule { get; set; }
        public string Atccode1 { get; set; }
        public string Atccode2 { get; set; }
        public string Atccode3 { get; set; }
        public string Atccode4 { get; set; }
        public double? Price { get; set; }
        public string ChkCardiology { get; set; }
        public string ChkDental { get; set; }
        public string ChkDerma { get; set; }
        public string ChkNeuro { get; set; }
        public string ChkHearing { get; set; }
        public string ChkObsg { get; set; }
        public string ChkOpt { get; set; }
        public string ChkPaed { get; set; }
        public string ChkPsycho { get; set; }
        public string ChkEndo { get; set; }
        public string ChkEnt { get; set; }
        public string ChkGp { get; set; }
        public string ChkIntmed { get; set; }
        public string ChkOthers { get; set; }
        public string ChkNurs { get; set; }
        public string ChkOh { get; set; }
        public string ChkPhysio { get; set; }
        public string ChkUrolo { get; set; }
        public string ChkPneum { get; set; }
        public string ChkOpd { get; set; }
        public string ChkIpd { get; set; }
        public string ChkMat { get; set; }
        public string DedOpd { get; set; }
        public string DedIpd { get; set; }
        public string DedDental { get; set; }
        public string DedOptical { get; set; }
        public string DedPhysiotherapy { get; set; }
        public string DedPsychology { get; set; }
        public string DedHearing { get; set; }
        public string DedMaternity { get; set; }
        public string ChkAnaesthetic { get; set; }
        public string MatAuthorisationRequired { get; set; }
        public string MatAuthMessage { get; set; }
        public string OpdAuthMessage { get; set; }
        public string IpdAuthMessage { get; set; }
        public string IpdAuthorisationRequired { get; set; }
        public string OpdAuthorisationRequired { get; set; }
        public TimeSpan? LastUpdated { get; set; }
        public int? ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string ProviderCartegory { get; set; }
        public string RxOtherCartegory { get; set; }
    }
}
