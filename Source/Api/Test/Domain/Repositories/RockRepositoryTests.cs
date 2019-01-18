using Microsoft.EntityFrameworkCore;
using AutoFixture;
using AutoFixture.Xunit2;
using Moq;
using RockId.Domain.Models;
using RockId.Domain.Repositories;
using RockId.Domain.Repositories.Implementations;
using RockId.Test.Common;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace RockId.Test.Domain.Repositories
{
    public class RockRepositoryTests
    {
        [Theory]
        [AutoMoqData]
        public async void ShouldFindByGuid_AutoMoqData(Guid id, IRockRepository sut)
        {
            // Arrange
            // Act
            Rock rock = await sut.FindById(id);
            // Assert
            Assert.NotNull(rock);
        }

        [Fact]
        public async void ShouldFindByGuid()
        {
            // Arrange
            var fixture = new Fixture();
            var targetGuid = Guid.NewGuid();
            var targetRock = fixture.Build<Rock>().With(u => u.Id, targetGuid).Create();
            IQueryable<Rock> rocks = new List<Rock>
            {
                fixture.Build<Rock>().With(u => u.Id, Guid.NewGuid()).Create(),
                targetRock,
                fixture.Build<Rock>().With(u => u.Id, Guid.NewGuid()).Create()
            }.AsQueryable<Rock>();


            var mockSet = MockDbSet.CreateDbSetMock<Rock>(rocks);

            var mockContext = new Mock<RockIdDbContext>();
            mockContext.Setup(c => c.Rocks).Returns(mockSet.Object);

            var sut = new RockRepository(mockContext.Object);

            // Act
            Rock rock = await sut.FindById(targetGuid);

            // Assert
            Assert.Equal(rock, targetRock);
        }

    }


}