using System;
using System.IO;
 public class FileIO{
    public void FileHandling(){
    
        string fileName= "file.txt";
        if(File.Exists(fileName))
{
     string fileContent= File.ReadAllText(fileName);
            Console.WriteLine(fileContent);

}
File.WriteAllText(fileName,"this is just txt file");
      

    }
public void LearnFileInfo(){
                 string fileName = "file.txt";
                 FileInfo fileInfo = new FileInfo(fileName);
                 var size = fileInfo.Length;
                 var createDate = fileInfo.CreationTime;
                 Console.WriteLine($"file size:{size}");
                 Console.WriteLine($"Created:{createDate}");


    }
    public void LearnDirectories(){
        string directoryName ="A";
        Directory.CreateDirectory(directoryName);
        
    }
}