using Lol_AutoRecorder.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lol_AutoRecorder.Wrappers
{
    public class InputOutputWrapper : IInputOutputWrapper
    {
        public string GetFullPath(string path)
        {
            return Path.GetFullPath(path);
        }

        public DirectoryInfo GetDirectoryInfo(string rootPath, string pattern)
        {
            return new DirectoryInfo(rootPath).GetDirectories(pattern).OrderByDescending(directory => directory.LastWriteTime).First();
        }

        public string GetFile(string path, string pattern)
        {
            return Directory.GetFiles(path, pattern).SingleOrDefault();
        }

        public List<string> GetLinesContainingMatchingWords(string filePath, List<string> matchingWords)
        {
            var playersInfo = new List<string>();
            using (var fileStream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var streamReader = new StreamReader(fileStream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (matchingWords.Any(word => line.Contains(word))) playersInfo.Add(line);
                }
            }
            return playersInfo;
        }
    }
}
