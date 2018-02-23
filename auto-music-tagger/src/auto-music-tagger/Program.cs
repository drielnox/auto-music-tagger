// <copyright file="Program.cs" company="AMT">
// Copyright (c) AMT. All rights reserved.
// </copyright>

namespace AMT
{
    using data;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Escriba la ruta del directorio a leer: ");

            string pathToRead = Console.ReadLine();

            if (pathToRead == null)
            {
                throw new ArgumentNullException(nameof(pathToRead));
            }

            if (string.IsNullOrWhiteSpace(pathToRead))
            {
                throw new ArgumentException("Path is empty.", nameof(pathToRead));
            }

            if (!Directory.Exists(pathToRead))
            {
                throw new DirectoryNotFoundException();
            }

            var subdirs = Directory.EnumerateDirectories(pathToRead);
            var files = Directory.EnumerateFiles(pathToRead);

            using (var ctx = new ModelContext())
            {

            }

            Console.WriteLine("Lista de subdirectorios: ");
            foreach (string dirName in subdirs)
            {
                Console.WriteLine(">> {0}", dirName);
            }

            Console.WriteLine("Lista de archivos: ");
            foreach (string fileName in files)
            {
                Console.WriteLine(">> {0}", fileName);
            }

            Console.ReadLine();
        }
    }
}
