using RockId.Qarp.Api.Service;
using RockId.Qarp.DataMapper.Models;
using RockId.Qarp.DataMapper.Repositories;
using System;
using System.Collections.Generic;


namespace RockId.Qarp.Api.Services.Implementations
{
    public class QarpService : IQarpService
    {
        private IQarpRepository _qarpRepository;

        public QarpService(IQarpRepository qarpRepository)
        {
            _qarpRepository = qarpRepository;
        }

        public ICollection<DataMapper.Models.Qarp> GetCurrentAnswers(int currentQuestionId)
        {
            return _qarpRepository.FindByParentId(currentQuestionId);
        }

        public DataMapper.Models.Qarp GetNextQuestion(int? selectedAnswerQarpId)
        {
            ValidateForNextQuestion(selectedAnswerQarpId);
            return GetSingleQarp(_qarpRepository.FindByParentId(selectedAnswerQarpId));
        }

        public DataMapper.Models.Qarp GetPreviousQuestion(int? qarpId)
        {
            throw new NotImplementedException();
        }

        private DataMapper.Models.Qarp GetSingleQarp(IList<DataMapper.Models.Qarp> qarps)
        {
            if (qarps != null && qarps.Count == 1)
                return qarps[0];
            else
            {
                if (qarps == null)
                    throw new QarpException("Qarps collection was empty.");
                else
                    throw new QarpException("Expected only one in the Qarps collection, but found : " + qarps.Count);
            }
                
        }

        
        // Next question expects the qarpId to be an answer.
        private void ValidateForNextQuestion(int? selectedAnswerQarpId)
        {
            if (selectedAnswerQarpId.HasValue)
            {
                var qarp = _qarpRepository.FindById(selectedAnswerQarpId.Value);
                if (qarp.IsQuestion)
                    throw new QarpException("NextQuestion expected an answer parameter.");

            }
        }
    }
}
