using System.Collections.Generic;
using System.Linq;
using FolderScanner.Models;
using System.Windows.Forms;

namespace FolderAnalizator
{
    public class StatisticRender
    {

        public static void RenderType(ListBox view, Dictionary<string,int> collection)
        {
            view.Items.Clear();

            int sumCount = collection.Sum((d) => d.Value);

            foreach (var item in collection)
            {
                view.Items.Add($"{item.Key} {item.Value * 100.0 / sumCount:f1}%");
            }
        }

        public static void RenderSize(ListBox view, FolderStatistic statistic)
        {
            view.Items.Clear();

            foreach (var item in statistic.TotalSizeType)
            {
                view.Items.Add(item.Key + " " + GetSize(item.Value / statistic.CountType[item.Key]));
            }
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
    }
}
