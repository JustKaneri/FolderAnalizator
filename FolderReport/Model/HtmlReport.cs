using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderReport.Model
{
    public class HtmlReport
    {
        public string HtmlContent { get; set; }

        public HtmlReport()
        {
            HtmlContent = "<!DOCTYPE html><html><head><meta charset = \"utf-8\" >" +
                "<title>Report</title></head><style type=\"text/css\" >" +
                "body{ width: 100%; height: 100%; padding: 0; margin: 0;}" +
                "h2{ text-align: center; color: green; }" +
                "h3{ text-align: center; }.statistic{ width: 100vw; max-width: 100%; min-height: 300px; height: 50vh; display: flex; justify-content: center; flex-direction: column; }" +
                ".statistic-list { height: 70 %; display: flex; " +
                "overflow-y: scroll; justify-content: center; flex-direction: row; " +
                "justify-content: space-evenly; }.folder{ width: 100vw; height: auto; display: flex; " +
                "align-items: center; justify-content: center; flex-direction: column; }" +
                ".folder-list{ overflow-y: scroll;display: flex; justify-content: center;}" +
                "</style><body> ";
        }

        public void Close()
        {
            HtmlContent += "</body> </html> ";
        }
    }
}
