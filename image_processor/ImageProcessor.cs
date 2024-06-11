using System;
using System.Drawing;
using System.Threading.Tasks;

/// <summary>
/// Provides methods for processing images, such as inverting their colors.
/// </summary>
public class ImageProcessor
{
    /// <summary>
    /// Inverts the colors of the images specified by the file paths and saves them in the "image_processor" directory,
    /// which is located in the parent directory of the source images directory.
    /// </summary>
    /// <param name="filenames">An array of file paths to the source images.</param>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach (filenames, filename =>
        {
            // Load the original image
            Bitmap original = new Bitmap(filename);
            Bitmap inverted = new Bitmap(original.Width, original.Height);

            // Invert the colors of the image
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color originalColor = original.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                    inverted.SetPixel(x, y, invertedColor);
                }
            }

            // Extract the file name without the original path and add "_inverse" before the extension
                string[] nameSplit = filename.Split(new char[] { '/', '.' });
                string newFilename = $"{nameSplit[nameSplit.Length - 2]}_inverse.{nameSplit[nameSplit.Length - 1]}";

                // Save the inverted image
                inverted.Save(newFilename);
        });
    }

    /// <summary>
    /// Converts the images specified by the file paths to grayscale and saves them in the "image_processor" directory,
    /// which is located in the parent directory of the source images directory.
    /// </summary>
    /// <param name="filenames">An array of file paths to the source images.</param>
    public static void Grayscale(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            // Load the original image
            Bitmap original = new Bitmap(filename);
            Bitmap grayscale = new Bitmap(original.Width, original.Height);

            // Convert the image to grayscale
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color originalColor = original.GetPixel(x, y);
                    int grayValue = (int)(0.2126 * originalColor.R + 0.7152 * originalColor.G + 0.0722 * originalColor.B);
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    grayscale.SetPixel(x, y, grayColor);
                }
            }

            // Extract the file name without the original path and add "_grayscale" before the extension
            string[] nameSplit = filename.Split(new char[] { '/', '.' });
            string newFilename = $"{nameSplit[nameSplit.Length - 2]}_grayscale.{nameSplit[nameSplit.Length - 1]}";

            // Save the grayscale image
            grayscale.Save(newFilename);
        });
    }

     /// <summary>
    /// Reduces the images specified by the file paths to black and white based on a given threshold
    /// and saves them in the "image_processor" directory, which is located in the parent directory of the source images directory.
    /// </summary>
    /// <param name="filenames">An array of file paths to the source images.</param>
    /// <param name="threshold">The threshold value for black and white conversion.</param>
    public static void BlackWhite(string[] filenames, double threshold)
    {
        Parallel.ForEach(filenames, filename =>
        {
            // Load the original image
            Bitmap original = new Bitmap(filename);
            Bitmap blackWhite = new Bitmap(original.Width, original.Height);

            // Convert the image to black and white based on the threshold
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color originalColor = original.GetPixel(x, y);
                    int luminance = (int)(0.2126 * originalColor.R + 0.7152 * originalColor.G + 0.0722 * originalColor.B);
                    Color blackWhiteColor = luminance >= threshold ? Color.White : Color.Black;
                    blackWhite.SetPixel(x, y, blackWhiteColor);
                }
            }

            // Extract the file name without the original path and add "_bw" before the extension
            string[] nameSplit = filename.Split(new char[] { '/', '.' });
            string newFilename = $"{nameSplit[nameSplit.Length - 2]}_bw.{nameSplit[nameSplit.Length - 1]}";

            // Save the black and white image
            blackWhite.Save(newFilename);
        });
    }
}

