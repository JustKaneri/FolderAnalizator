using FolderScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderReport.Html
{
    public class CreatorHtmlElement
    {
        /// <summary>
        /// Create list for show avg size Media format file
        /// </summary>
        /// <param name="statistic"></param>
        /// <returns></returns>
        public static string InsertNumList(FolderStatistic statistic)
        {
            string result = "<ol>";

            foreach (var item in statistic.TotalSizeType)
            {
                result += $"<li> {item.Key}  {GetSize(item.Value / statistic.CountType[item.Key])} </li >";
            }

            return result += "</ol>";
        }

        private static string GetSize(double size)
        {
            string[] extension = { "Байт", "Кб", "Mб", "Гб" };
            int indexExtenc = 0;
            while (size > 1024)
            {
                size = size / 1024.0;
                indexExtenc++;
            }
            return string.Format("{0:f1} {1}", size, extension[indexExtenc]);
        }

        /// <summary>
        /// Create list for show folder content
        /// </summary>
        /// <param name="folder"></param>
        /// <returns></returns>
        public static string CreateListFolder(Folder folder)
        {
            string result = "<ul> ";
      
            foreach (var item in folder.Files)
            {
                result += $"<li>{item.Name}  {item.GetSize()}</li>";
            }

            foreach (var item in folder.Folders)
            {
                result += $"<li>{item.Name}  {item.GetSize()}</li >";
                result += CreateListFolder(item);
            }

            
            result += "</ul > ";

            return result;
        }

        /// <summary>
        /// Create list for show count Media type file
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static string InsertNumList(Dictionary<string, int> collection)
        {
            string result = "<ol>";

            int sumCount = collection.Sum((d) => d.Value);

            foreach (var item in collection)
            {
                result += $"<li> {item.Key} - {item.Value} - {item.Value * 100.0 / sumCount:f1}% </li >";
            }

            return result += "</ol>";
        }
    }
}
