using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RockId.Qarp.Api.Service
{
    public interface IQarpService
    {
        DataMapper.Models.Qarp GetNextQuestion(int? selectedAnswerQarpId);

        ICollection<DataMapper.Models.Qarp> GetCurrentAnswers(int currentQuestionId);        

        DataMapper.Models.Qarp GetPreviousQuestion(int? qarpId);

    }
}
