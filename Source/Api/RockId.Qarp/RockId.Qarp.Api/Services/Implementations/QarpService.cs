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

        public ICollection<DataMapper.Models.Qarp> GetCurrentAnswers(DataMapper.Models.Qarp qarp)
        {
            throw new NotImplementedException();
        }

        public DataMapper.Models.Qarp GetNextQuestion(DataMapper.Models.Qarp qarp)
        {           
            if (qarp == null)  // this is an attempt to find the root question                
                return GetAndExpectOneQarp(_qarpRepository.FindByParentId(null));
            else
            {
                ValidateForNextQuestion(qarp);
                return GetAndExpectOneQarp(_qarpRepository.FindByParentId(qarp.Id));
            }
        }

        public DataMapper.Models.Qarp GetPreviousQuestion(DataMapper.Models.Qarp qarp)
        {
            throw new NotImplementedException();
        }

        private DataMapper.Models.Qarp GetAndExpectOneQarp(IList<DataMapper.Models.Qarp> qarps)
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

        
        private void ValidateForNextQuestion(DataMapper.Models.Qarp qarp)
        {
            if (qarp.IsQuestion)
                throw new QarpException("NextQuestion expected an answer parameter.");
        }
    }
}
