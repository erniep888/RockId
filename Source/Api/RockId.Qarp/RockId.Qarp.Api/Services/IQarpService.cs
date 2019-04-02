using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RockId.Qarp.Api.Service
{
    interface IQarpService
    {
        DataMapper.Models.Qarp Get(int qarpId);

        DataMapper.Models.Qarp GetRoot();

        ICollection<DataMapper.Models.Qarp> GetPossibleAnswers(int questionId);

        DataMapper.Models.Qarp GetPreviousQuestionByAnswer(DataMapper.Models.Qarp answer);

        DataMapper.Models.Qarp GetPreviousQuestionByQuestion(DataMapper.Models.Qarp question);

        DataMapper.Models.Qarp GetNextQuestion(DataMapper.Models.Qarp answer);
    }
}
