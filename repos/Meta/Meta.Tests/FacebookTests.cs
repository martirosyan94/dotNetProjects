using System;
using Xunit;
using Moq;
using Autofac.Extras.Moq;
using Meta;

namespace Meta.Tests
{
    public class FacebookTests
    {
        [Fact]
        public void Test1()
        {
            
            // arrange
            var facebook = new Mock<IFacebook>();
            facebook.Setup(e => e.Register());

            //act
            var socialNetwork = new SocialNetwork(facebook.Object);
            socialNetwork.RegisterUser("User");

            // assert
            facebook.Verify(e => e.Register(), Times.Exactly(1));
            
            /*
            using (var mock = AutoMock.GetLoose())
            {
                // arrange 
                mock.Mock<IFacebook>()
                    .Setup(e => e.Register());

                // act
                var cls = mock.Create<SocialNetwork>();
                cls.RegisterUser("User");

                // assert
                mock.Mock<IFacebook>()
                     .Verify(e => e.Register(), Times.Exactly(1));
            }
            */
            
        }
    }
}
