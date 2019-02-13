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

        // TODO: We should have at least one test here per type of DataRef, so that
        // we test all of the code generation paths.  We've got a test for the string
        // path here so far.

        // TODO: Tests commented out until the automatic generation is part of the
        // build process; the properties we want to access won't exist at runtime
        // if you haven't generated the files otherwise.

        // [Fact]
        // public void TailNumber()
        // {
        //     //arrange
        //     var target = new SimDataRefs(mockData.Object);
        //     mockData.Setup(m => m.GetString(It.IsAny<string>()))
        //         .Returns(mockDataString.Object);

        //     //act
        //     var result = target.aircraft.view.acf_tailnum;

        //     //assert
        //     Assert.Equal(tailNum, result.Value);
        //     mockData.Verify(m => m.GetString("sim/aircraft/view/acf_tailnum"));
        // }
    }
}
