using AutoMapper;
using DCI_TSP_API.Dto.MemberRoles;
using DCI_TSP_API.Dto.Members;
using DCI_TSP_API.Dto.ParentRole;
using DCI_TSP_API.Dto.Parents;
using DCI_TSP_API.Dto.User;
using DCI_TSP_API.UserModels;
using DCI_TSP_API.Dto.Banks;
using DCI_TSP_API.Dto.PaymentAdvice;
using DCI_TSP_API.Dto.CompanyPremiumPlan;
using DCI_TSP_API.Dto.AuditTrail;
using DCI_TSP_API.Dto.Messages;
//using DCI_TSP_API.RxModels;

namespace DCI_TSP_API.Helpers
{
    public class AutoMappers:Profile
    {
        public AutoMappers() {
            CreateMap<UserCreateDto, User>().ReverseMap();
            CreateMap<UserRoleCreateDto, Role>().ReverseMap();
            CreateMap<CompanyPremiumPlanDto, CompanyPremiumPlan>().ReverseMap();
            CreateMap<AmsCrmCreateDto, AmsCRM>().ReverseMap();
            CreateMap<AmsCroCreateDto, AmsCro>().ReverseMap();
            CreateMap<AmsHspCreateDto, AmsHsp>().ReverseMap();
            CreateMap<AmsHspCreateDto, AmsHspHistory>().ReverseMap();
            CreateMap<AmsRefundCreateDto, AmsRefund>().ReverseMap();
            CreateMap<AuditTrailDto, AuditTrail>().ReverseMap();
            CreateMap<MessageCreateDto, Messages>().ReverseMap();

            CreateMap<PaymentAdviceCreateDto, DCI_TSP_API.RxModels.PaymentAdvice>().ReverseMap();
            //CreateMap<PaymentAdviceCreateDto, DCI_TSP_API.UserModels.PaymentAdvice>().ReverseMap();
            CreateMap<BankCreateDto, Bank>().ReverseMap();
        }
    }
}
