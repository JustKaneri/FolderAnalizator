using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FolderScanner.Models;
using FolderScanner;
using System.IO;

namespace FolderUnitTests
{
    [TestClass]
    public class UnitTestFolderScanner
    {
        [TestMethod]
        public void TestNotExistDirectory()
        {
            var factory = new FolderFactory();
            var result = factory.GetFolder("123");

            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestExistDirectory()
        {
            var factory = new FolderFactory();
            var result = factory.GetFolder(Directory.GetCurrentDirectory());

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestNullParam()
        {
            var factory = new FolderFactory();
            var result = factory.GetFolder(null);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestStatisticNotExistDirectory()
        {
            var factory = new FolderFactory();
            factory.GetFolder("123");
            var result = factory.GetFolderStatistic();

            Assert.AreEqual(result.CountType.Count, 0);
        }

        [TestMethod]
        public void TestStatisticExistDirectory()
        {
            var factory = new FolderFactory();
            factory.GetFolder(Directory.GetCurrentDirectory());
            var result = factory.GetFolderStatistic();

            Assert.AreEqual(result.CountType.Count > 0, true);
        }
    }
}
