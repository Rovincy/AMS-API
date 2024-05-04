using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class StandardItem
    {
        public int Id { get; set; }
        public string InsComCode { get; set; }
        public string InsItemCode { get; set; }
        public string ItemOld { get; set; }
        public string RxItemName { get; set; }
        public string Item { get; set; }
        public string ItemOldCurrent { get; set; }
        public string Molecule { get; set; }
        public string GenericName { get; set; }
        public string MoleculeSortedNoSpace { get; set; }
        public string ImsId { get; set; }
        public string ImsMolecule { get; set; }
        public string Atccode1 { get; set; }
        public string Atccode2 { get; set; }
        public string Atccode3 { get; set; }
        public string Atccode4 { get; set; }
        public string TopLevelTherapyArea { get; set; }
        public string MidLevelTherapyArea { get; set; }
        public string BestBrandInt { get; set; }
        public string BrandOwnerInt { get; set; }
        public string DosageForm { get; set; }
        public string Typeofdrug { get; set; }
        public string TypeofdrugId { get; set; }
        public string Service { get; set; }
        public string ServiceNew { get; set; }
        public string OtherCartegory { get; set; }
        public string InsCompany { get; set; }
        public string Memonics { get; set; }
        public string Maincartegory { get; set; }
        public string Subcartegory { get; set; }
        public string MaincategoryCode { get; set; }
        public string SubcartegoryCode { get; set; }
        public double? Price { get; set; }
        public string RxItemNameNew { get; set; }
        public string OtherCategoryNew { get; set; }
        public string PackSize { get; set; }
        public string ReviewStatus { get; set; }
        public int? RefillNo { get; set; }
        public string Refill { get; set; }
        public string ReviewUser { get; set; }
        public string ApproveUser { get; set; }
        public string DrugLegalStatus { get; set; }
        public string RestrictionStatus { get; set; }
        public string Gender { get; set; }
        public string Specialist { get; set; }
        public string MaximumDose { get; set; }
        public string Age { get; set; }
        public string VisitType { get; set; }
        public string Abbreviation { get; set; }
        public DateTime? EnteredTime { get; set; }
        public DateTime? ApprovedTime { get; set; }
        public string RxItemCode { get; set; }
        public string IdInscompany { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchDelete { get; set; }
        public bool? SyncInsert { get; set; }
        public bool? SyncUpdate { get; set; }
        public bool? SyncDelete { get; set; }
    }
}
