using AutoMapper;
using InsightLoop.Application.Services;
using InsightLoop.AuthService.Controllers.DTO;
using InsightLoop.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InsightLoop.AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedBackController : ControllerBase
    {
        private readonly FeedbackService _feedBackService;
        private readonly IMapper _mapper;
        public FeedBackController(FeedbackService feedBackService, IMapper mapper)
        {
            _feedBackService = feedBackService;
            _mapper = mapper;
        }
        // GET: api/<FeedBack>
        [HttpGet]
        public IActionResult Get()
        {
            var feedbacks = _feedBackService.GetAll();
            var feedbacksResponse = _mapper.Map<IEnumerable<Feedback>, IEnumerable<GetFeedBackResponse>>(feedbacks);
            return Ok(feedbacksResponse);
        }

        // GET api/<FeedBack>/5
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)//
        {
            var feedBack = _feedBackService.GetFeedbackById(id);
            if (feedBack == null) return NotFound();
            var feedBackResponse = _mapper.Map<Feedback, GetFeedBackResponse>(feedBack);
            return Ok(feedBackResponse);
        }

        // POST api/<FeedBack>
        [HttpPost]
        public IActionResult Post([FromBody] CreateFeedBackRequest value)
        {
            var feedBack = _mapper.Map<CreateFeedBackRequest, Feedback>(value);
            _feedBackService.AddFeedback(feedBack);
            return CreatedAtAction(nameof(GetById), new { id = feedBack.Id }, feedBack);
        }

        // PUT api/<FeedBack>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody]CreateFeedBackRequest value)
        {

            var feedBack = _feedBackService.GetFeedbackById(id);
            if (feedBack == null) return NotFound();
            _mapper.Map(value, feedBack);
            _feedBackService.UpdateFeedback(feedBack);
            return NoContent();
        }

        // DELETE api/<FeedBack>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var feedback = _feedBackService.GetFeedbackById(id);
            if (feedback == null) return NotFound();
            _feedBackService.DeleteFeedback(feedback);
            return NoContent();
        }
    }
}
