using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class Crm
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public int? ProviderId { get; set; }
        public string WhichInbox { get; set; }
        public string MemberNo { get; set; }
        public string ClientType { get; set; }
        public string CrmType { get; set; }
        public string InboxSentDraftDelete { get; set; }
        public string Subject { get; set; }
        public string LogType { get; set; }
        public string LogOutcome { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string Description { get; set; }
        public string BodyPreview { get; set; }
        public string Username { get; set; }
        public string AssignTo { get; set; }
        public string SentFromName { get; set; }
        public string SentFromAddress { get; set; }
        public string SentTo { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string HasAttachment { get; set; }
        public string Attachments { get; set; }
        public string EmailRead { get; set; }
        public int ParentId { get; set; }
        public string ParentType { get; set; }
        public string InExEmail { get; set; }
        public string TaskTicketNumber { get; set; }
        public string Notification { get; set; }
        public string MedicalNon { get; set; }
        public bool? Sent { get; set; }
        public bool? FailCounts { get; set; }
        public int? UserId { get; set; }
    }
}
