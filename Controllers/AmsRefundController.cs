﻿using AutoMapper;
using DCI_TSP_API.Dto.Banks;
using DCI_TSP_API.Dto.MemberRoles;
using DCI_TSP_API.Dto.ParentRole;
using DCI_TSP_API.Dto.Parents;
using DCI_TSP_API.RxModels;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmsRefundController : Controller
    {
        private readonly AfsContext _context;
        private readonly IMapper mapper;
        public AmsRefundController(AfsContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmsRefund>>> GetRefunds()
        {
            List<AmsRefund> refunds = await _context.AmsRefunds.ToListAsync();
            return Ok(refunds);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<AmsRefund>>> AddCall(AmsRefundCreateDto refundDto)
        {
            List<AmsRefund> data = await _context.AmsRefunds.Where(c => c.RefundCode== refundDto.RefundCode&& c.MemberNumber == refundDto.MemberNumber).ToListAsync();
            //croDto.LastUpdate = DateTime.Now;
            if (refundDto.Role== "Refund Officer") {
                refundDto.LastWorkedOnBy = refundDto.RefundOfficer;
                refundDto.LastWorkedOnAt = DateTime.Now;
            refundDto.RefundOfficerTimestamp= DateTime.Now;
            }else if (refundDto.Role== "Claims Officer")
            {
                refundDto.LastWorkedOnBy = refundDto.ClaimRefundOfficer;
                refundDto.LastWorkedOnAt = DateTime.Now;
                refundDto.ClaimRefundOfficerTimestamp = DateTime.Now;
            }else if(refundDto.Role== "Audit Officer")
            {
                refundDto.LastWorkedOnBy = refundDto.AuditOfficer;
                refundDto.LastWorkedOnAt = DateTime.Now;
                refundDto.AuditOfficerTimestamp = DateTime.Now;
            }else if(refundDto.Role== "Admin_Finance")
            {
                refundDto.LastWorkedOnBy = refundDto.FinanceOfficer;
                refundDto.LastWorkedOnAt = DateTime.Now;
                refundDto.FinanceOfficerTimestamp = DateTime.Now;
            }else if(refundDto.Role== "Vetting Officer")
            {
                refundDto.LastWorkedOnBy = refundDto.VettingOfficer;
                refundDto.LastWorkedOnAt = DateTime.Now;
                refundDto.VettingTimestamp = DateTime.Now;
            }else if(refundDto.Role== "FrontDesk")
            {
                refundDto.LastWorkedOnBy = refundDto.FrontDeskOfficer;
                refundDto.LastWorkedOnAt = DateTime.Now;
                refundDto.FrontDeskTimestamp = DateTime.Now;
            }
            if (data.Any())
            {
                foreach (var item in data)
                {
                    item.AmountClaimed = refundDto.AmountClaimed;
                    item.AmountAwarded = refundDto.AmountAwarded;
                    item.PhoneNumber = refundDto.PhoneNumber;
                    item.BatchCode = refundDto.BatchCode;
                    item.Receipient = refundDto.Receipient;
                    item.ReceptionDate = refundDto.ReceptionDate;
                    if (refundDto.Role == "Claims Officer") {
                        item.ClaimRefundOfficer = refundDto.ClaimRefundOfficer;
                        item.ClaimRefundOfficerComments = refundDto.ClaimRefundOfficerComments;
                        item.ClaimRefundOfficerDecision = refundDto.ClaimRefundOfficerDecision;
                        item.PaymentMethod = refundDto.PaymentMethod;
                        item.ClaimRefundOfficerTimestamp = refundDto.ClaimRefundOfficerTimestamp;
                    }else if (refundDto.Role == "Vetting Officer")
                    {
                        item.VettingOfficer = refundDto.VettingOfficer;
                        item.VettingStatus = refundDto.VettingStatus;
                        item.VettingTimestamp = refundDto.VettingTimestamp;
                    }
                    else if (refundDto.Role == "Audit Officer")
                    {
                        item.AuditOfficer = refundDto.AuditOfficer;
                        item.AuditOfficerComments = refundDto.AuditOfficerComments;
                        item.AuditOfficerDecision = refundDto.AuditOfficerDecision;
                        item.AuditOfficerTimestamp = refundDto.AuditOfficerTimestamp;
                    }
                    else if (refundDto.Role == "Admin_Finance")
                    {
                        item.FinanceOfficer = refundDto.FinanceOfficer;
                        item.FinanceOfficerComments = refundDto.FinanceOfficerComments;
                        item.FinanceOfficerTimestamp = refundDto.FinanceOfficerTimestamp;
                    }
                    else if (refundDto.Role == "FrontDesk")
                    {
                        item.FrontDeskOfficer = refundDto.FrontDeskOfficer;
                        item.FrontDeskTimestamp = refundDto.FrontDeskTimestamp;
                        item.Dispatch = refundDto.Dispatch;
                        item.DispatchTimestamp = refundDto.DispatchTimestamp;
                    };
                    //item.Comments = refundDto.Comments;
                }
                _context.AmsRefunds.UpdateRange(data);
                //_context.SaveChanges();
            }
            else
            {
                //refundDto.RefundOfficerTimestamp = DateTime.Now;
            var refund = mapper.Map<AmsRefund>(refundDto);
            await _context.AmsRefunds.AddAsync(refund);
            }
            await _context.SaveChangesAsync();

            return Ok();
        }
        //[HttpDelete]
        //public async Task<ActionResult<AfsCRM>> DeleteCall(int id)
        //{

        //    var crm = await _context.AfsCRMs.FindAsync(id);
        //    _context.AfsCRMs.Remove(crm!);
        //    await _context.SaveChangesAsync();

        //    return Ok();
        //}
    
    }
}
