using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolderReport;

namespace FolderUnitTests
{
    [TestClass]
    public class UnitTestFolderReport
    {
        [TestMethod]
        public void TestCreateEmptyReport()
        {
            var result = new HtmlReportBuilder().Build();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestCreateNullStatisticReport()
        {
            var result = new HtmlReportBuilder()
                .AddStatistic(null)
                .Build();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestCreateNullFolderReport()
        {
            var result = new HtmlReportBuilder()
                .AddFolderList(null)
                .Build();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestCreateNullReport()
        {
            var result = new HtmlReportBuilder()
                .AddStatistic(null)
                .AddFolderList(null)
                .Build();

            Assert.IsNotNull(result);
        }
    }
}
