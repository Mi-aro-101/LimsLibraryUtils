using System;
using System.IO;

namespace LimsUtils.Utility;

public class FileReader
{
    public static string ReadFile(string filePath)
    {
        if(!File.Exists(filePath))
        {
            return $"Error: File not found at {filePath}";
        }
        string fileContents = File.ReadAllText(filePath);
        return fileContents;
    }
}