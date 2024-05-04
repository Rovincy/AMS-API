using AutoMapper;
using DCI_TSP_API.Dto.Parents;
using DCI_TSP_API.Dto.PaymentAdvice;
using DCI_TSP_API.RxModels;
using DCI_TSP_API.UserModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace DCI_TSP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentAdjustmentController : Controller
    {
        private readonly AfsContext _context;
        private readonly RxDBContext _RxContext;
        private readonly IMapper mapper;
        public PaymentAdjustmentController(AfsContext context, RxDBContext RxContext, IMapper mapper)
        {
            _context = context;
            _RxContext = RxContext;
            this.mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult<PaymentAdvice>> AddPaymentAdjustment(PaymentAdviceCreateDto paymentAdviceDto)
        {
            var paymentAdjustment = mapper.Map<PaymentAdvice>(paymentAdviceDto);
            //paymentAdjustment.Month = DateTime.UtcNow;
            //paymentAdjustment.Timestamp = DateTime.UtcNow;
            await _context.PaymentAdvices.AddAsync(paymentAdjustment);
            //await _context.PaymentAdvices.AddAsync(paymentAdjustment);
            await _context.SaveChangesAsync();
            //await _context.SaveChangesAsync();

            return Ok(paymentAdjustment.Id);

        }
    }
}
