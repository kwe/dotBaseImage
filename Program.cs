using System;

namespace dotBaseImage
{
    class Program
    {
    static public string ConvertImageToString(string filepath)
    {
      byte[] imageArray = System.IO.File.ReadAllBytes(filepath);
      string base64ImageRepresentation = System.Convert.ToBase64String(imageArray);

      return (base64ImageRepresentation);

    }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(ConvertImageToString("cat.jpg"));
        }


    }
}
