using System;
using Xunit;
using Moq;

namespace XPNet.CLR.Tests
{
    public class SimDatarefsTests : IDisposable
    {
        private const string tailNum = "1234";
        private Mock<IXPlaneData> mockData;
        private Mock<IXPDataRef<string>> mockDataString;
        
        public SimDatarefsTests()
        {
            mockData = new Mock<IXPlaneData>();
            mockDataString = new Mock<IXPDataRef<string>>();
            mockDataString.SetupGet(m => m.Value)
                .Returns(tailNum);
        }

        public void Dispose()
        { }

        [Fact]
        public void TailNumber()
        {
            //arrange
            var target = new SimDatarefs(mockData.Object);
            mockData.Setup(m => m.GetString(It.IsAny<string>()))
                .Returns(mockDataString.Object);

            //act
            var result = target.Aircraft.View.TailNumber;

            //assert
            Assert.Equal(tailNum, result.Value);
            mockData.Verify(m => m.GetString(It.IsAny<string>()));
        }
    }
}
