/* 
---------------------------------
Developed by Rhythmicbinary  :"))
---------------------------------
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DrawBitmap
{
    public class ImageProc
    {

        public static Bitmap MakeGray(Bitmap bmp, double red = 1, double green = 1, double blue = 1)
        {
            Bitmap bmap = bmp;
            unsafe
            {
                BitmapData bitmapData = bmap.LockBits(new Rectangle(0, 0, bmap.Width, bmap.Height), ImageLockMode.ReadWrite, bmap.PixelFormat);

                int bytePerPixel = Bitmap.GetPixelFormatSize(bmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInPixels = bitmapData.Width * bytePerPixel;
                Byte* ptrFirstPixel = (Byte*)bitmapData.Scan0;
                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = ptrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInPixels; x = x + bytePerPixel)
                    {
                        int oldBlue = currentLine[x];
                        int oldGreen = currentLine[x + 1];
                        int oldRed = currentLine[x + 2];
                        int color = (int)(oldRed * red + oldGreen * green + oldBlue * blue);
                        currentLine[x] = (byte)color;
                        currentLine[x + 1] = (byte)color;
                        currentLine[x + 2] = (byte)color;

                    }
                });
                bmap.UnlockBits(bitmapData);
            }
            return bmap;
        }
        public static Bitmap MakeBlackWhite(Bitmap bmp, int val = 120)
        {
            Bitmap bmap = bmp;
            unsafe
            {
                BitmapData bitmapData = bmap.LockBits(new Rectangle(0, 0, bmap.Width, bmap.Height), ImageLockMode.ReadWrite, bmap.PixelFormat);

                int bytePerPixel = Bitmap.GetPixelFormatSize(bmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInPixels = bitmapData.Width * bytePerPixel;
                Byte* ptrFirstPixel = (Byte*)bitmapData.Scan0;
                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = ptrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInPixels; x = x + bytePerPixel)
                    {
                        int oldBlue = currentLine[x];
                        int oldGreen = currentLine[x + 1];
                        int oldRed = currentLine[x + 2];
                        int color = (int)((oldRed + oldGreen + oldBlue) / 3);
                        if (color <= val)
                        {
                            currentLine[x] = (byte)0;
                            currentLine[x + 1] = (byte)0;
                            currentLine[x + 2] = (byte)0;
                        }
                        else
                        {
                            currentLine[x] = (byte)255;
                            currentLine[x + 1] = (byte)255;
                            currentLine[x + 2] = (byte)255;
                        }

                    }
                });
                bmap.UnlockBits(bitmapData);
            }
            return bmap;
        }

        public static Image ApplyChanges(Bitmap bmp, int r = 0, int g = 0, int b = 0)
        {
            Bitmap bmap = bmp;
            unsafe
            {
                BitmapData bitmapData = bmap.LockBits(new Rectangle(0, 0, bmap.Width, bmap.Height), ImageLockMode.ReadWrite, bmap.PixelFormat);

                int bytePerPixel = Bitmap.GetPixelFormatSize(bmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInPixels = bitmapData.Width * bytePerPixel;
                Byte* ptrFirstPixel = (Byte*)bitmapData.Scan0;
                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = ptrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInPixels; x = x + bytePerPixel)
                    {
                        int oldBlue = currentLine[x];//blue
                        int oldGreen = currentLine[x + 1];//green
                        int oldRed = currentLine[x + 2];//red

                        int newBlue = b + oldBlue >= 255 ? 255 : b + oldBlue;
                        int newGreen = g + oldGreen >= 255 ? 255 : g + oldGreen;
                        int newRed = r + oldRed >= 255 ? 255 : r + oldRed;
                        if (newBlue < 0) newBlue = 0;
                        if (newGreen < 0) newGreen = 0;
                        if (newRed < 0) newRed = 0;
                        currentLine[x] = (byte)(newBlue);//blue
                        currentLine[x + 1] = (byte)(newGreen);//green
                        currentLine[x + 2] = (byte)(newRed);//red


                    }
                });
                bmap.UnlockBits(bitmapData);
            }
            return bmap;
        }


        public static Bitmap MakeNegative(Bitmap bmp)
        {
            Bitmap bmap = bmp;
            unsafe
            {
                BitmapData bitmapData = bmap.LockBits(new Rectangle(0, 0, bmap.Width, bmap.Height), ImageLockMode.ReadWrite, bmap.PixelFormat);

                int bytePerPixel = Bitmap.GetPixelFormatSize(bmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInPixels = bitmapData.Width * bytePerPixel;
                Byte* ptrFirstPixel = (Byte*)bitmapData.Scan0;
                Parallel.For(0, heightInPixels, y =>
                {
                    byte* currentLine = ptrFirstPixel + (y * bitmapData.Stride);
                    for (int x = 0; x < widthInPixels; x = x + bytePerPixel)
                    {
                        int oldBlue = currentLine[x];//blue
                    int oldGreen = currentLine[x + 1];//green
                    int oldRed = currentLine[x + 2];//red
                    int newBlue = 255 - oldBlue;
                        int newGreen = 255 - oldGreen;
                        int newRed = 255 - oldRed;
                        currentLine[x] = (byte)(newBlue);//blue
                    currentLine[x + 1] = (byte)(newGreen);//green
                    currentLine[x + 2] = (byte)(newRed);//red


                }
                });
                bmap.UnlockBits(bitmapData);
            }
            return bmap;
        }
    }
}

