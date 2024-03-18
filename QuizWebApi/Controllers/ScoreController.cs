using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZuciQuizLibrary.DataAccessLayer.Interfaces;
using ZuciQuizLibrary.Models;

namespace QuizWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        private readonly IUserAnswerRepository _userAnswerRepository;
        private readonly IScoreRepository _scoreRepository;
        public ScoreController(IUserAnswerRepository userAnswerRepository, IScoreRepository scoreRepository)
        {
            _userAnswerRepository = userAnswerRepository;
            _scoreRepository = scoreRepository;
        }
        [HttpPost]
        public async Task<ActionResult> InsertScore(Score score)
        {
            try
            {
                await _scoreRepository.InsertScore(score);
                return Created($"api/Score/{score.Id}", score);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        /*  [HttpGet("{userId}/{topicId}")]
          public async Task<ActionResult<double>> GetScore(int userId, int topicId)
          {
              try
              {
                 // var correctQuestions = await _userAnswerRepository.GetCorrectUserAnswersForTopic(userId, topicId);
                 // var allUserAnswers = await _userAnswerRepository.GetUserAnswersForTopic(userId, topicId);
                 // int totalQuestions = correctQuestions.Count;
                 // int correctCount = correctQuestions.Count;
                 // double score = (double)correctCount / totalQuestions * 100;
               //   return Ok(score);
              }
              catch (Exception ex)
              {
                  return BadRequest(ex.Message);
              } 

          }*/
    }
}
