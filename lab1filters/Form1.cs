using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1filters
{
  public partial class Form1 : Form
  {
    Bitmap image;
    public Form1()
    {
      InitializeComponent();
    }

    private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog dialog = new OpenFileDialog();
      dialog.Filter = "Image files | *.png; *.jpg; *.bmp; | All files (*.*) | *.*";
      if (dialog.ShowDialog() == DialogResult.OK)
      {
        image = new Bitmap(dialog.FileName);
      }
      pictureBox1.Image = image;
      pictureBox1.Refresh();
    }

    private void инверсияToolStripMenuItem_Click(object sender, EventArgs e)
    {
      InvertFilter filter = new InvertFilter();
      backgroundWorker1.RunWorkerAsync(filter);
      //Bitmap resultImage = filter.processImage(image);
      //pictureBox1.Image = resultImage;
      //pictureBox1.Refresh();
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
      if (backgroundWorker1.CancellationPending != true)
        image = newImage;
    }

    private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      progressBar1.Value = e.ProgressPercentage;
    }

    private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (!e.Cancelled)
      {
        pictureBox1.Image = image;
        pictureBox1.Refresh();
      }
      progressBar1.Value = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      backgroundWorker1.CancelAsync();
    }

    private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new BlurFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void размытиеПоГауссуToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filters = new GaussianFilter();
      backgroundWorker1.RunWorkerAsync(filters);  
    }

    private void оттенкиСерогоToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new GrayScale();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new Sepia();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void повышеннаяЯркостьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new Brightness();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void фильтрСобеляToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      Filters filter = new Sobel();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new Sharpness();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void тиснениеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new embossing();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void идеальныйОтражательToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new Reflector();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void эффектСтеклаToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new GlassEffect();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();
      saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
      saveFileDialog1.Title = "Save an Image File";
      saveFileDialog1.ShowDialog();

      if (saveFileDialog1.FileName != "")
      {
        System.IO.FileStream fs =
            (System.IO.FileStream)saveFileDialog1.OpenFile();

        switch (saveFileDialog1.FilterIndex)
        {
          case 1:
            pictureBox1.Image.Save(fs,
              System.Drawing.Imaging.ImageFormat.Jpeg);
            break;
        }

        fs.Close();
      }
    }

    private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DilationFilter dilation = new DilationFilter(3);
      Bitmap resultImage = dilation.ApplyDilation(image);
      pictureBox1.Image = resultImage;
      pictureBox1.Refresh();
    }

    private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ErosionFilter erosion = new ErosionFilter(3);
      Bitmap resultImage = erosion.ApplyErosion(image);
      pictureBox1.Image = resultImage;
      pictureBox1.Refresh();
    }

    private void openingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpeningFilter opening = new OpeningFilter(3);
      Bitmap resultImage = opening.ApplyOpening(image);
      pictureBox1.Image = resultImage;
      pictureBox1.Refresh();
    }

    private void closingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ClosingFilter closing = new ClosingFilter(3);
      Bitmap resultImage = closing.ApplyOpening(image);
      pictureBox1.Image = resultImage;
      pictureBox1.Refresh();
    }

    private void gradientToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MorphologicalGradient gradient = new MorphologicalGradient(3);
      Bitmap resultImage = gradient.ApplyGradient(image);
      pictureBox1.Image = resultImage;
      pictureBox1.Refresh();
    }

    private void медианныйФильтрToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MedianFilter medianFilter = new MedianFilter(3); // Используем окно 3x3
      Bitmap resultImage = medianFilter.ApplyMedianFilter(image);
      pictureBox1.Image = resultImage;
      pictureBox1.Refresh();
    }
  }
}
