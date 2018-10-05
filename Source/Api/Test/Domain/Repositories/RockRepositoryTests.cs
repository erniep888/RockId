using AutoFixture.Xunit2;
using Moq;
using RockId.Domain.Models;
using RockId.Domain.Repositories;
using RockId.Test.Common;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RockId.Test.Domain.Repositories
{
    public class RockRepositoryTests
    {
        [Theory]
        [AutoMoqData]
        public void ShouldAllowFindingByName(String name, IRockRepository sut)
        {
            Rock rock = sut.FindByName(name);
            Assert.NotNull(rock);
        }
    }
}