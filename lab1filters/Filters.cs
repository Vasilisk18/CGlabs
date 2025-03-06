using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace lab1filters
{
  }
  abstract class Filters
  {
    protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int x, int y);
    public int Clamp(int value, int min, int max)
    {
      if (value < min)
      {
        return min;
      }
      if (value > max)
      {
        return max;
      }
      return value;
    }

   public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
  { 
      for(int i = 0; i <sourceImage.Width; i++)
      {
          worker.ReportProgress((int)((float)i / sourceImage.Width * 100));
          if (worker.CancellationPending)
            return null;
      }
        Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
        for(int i = 0; i < sourceImage.Width; i++)
        {
          for(int j = 0; j < sourceImage.Height; j++)
          {
            resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
          }
        }
        return resultImage;
     }
  }
  class InvertFilter : Filters
  {
      protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
      {
        Color sourceColor = sourceImage.GetPixel(x, y);
        Color resultColor = Color.FromArgb(255 - sourceColor.R,
                                           255 - sourceColor.G,
                                           255 - sourceColor.B);
        return resultColor;
      }
  }
  class MatrixFilter : Filters
  {
      protected float[,] kernel = null;
      protected MatrixFilter() { }
      public MatrixFilter(float[,] kernel)
      {
        this.kernel = kernel;
      }
      protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
      {
        int radiusX = kernel.GetLength(0) / 2;
        int radiusY = kernel.GetLength(1) / 2;
        float resultR = 0;
        float resultG = 0;
        float resultB = 0;
        for (int l = -radiusY; l <= radiusX; l++)
          for (int k = -radiusX; k <= radiusX; k++)
          {
            int idX = Clamp(x + k, 0, sourceImage.Width - 1);
            int idY = Clamp(y + l, 0, sourceImage.Height - 1);
            Color neighborColor = sourceImage.GetPixel(idX, idY);
            resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
            resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
            resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
          }
        return Color.FromArgb(
        Clamp((int)resultR, 0, 255),
        Clamp((int)resultG, 0, 255),
        Clamp((int)resultB, 0, 255)
        );
      }
  }

  class BlurFilter : MatrixFilter
  {
      public BlurFilter()
      {
        int sizeX = 3;
        int sizeY = 3;
        kernel = new float[sizeX, sizeY];
        for (int i = 0; i < sizeX; i++)
          for (int j = 0; j < sizeY; j++){
            kernel[i, j] = 1.0f / (float)(sizeX * sizeY);
          }
      }
  }

class GaussianFilter : MatrixFilter
{
    public void createGaussianKernel(int radius, float sigma)
    {
      int size = (2 * radius) + 1;
      kernel = new float[size, size];
      float norm = 0;
      for (int i = -radius; i <= radius; i++)
        for (int j = -radius; j <= radius; j++)
        {
          kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (2 * sigma * sigma)));
          norm += kernel[i + radius, j + radius];
        }
      for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
          kernel[i, j] /= norm;
    }
    public GaussianFilter()
    {
      createGaussianKernel(3, 2);
    }
}

class GrayScale : Filters
{
  protected override Color calculateNewPixelColor(Bitmap sourceimage, int i, int j)
  {
    Color sourcecolor = sourceimage.GetPixel(i, j);
    double R = sourcecolor.R;
    double G = sourcecolor.G;
    double B = sourcecolor.B;
    double Intensity = 0.299 * R + 0.587 * G + 0.114 * B;
    Color resultcolor = Color.FromArgb(Clamp((int)(Intensity), -255, 255),
                                       Clamp((int)(Intensity), -255, 255),
                                       Clamp((int)(Intensity), -255, 255));
    return resultcolor;
  }
}

class Sepia : Filters
{
  protected override Color calculateNewPixelColor(Bitmap sourceimage, int i, int j)
  {
    Color sourcecolor = sourceimage.GetPixel(i, j);
    double R = sourcecolor.R;
    double G = sourcecolor.G;
    double B = sourcecolor.B;
    double Intensity = 0.299 * R + 0.587 * G + 0.114 * B;
    int k = 6;
    Color resultcolor = Color.FromArgb(Clamp((int)(Intensity + 2 * k), 0, 255),
                                       Clamp((int)(Intensity + 0.5 * k), 0, 255),
                                       Clamp((int)(Intensity - k), 0, 255));
    return resultcolor;
  }
}
class Brightness : Filters
{
  protected override Color calculateNewPixelColor(Bitmap sourceimage, int i, int j)
  {
    Color sourcecolor = sourceimage.GetPixel(i, j);
    double R = sourcecolor.R;
    double G = sourcecolor.G;
    double B = sourcecolor.B;
    int k = 60;
    Color resultcolor = Color.FromArgb(Clamp((int)(R + k), 0, 255),
                                       Clamp((int)(G + k), 0, 255),
                                       Clamp((int)(G + k), 0, 255));
    return resultcolor;
  }
}
class Sobel : MatrixFilter
{
  public Sobel()
  {
    int sizex = 3;
    int sizey = 3;
    kernel = new float[sizex, sizey];
    kernel[0, 0] = -1;
    kernel[0, 1] = -2;
    kernel[0, 2] = -1;
    kernel[1, 0] = 0;
    kernel[1, 1] = 0;
    kernel[1, 2] = 0;
    kernel[2, 0] = 1;
    kernel[2, 1] = 2;
    kernel[2, 2] = 1;
    //kernel[0, 0] = -1;
    //kernel[0, 1] = 0;
    //kernel[0, 2] = 1;
    //kernel[1, 0] = -2;
    //kernel[1, 1] = 0;
    //kernel[1, 2] = 2;
    //kernel[2, 0] = -1;
    //kernel[2, 1] = 0;
    //kernel[2, 2] = 1;
  }
}

class Sharpness : MatrixFilter
{
  public Sharpness()
  {
    int sizex = 3;
    int sizey = 3;
    kernel = new float[sizex, sizey];
    kernel[0, 0] = 0;
    kernel[0, 1] = -1;
    kernel[0, 2] = 0;
    kernel[1, 0] = -1;
    kernel[1, 1] = 5;
    kernel[1, 2] = -1;
    kernel[2, 0] = 0;
    kernel[2, 1] = -1;
    kernel[2, 2] = 0;
  }
}

class embossing : MatrixFilter
{
  public embossing()
  {
    int sizex = 3;
    int sizey = 3;
    kernel = new float[sizex, sizey];
    kernel[0, 0] = 0;
    kernel[0, 1] = 1;
    kernel[0, 2] = 0;
    kernel[1, 0] = 1;
    kernel[1, 1] = 0;
    kernel[1, 2] = -1;
    kernel[2, 0] = 0;
    kernel[2, 1] = -1;
    kernel[2, 2] = 0;
  }
  protected Color grayscale(Bitmap sourceimage, int i, int j)
  {
    Color sourcecolor = sourceimage.GetPixel(i, j);
    double R = sourcecolor.R;
    double G = sourcecolor.G;
    double B = sourcecolor.B;
    double Intensity = 0.299 * R + 0.587 * G + 0.114 * B;
    int k = 5;
    Color resultcolor = Color.FromArgb(Clamp((int)(Intensity + 2 * k), -255, 255),
                                       Clamp((int)(Intensity + 0.5 * k), -255, 255),
                                       Clamp((int)(Intensity - k), -255, 255));
    return resultcolor;
  }
  protected Bitmap processimage(Bitmap sourceimage)
  {
    Bitmap resultimage = new Bitmap(sourceimage.Width, sourceimage.Height);
    for (int i = 0; i < sourceimage.Width; i++)
    {
      for (int j = 0; j < sourceimage.Height; j++)
      {
        resultimage.SetPixel(i, j, grayscale(sourceimage, i, j));
      }
    }
    return resultimage;
  }
  protected override Color calculateNewPixelColor(Bitmap resultimage, int i, int j)
  {
    Bitmap sourceimage;
    sourceimage = resultimage;
    int radiusX = kernel.GetLength(0) / 2;
    int radiusY = kernel.GetLength(1) / 2;
    float resultR = 0;
    float resultG = 0;
    float resultB = 0;
    for (int l = -radiusY; l <= radiusY; l++)
      for (int k = -radiusX; k <= radiusX; k++)
      {
        int idx = Clamp(i + k, 0, sourceimage.Width - 1);
        int idy = Clamp(j + l, 0, sourceimage.Height - 1);
        Color neighborcolor = sourceimage.GetPixel(idx, idy);
        resultR += neighborcolor.R * kernel[k + radiusX, l + radiusY];
        resultG += neighborcolor.G * kernel[k + radiusX, l + radiusY];
        resultB += neighborcolor.B * kernel[k + radiusX, l + radiusY];
      }
    resultR = (resultR + 255) / 2;
    resultG = (resultG + 255) / 2;
    resultB = (resultB + 255) / 2;
    return Color.FromArgb(
        Clamp((int)resultR, 0, 255),
        Clamp((int)resultG, 0, 255),
        Clamp((int)resultB, 0, 255)
        );
  }
}

class Reflector : Filters
{
  protected byte[] FindMaxValue(Bitmap sourceimage)
  {
    byte maxR = sourceimage.GetPixel(0, 0).R, maxG = sourceimage.GetPixel(0, 0).G, maxB = sourceimage.GetPixel(0, 0).B;
    for (int i = 0; i < sourceimage.Width; i++)
      for (int j = 0; j < sourceimage.Height; j++)
      {
        if ((float)sourceimage.GetPixel(i, j).R > (float)maxR)
          maxR = sourceimage.GetPixel(i, j).R;
        if ((float)sourceimage.GetPixel(i, j).G > (float)maxG)
          maxG = sourceimage.GetPixel(i, j).G;
        if ((float)sourceimage.GetPixel(i, j).B > (float)maxB)
          maxB = sourceimage.GetPixel(i, j).B;
      }
    byte[] result = new byte[3];
    result[0] = maxR;
    result[1] = maxG;
    result[2] = maxB;
    return result;
  }
  protected override Color calculateNewPixelColor(Bitmap sourceimage, int i, int j)
  {
    Color sourcecolor = sourceimage.GetPixel(i, j);
    byte[] colors = new byte[3];
    colors = FindMaxValue(sourceimage);
    double R = sourcecolor.R;
    double G = sourcecolor.G;
    double B = sourcecolor.B;
    Color resultcolor = Color.FromArgb(Clamp((int)(R * 255 / colors[0]), 0, 255),
                                       Clamp((int)(G * 255 / colors[1]), 0, 255),
                                       Clamp((int)(B * 255 / colors[2]), 0, 255));
    return resultcolor;
  }
}

class GlassEffect : Filters
{
  protected override Color calculateNewPixelColor(Bitmap sourceimage, int i, int j)
  {
    Random rnd = new Random();
    double k = rnd.NextDouble();
    int newcoloronx = (int)(i + (k - 0.5) * 10);
    int newcolorony = (int)(j + (k - 0.5) * 10);
    Color resultcolor = sourceimage.GetPixel(Clamp(newcoloronx, 0, sourceimage.Width - 1), Clamp(newcolorony, 0, sourceimage.Height - 1));
    //Color resultcolor = sourceimage.GetPixel(newcoloronx, newcolorony);
    return resultcolor;
  }
}

public class DilationFilter
{
  private int[,] structuringElement;
  private int elementSize;

  public DilationFilter(int size = 3)
  {
    elementSize = size;
    structuringElement = new int[size, size];

    // Заполняем элемент единицами (можно изменить для другой формы)
    for (int i = 0; i < size; i++)
      for (int j = 0; j < size; j++)
        structuringElement[i, j] = 1;
  }

  public Bitmap ApplyDilation(Bitmap sourceImage)
  {
    Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
    int offset = elementSize / 2;

    for (int x = offset; x < sourceImage.Width - offset; x++)
    {
      for (int y = offset; y < sourceImage.Height - offset; y++)
      {
        int max = 0;

        for (int i = 0; i < elementSize; i++)
        {
          for (int j = 0; j < elementSize; j++)
          {
            int pixelX = x + i - offset;
            int pixelY = y + j - offset;

            Color pixelColor = sourceImage.GetPixel(pixelX, pixelY);
            int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // Яркость серого

            if (structuringElement[i, j] == 1)
            {
              max = Math.Max(max, intensity);
            }
          }
        }

        resultImage.SetPixel(x, y, Color.FromArgb(max, max, max));
      }
    }

    return resultImage;
  }
}

public class ErosionFilter
{
  private int[,] structuringElement;
  private int elementSize;

  public ErosionFilter(int size = 3)
  {
    elementSize = size;
    structuringElement = new int[size, size];

    // Заполняем элемент единицами (можно изменить для другой формы)
    for (int i = 0; i < size; i++)
      for (int j = 0; j < size; j++)
        structuringElement[i, j] = 1;
  }

  public Bitmap ApplyErosion(Bitmap sourceImage)
  {
    Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
    int offset = elementSize / 2;

    for (int x = offset; x < sourceImage.Width - offset; x++)
    {
      for (int y = offset; y < sourceImage.Height - offset; y++)
      {
        int min = 255; // Начинаем с максимального значения

        for (int i = 0; i < elementSize; i++)
        {
          for (int j = 0; j < elementSize; j++)
          {
            int pixelX = x + i - offset;
            int pixelY = y + j - offset;

            Color pixelColor = sourceImage.GetPixel(pixelX, pixelY);
            int intensity = (pixelColor.R + pixelColor.G + pixelColor.B) / 3; // Яркость серого

            if (structuringElement[i, j] == 1)
            {
              min = Math.Min(min, intensity);
            }
          }
        }

        resultImage.SetPixel(x, y, Color.FromArgb(min, min, min));
      }
    }

    return resultImage;
  }
}

public class OpeningFilter
{
  private ErosionFilter erosion;
  private DilationFilter dilation;

  public OpeningFilter(int size = 3)
  {
    erosion = new ErosionFilter(size);
    dilation = new DilationFilter(size);
  }

  public Bitmap ApplyOpening(Bitmap sourceImage)
  {
    Bitmap erodedImage = erosion.ApplyErosion(sourceImage);
    Bitmap resultImage = dilation.ApplyDilation(erodedImage);
    return resultImage;
  }
}

public class ClosingFilter
{
  private ErosionFilter erosion;
  private DilationFilter dilation;

  public ClosingFilter(int size = 3)
  {
    dilation = new DilationFilter(size);
    erosion = new ErosionFilter(size);
  }

  public Bitmap ApplyOpening(Bitmap sourceImage)
  {
    Bitmap dilatedImage = dilation.ApplyDilation(sourceImage);
    Bitmap resultImage = erosion.ApplyErosion(dilatedImage);
    return resultImage;
  }
}

public class MorphologicalGradient
{
  private DilationFilter dilation;
  private ErosionFilter erosion;

  public MorphologicalGradient(int size = 3)
  {
    dilation = new DilationFilter(size);
    erosion = new ErosionFilter(size);
  }

  public Bitmap ApplyGradient(Bitmap sourceImage)
  {
    Bitmap dilated = dilation.ApplyDilation(sourceImage);
    Bitmap eroded = erosion.ApplyErosion(sourceImage);

    Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

    for (int x = 0; x < sourceImage.Width; x++)
    {
      for (int y = 0; y < sourceImage.Height; y++)
      {
        Color colorD = dilated.GetPixel(x, y);
        Color colorE = eroded.GetPixel(x, y);

        int r = Math.Max(0, colorD.R - colorE.R);
        int g = Math.Max(0, colorD.G - colorE.G);
        int b = Math.Max(0, colorD.B - colorE.B);

        resultImage.SetPixel(x, y, Color.FromArgb(r, g, b));
      }
    }

    return resultImage;
  }
}

public class MedianFilter
{
  private int kernelSize;

  public MedianFilter(int size = 3)
  {
    kernelSize = size;
  }

  public Bitmap ApplyMedianFilter(Bitmap sourceImage)
  {
    Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
    int radius = kernelSize / 2;

    for (int x = radius; x < sourceImage.Width - radius; x++)
    {
      for (int y = radius; y < sourceImage.Height - radius; y++)
      {
        List<int> R = new List<int>();
        List<int> G = new List<int>();
        List<int> B = new List<int>();

        // Собираем значения пикселей в окрестности
        for (int i = -radius; i <= radius; i++)
        {
          for (int j = -radius; j <= radius; j++)
          {
            Color pixel = sourceImage.GetPixel(x + i, y + j);
            R.Add(pixel.R);
            G.Add(pixel.G);
            B.Add(pixel.B);
          }
        }

        // Сортируем и берём медианное значение
        R.Sort();
        G.Sort();
        B.Sort();
        int medianIndex = R.Count / 2;

        // Устанавливаем новый пиксель
        resultImage.SetPixel(x, y, Color.FromArgb(R[medianIndex], G[medianIndex], B[medianIndex]));
      }
    }

    return resultImage;
  }
}