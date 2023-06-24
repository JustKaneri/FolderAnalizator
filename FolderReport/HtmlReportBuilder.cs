using FolderReport.Html;
using FolderReport.Interface;
using FolderReport.Model;
using FolderScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderReport
{
    public class HtmlReportBuilder : IBuilder<HtmlReport>
    {
        private HtmlReport _report { get; set; }


        public HtmlReportBuilder()
        {
            _report = new HtmlReport();
        }

        public HtmlReportBuilder AddStatistic(FolderStatistic statistic)
        {
            _report.HtmlContent += "<div class=\"statistic\"> <h2> Статистика </h2> " +
                 "<div class=\"statistic-list\"> " +
                 "<div> <h3>Формат файлов</h3>" +
                    CreatorHtmlElement.InsertNumList(statistic.CountType) +
                 "</div> " +
                 "<div> <h3>Размер файлов</h3> " +
                    CreatorHtmlElement.InsertNumList(statistic)+
                 "</div>" +
                 "</div> </div>";


            return this;
        }

        public HtmlReportBuilder AddFolderList(Folder folder)
        {
            _report.HtmlContent += "<div class=\"folder\"> " +
                $" <h2> Содержание {folder.Name} {folder.GetSize()} </h2> <div class=\"folder-list\">" +
                    CreatorHtmlElement.CreateListFolder(folder)+
                "</div> " +
                "</div> ";

            return this;
        }

        public HtmlReport Build()
        {
            _report.Close();
            return _report;
        }
    }
}
