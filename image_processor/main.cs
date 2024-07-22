using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] filenames;

        if (args.Length > 1)
            filenames = args;
        else
            filenames = Directory.GetFiles("images/", "*.jpg");

        ImageProcessor.Inverse(filenames);
        ImageProcessor.Grayscale(filenames);

        // Define a threshold value for black and white conversion
        double threshold = 128.0;
        ImageProcessor.BlackWhite(filenames, threshold);

         // Define the height for the thumbnail images
        int thumbnailHeight = 100;
        ImageProcessor.Thumbnail(filenames, thumbnailHeight);
    }
}


