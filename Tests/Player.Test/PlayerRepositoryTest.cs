using AutoMapper;
using Services.ProductAPI.DbContexts;
using Services.ProductAPI.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Player.Test
{
    [TestClass]
    public class PlayerRepositoryTest
    {
        PlayerRepository _playerRepo;
        public void Init()
        {
            ApplicationDbContext applicationDbContext = Mock.Of<ApplicationDbContext>();
            IMapper mapper = Mock.Of<Mapper>();
            _playerRepo = new PlayerRepository(applicationDbContext, mapper);
        }

        [TestMethod]
        public void TestGetPlayers_PlayersExists_AllPlayersRetrieved()
        {
        }

        [TestMethod]
        public void TestGetPlayers_PlayersIsEmpty_EmptyListRetrieved()
        {
        }

        [TestMethod]
        public void TestGetPlayers_WrongValueSentFromClient_MessageWithoutPlayersReturnsToTheUser()
        {
        }

        [TestMethod]
        public void TestGetPlayerById_IdExists_PlayerReturnsToTheUser()
        {
        }

        [TestMethod]
        public void TestGetPlayerById_IdDoesNotExist_MessageWithoutPlayerReturnsToTheUser()
        {
        }

        [TestMethod]
        public void TestGetPlayerById_WrongValueSentFromClient_MessageWithoutPlayerReturnsToTheUser()
        {
        }
    }
}