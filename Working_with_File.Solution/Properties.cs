
class Property
{
    static void Main(string[] args)
    {
        string path = "D://Documents/file3.txt";

        FileInfo fileInfo = new FileInfo(path);

        if (fileInfo.Exists)
        {
            Console.WriteLine(fileInfo.IsReadOnly);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.CreationTime);
            Console.WriteLine(fileInfo.LastWriteTime);
            Console.WriteLine(fileInfo.Extension);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.Length);
            Console.WriteLine(fileInfo.UnixFileMode);
            Console.WriteLine(fileInfo.Attributes);
            Console.WriteLine(fileInfo.LastAccessTime);
            Console.WriteLine(fileInfo.Directory);
            Console.WriteLine(fileInfo.DirectoryName);

        }

    }
}


