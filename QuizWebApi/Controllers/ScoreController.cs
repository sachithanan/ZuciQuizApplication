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
        
       
    }
}
