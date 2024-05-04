using AutoMapper;
using DCI_TSP_API.Dto.MemberRoles;
using DCI_TSP_API.Dto.ParentRole;
using DCI_TSP_API.Dto.Parents;
using DCI_TSP_API.Dto.PaymentAdvice;
using DCI_TSP_API.RxModels;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderPaymentsController : Controller
    {
        private readonly AfsContext _context;
        //private readonly RxDBContext _context;
        private readonly IMapper mapper;
        //public ProviderPaymentsController(RxDBContext context, IMapper mapper)
        public ProviderPaymentsController(AfsContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentAdvice>>> GetProviderPayments()
        {
            //List<PaymentAdvice> paymentAdvice = await _context.PaymentAdvices.ToListAsync();
            List<PaymentAdvice> paymentAdvice = await _context.PaymentAdvices.OrderByDescending(pa => pa.Id).ToListAsync();
            return Ok(paymentAdvice);
        }
        [HttpPut]
        public async Task<ActionResult<IEnumerable<PaymentAdvice>>> EditProviderPayment(PaymentAdviceCreateDto payments)
        {
            List<PaymentAdvice> paymentAdvice = await _context.PaymentAdvices.Where(x=>x.Id==payments.Id).ToListAsync();
            foreach(var value in paymentAdvice)
            {
                value.Amount = (double)payments.Amount!;
                value.Description = payments.Description!;
                value.CheckNumber = payments.CheckNumber;
                value.BankId = payments.BankId;
                value.Type = payments.Type;
                value.Month = payments.Timestamp;
                value.Timestamp = payments.Timestamp;
            }
            _context.PaymentAdvices.UpdateRange(paymentAdvice);
            _context.SaveChanges();
            return Ok(paymentAdvice[0].Id);
        }

        //[HttpPost]
        //public async Task<ActionResult<IEnumerable<Parent>>> AddParentRoles(ParentCreateDto parentDto)
        //{
        //    var parent = mapper.Map<Parent>(parentDto);
        //    await _context.Parents.AddAsync(parent);
        //    await _context.SaveChangesAsync();

        //    return Ok(parent.Id);
        //}

        //[HttpDelete]
        //public async Task<ActionResult<Parent>> DeletePaymentAdive(int id)
        //{

        //    var parent = await _context.Parents.FindAsync(id);
        //    _context.Parents.Remove(parent!);
        //    await _context.SaveChangesAsync();

        //    return Ok();
        //}
    }
}
