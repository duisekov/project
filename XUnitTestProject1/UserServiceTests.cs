using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using System.Collections.Generic;
using project.IInterfaces;
using project.Services;
using project.Models;
using System.Linq.Expressions;

namespace XUnitTestProject1
{
    public class UserServiceTests
    {
        [Fact]
        public async Task AddTest()
        {
            var fakeRepository = Mock.Of<IUserRepository>();
            var userService = new UserService(fakeRepository);

            var user = new User() { Login = "login", Password = "password" };
            await userService.AddAndSave(user);
        }

        [Fact]
        public async Task GetUsersTest()
        {
            var users = new List<User>
            {
                new User() { Login = "login1", Password = "password1" },
                new User() { Login = "login2", Password = "password2" },
            };

            var fakeRepositoryMock = new Mock<IUserRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(users);


            var userService = new UserService(fakeRepositoryMock.Object);

            var resultUsers = await userService.GetUsers();

            Assert.Collection(resultUsers, user =>
            {
                Assert.Equal("login1", user.Login);
            },
            user =>
            {
                Assert.Equal("login2", user.Login);
            });
        }

        [Fact]
        public async Task SearchTest()
        {
            var users = new List<User>
            {
                new User() { Login = "login1" },
                new User() { Login = "login2" },
            };

            var fakeRepositoryMock = new Mock<IUserRepository>();
            fakeRepositoryMock.Setup(x => x.GetUsers(It.IsAny<Expression<Func<User, bool>>>())).ReturnsAsync(users);


            var userService = new UserService(fakeRepositoryMock.Object);

            var resultUsers = await userService.Search("TEST");

            Assert.Collection(resultUsers, user =>
            {
                Assert.Equal("login1", user.Login);
            },
            user =>
            {
                Assert.Equal("login2", user.Login);
            });
        }
    }
}
