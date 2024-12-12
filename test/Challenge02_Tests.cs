using ds_challenge_02.Controllers;

namespace Challenge2Tests;

public class Challenge02_Tests
{
     [Fact]
        public async Task Get_GreetUser()
        {
            // Arrange
            var controller = new DsChallenge02Controller();

            // Act
            var result = controller.GreetUser();

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Any());
        }
}