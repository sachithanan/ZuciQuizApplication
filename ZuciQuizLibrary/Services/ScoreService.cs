﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZuciQuizLibrary.DataAccessLayer;
using ZuciQuizLibrary.DataAccessLayer.Interfaces;
using ZuciQuizLibrary.Models;
using ZuciQuizLibrary.Services.Interfaces;

namespace ZuciQuizLibrary.Services
{
    public class ScoreService : IScoreService
    {
        private readonly IScoreRepository _scoreRepository;
        public ScoreService(IScoreRepository scoreRepository)
        {
            _scoreRepository = scoreRepository;
        }

        public async Task InsertScore(Score score)
        {
            await _scoreRepository.InsertScore(score);
        }
    }
}
