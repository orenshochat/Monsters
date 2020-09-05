using Microsoft.Extensions.Logging;
using Monsters.Service.BL;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using DalModels = Monsters.DAL.Models;
using ViewModels = Monsters.View.Models;

namespace Monster.Service.Tests
{
    public class MonsterApiTests
    {
        private Mock<IMonsterRepository> _repositoryMock = new Mock<IMonsterRepository>();
        private Mock<ILogger<MonsterApi>> _loggerMock = new Mock<ILogger<MonsterApi>>();
        private readonly MonsterApi _api;

        public MonsterApiTests()
        {
            _api = new MonsterApi(_repositoryMock.Object, _loggerMock.Object);
        }
        [SetUp]
        public void Setup()
        {
             
        }

        [Test]
        public async Task GetAvailbleDoorsAsync_AvailbleDoors_ReturnsSuccessAndDoors()
        {
            DateTime date1 = DateTime.MinValue;
            DateTime date2 = DateTime.Today;
            IEnumerable<DalModels.Door> doors = new List<DalModels.Door>()
            {
                new DalModels.Door() {Id = "Door1", KidBehindDoorName = "Nisim", LastScare = DateTime.Today, Power = 50},
                new DalModels.Door() {Id = "Door2", KidBehindDoorName = "Noam", LastScare = DateTime.Today, Power = 60}
            };

            _repositoryMock.Setup(x => x.GetDoorsAsync(date1, date2))
                .ReturnsAsync(doors);

            Monsters.Service.Models.BlTResult<IEnumerable<ViewModels.Door>> result = await _api.GetAvailbleDoorsAsync().ConfigureAwait(false);

            Assert.IsTrue(result.IsSuccess);
            Assert.AreEqual(2, result.Data.Count()); 
        }

        [Test]
        public async Task GetAvailbleDoorsAsync_NoDoorsAvailble_ReturnsSuccess()
        {
            DateTime date1 = DateTime.MinValue;
            DateTime date2 = DateTime.Today;
            IEnumerable<DalModels.Door> doors = null;

            _repositoryMock.Setup(x => x.GetDoorsAsync(date1, date2))
                .ReturnsAsync(doors);

            Monsters.Service.Models.BlTResult<IEnumerable<ViewModels.Door>> result = await _api.GetAvailbleDoorsAsync().ConfigureAwait(false);

            Assert.IsTrue(result.IsSuccess);
            Assert.IsNull(result.Data);
        }

        [Test]
        public async Task GetAvailbleDoorsAsync_RepositoryThrows_ReturnsError()
        {
            DateTime date1 = DateTime.MinValue;
            DateTime date2 = DateTime.Today;
            //IEnumerable<DalModels.Door> doors = null;

            _repositoryMock.Setup(x => x.GetDoorsAsync(date1, date2))
                .Throws(new Exception("Somthing bad happened")); 

            Monsters.Service.Models.BlTResult<IEnumerable<ViewModels.Door>> result = await _api.GetAvailbleDoorsAsync().ConfigureAwait(false);

            Assert.IsFalse(result.IsSuccess);
            Assert.IsNull(result.Data);
            Assert.IsTrue(result.ErrorMsg.Contains("Somthing bad happened")); 


        }
    }
}