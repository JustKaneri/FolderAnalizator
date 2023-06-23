using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FolderScanner.Models;

namespace FolderScanner
{
    public class FolderFactory
    {
        private FolderStatistic _statistic { get; set; }

        public FolderFactory()
        {
            _statistic = new FolderStatistic();
        }

        /// <summary>
        /// Get total info about current folder and sub-folder
        /// </summary>
        /// <param name="pathFolder"></param>
        /// <returns></returns>
        public Folder GetFolder(string pathFolder)
        {
            if (!Directory.Exists(pathFolder))
                return null;

            DirectoryInfo currentFolder = new DirectoryInfo(pathFolder);

            List<MediaFile> files = new List<MediaFile>();
            List<Folder> folders = new List<Folder>();
            double totalSize = 0;

            AddFile(ref totalSize, currentFolder, files);

            AddFolder(ref totalSize, currentFolder, folders);

            var result = new Folder(currentFolder.Name, totalSize);
            result.Files = files;
            result.Folders = folders;
            
            return result;
        }

        /// <summary>
        /// Get sorted statistic for current folder
        /// </summary>
        /// <returns></returns>
        public FolderStatistic GetFolderStatistic()
        {
            _statistic.CountType = _statistic.CountType.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            _statistic.TotalSizeType = _statistic.TotalSizeType.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            return _statistic;
        }
        
        private void AddFile(ref double size, DirectoryInfo directory,List<MediaFile> files)
        {
            foreach (var item in directory.GetFiles())
            {
                MediaFile mediaFile = new MediaFile(item.Name, item.Length, item.Extension);
                size += item.Length;
                AddDataStatistic(item);
                files.Add(mediaFile);
            }
        }

        private void AddFolder(ref double size,DirectoryInfo directory,List<Folder> folders)
        {
            foreach (var item in directory.GetDirectories())
            {
                Folder folder = GetFolder(item.FullName);
                size += folder.Size;
                folders.Add(folder);
            }
        }

        private void AddDataStatistic(FileInfo info)
        {
            string exten = info.Extension;

            if (_statistic.CountType.ContainsKey(exten))
            {
                _statistic.CountType[exten] += 1;
                _statistic.TotalSizeType[exten] += info.Length;
            }
            else
            {
                _statistic.CountType.Add(exten, 1);
                _statistic.TotalSizeType.Add(exten, info.Length);
            }
        }
    }
}
