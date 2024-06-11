﻿using System;
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
}
