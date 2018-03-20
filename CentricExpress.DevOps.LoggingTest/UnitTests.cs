using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentricExpress.DevOps.Logging;

namespace CentricExpress.DevOps.LoggingTest
{
    [TestClass]
    public class UnitTests
    { 
        [TestMethod]
        public void ShouldThrowException_WhenParametersAreNull()
        {
            //Arrange
            var log = new LogInFile();

            //Act            
            Action action = () => { log.Run(null, null); };

            //Assert
            Assert.ThrowsException<ArgumentNullException>(action);
        }

        [TestMethod]
        public void ShouldThrowException_WhenParametersAreEmptyStrings()
        {
            //Arrange
            var log = new LogInFile();

            //Act            
            Action action = () => { log.Run(string.Empty, string.Empty); };

            //Assert
            Assert.ThrowsException<ArgumentException>(action); // pass
            //Assert.ThrowsException<Exception>(action); // fail
        }
    }
}
