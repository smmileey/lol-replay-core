using System.Collections.Generic;
using System.IO;

namespace Lol_AutoRecorder.Interfaces
{
    public interface IInputOutputWrapper
    {
        string GetFullPath(string path);

        DirectoryInfo GetDirectoryInfo(string rootPath, string pattern);

        string GetFile(string path, string pattern);

        List<string> GetLinesContainingMatchingWords(string filePath, List<string> matchingWords);
    }
}