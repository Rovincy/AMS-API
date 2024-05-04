using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class FileAttachment
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public string Filename { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public string Tags { get; set; }
        public int? UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
