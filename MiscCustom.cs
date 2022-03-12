using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChiffrement
{
    class MiscCustom
    {
        public static string[] getAllFilesFromFolder(string path, string ignoreExtensionsToProcess)
        {
            string[] exludedExtensions = processIgnoreExtensions(ignoreExtensionsToProcess);
            // We get the base files and folders in the selected folder
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories)
                //.Where( s => !s.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase) ).ToArray();
                .Where(file => !exludedExtensions.Any(x => file.EndsWith(x, StringComparison.OrdinalIgnoreCase))).ToArray();
            return files;
        }

        private static string[] processIgnoreExtensions(string ignoreExtensions)
        {
            string[] extensions = ignoreExtensions.Split(",".ToCharArray());
            for (int i = 0; i < extensions.Length; i++)
            {
                extensions[i] = "." + extensions[i];
            }
            return extensions;
        }
    }
}
