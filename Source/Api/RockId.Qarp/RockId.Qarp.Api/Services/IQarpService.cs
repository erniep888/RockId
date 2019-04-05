using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RockId.Qarp.Api.Service
{
    public interface IQarpService
    {
        DataMapper.Models.Qarp GetNextQuestion(DataMapper.Models.Qarp qarp);

        ICollection<DataMapper.Models.Qarp> GetCurrentAnswers(DataMapper.Models.Qarp currentQuestion);        

        DataMapper.Models.Qarp GetPreviousQuestion(DataMapper.Models.Qarp qarp);

    }
}
