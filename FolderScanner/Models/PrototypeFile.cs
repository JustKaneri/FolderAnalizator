﻿namespace FolderScanner.Models
{
    public abstract class PrototypeFile
    {
        public string Name { get; }
        public double Size { get; set; }

        public PrototypeFile(string name, double size)
        {
            Name = name;
            Size = size;
        }

        public virtual string GetSize()
        {
            double result = Size;
            string[] extension = { "Байт", "Кб", "Mб", "Гб" };
            int indexExtenc = 0;
            while (Size > 1024)
            {
                Size = Size / 1024.0;
                indexExtenc++;
            }
            return string.Format("{0:f1} {1}", Size, extension[indexExtenc]);
        }
    }
}
