using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace StringResourceDemo.UnitTest
{
    using ViewModels;

    [TestClass]
    public class MainVMTest
    {
        [TestMethod]
        public void FirstTimeTest()
        {
            // Arrange
            var resources = new TestStringResources();
            var keyValueStore = new TestKeyValueStore();

            // Act
            var underTest = new MainVM(resources, keyValueStore);

            // Assert
            Assert.AreEqual(resources.Welcome, underTest.Message);
            Assert.IsFalse(keyValueStore.GetValue("FirstTime", true));
        }

        [TestMethod]
        public void SecondTimeTest()
        {
            // Arrange
            var resources = new TestStringResources();
            var keyValueStore = new TestKeyValueStore();
            keyValueStore.SetValue("FirstTime", false);

            // Act
            var underTest = new MainVM(resources, keyValueStore);

            // Assert
            Assert.AreEqual(resources.HelloAgain, underTest.Message);
            Assert.IsFalse(keyValueStore.GetValue("FirstTime", true));
        }
    }
}
