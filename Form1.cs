using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ParallaxTextureCompositor
{
    public partial class Form1 : Form
    {
        // Low / mid / high / steep
        public static bool[] enabledSets = { false, false, false, false };
        public static PictureBox[] setBoxes = new PictureBox[4];
        public static Bitmap[] setImages = new Bitmap[4];
        public static Color[][,] setColorData = new Color[4][,];
        string prevDirectory = "";

        private Bitmap outputDisplacement;
        private Bitmap outputOcclusion;
        public Form1()
        {
            InitializeComponent();
            InitLocalComponents();
        }
        private void InitLocalComponents()
        {
            setBoxes[0] = pictureBoxLow;
            setBoxes[1] = pictureBoxMid;
            setBoxes[2] = pictureBoxHigh;
            setBoxes[3] = pictureBoxSteep;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetDefaults();
        }

        private void ResetDefaults()
        {
            checkBoxLow.Checked = false;
            checkBoxMid.Checked = false;
            checkBoxHigh.Checked = false;
            checkBoxSteep.Checked = false;

            pictureBoxLow.Image = null;
            pictureBoxMid.Image = null;
            pictureBoxHigh.Image = null;
            pictureBoxSteep.Image = null;

            pictureBoxDisplacement.Image = null;
            pictureBoxAO.Image = null;

            enabledSets[0] = false;
            enabledSets[1] = false;
            enabledSets[2] = false;
            enabledSets[3] = false;

            setImages[0]?.Dispose();
            setImages[1]?.Dispose();
            setImages[2]?.Dispose();
            setImages[3]?.Dispose();
        }

        // Set index 0 = low, 1 = mid, 2 = high, 3 = steep
        void OpenFile(int setIndex)
        {
            using (OpenFileDialog dialogue = new OpenFileDialog())
            {
                dialogue.InitialDirectory = prevDirectory;
                dialogue.Multiselect = false;
                dialogue.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;";
                dialogue.Title = "Select a displacement or occlusion image";
                if (dialogue.ShowDialog() == DialogResult.OK)
                {
                    string fileName = dialogue.FileName;
                    string? directory = Path.GetDirectoryName(fileName);
                    if (directory != null)
                    {
                        prevDirectory = directory;
                    }
                    setImages[setIndex] = new Bitmap(fileName);

                    setColorData[setIndex] = GetBitmapColors(setImages[setIndex]);

                    setBoxes[setIndex].Image = setImages[setIndex];
                }
            }
        }

        void SaveFile(string fileName, OutputType resultType)
        {
            using (SaveFileDialog dialogue = new SaveFileDialog())
            {
                dialogue.InitialDirectory = prevDirectory;
                dialogue.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;";
                dialogue.Title = "Select a displacement or occlusion image";
                dialogue.FileName = fileName;
                if (dialogue.ShowDialog() == DialogResult.OK)
                {
                    string savedFileName = dialogue.FileName;
                    if (resultType == OutputType.displacement)
                    {
                        outputDisplacement.Save(savedFileName);
                    }
                    if (resultType == OutputType.occlusion)
                    {
                        outputOcclusion.Save(savedFileName);
                    }
                }
            }
        }

        void CombineChannels(int outIndex)
        {
            // Check if there are some sets ticked
            if (enabledSets.All(x => x == false))
            {
                MessageBox.Show("Setup error: No texture sets selected");
                return;
            }

            // Check if a set is ticked but the image isn't loaded
            for (int i = 0; i < 4; i++)
            {
                if (enabledSets[i])
                {
                    if (setImages[i] == null)
                    {
                        MessageBox.Show("Setup error: A texture set is enabled but the image is not set");
                        return;
                    }
                }
            }

            int firstEnabled = GetIndexOfFirstEnabledSet();
            bool sizesValid = SizesMatch(firstEnabled);

            if (!sizesValid)
            {
                MessageBox.Show("Dimension error: Images must be the same dimensions and be square");
                return;
            }

            int dimension = setImages[firstEnabled].Width;

            // Set image channels
            // Format is alpha, red, green, blue (steep, low, mid, high)
            Bitmap result = new Bitmap(dimension, dimension, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Color[,] resultData = new Color[dimension, dimension];

            // RGBA

            //for (int x = 0; x < dimension; x++)
            Parallel.For(0, dimension, x =>
            {
                Color col = Color.Black;
                int r = 0;
                int g = 0;
                int b = 0;
                int a = 0;
                for (int y = 0; y < dimension; y++)
                {
                    col = Color.Black;

                    // Determine which image we read from
                    for (int i = 0; i < 4; i++)
                    {
                        if (enabledSets[i])
                        {
                            // Read red channel from each image. Image should be greyscale, so this is fine
                            if (i == 0)
                            {
                                r = setColorData[i][x, y].R;
                            }
                            if (i == 1)
                            {
                                g = setColorData[i][x, y].R;
                            }
                            if (i == 2)
                            {
                                b = setColorData[i][x, y].R;
                            }
                            if (i == 3)
                            {
                                a = setColorData[i][x, y].R;
                            }
                        }
                        else
                        {
                            // Handle cases where displacement/AO is defaulted
                            if (i == 0)
                            {
                                r = outIndex == 0 ? 127 : 255;
                            }
                            if (i == 1)
                            {
                                g = outIndex == 0 ? 127 : 255;
                            }
                            if (i == 2)
                            {
                                b = outIndex == 0 ? 127 : 255;
                            }
                            if (i == 3)
                            {
                                a = outIndex == 0 ? 127 : 255;
                            }
                        }
                    }
                    // We've collected the data, now write to the output image
                    resultData[x, y] = Color.FromArgb(a, r, g, b);
                }
            });

            // Output to bitmap
            SetBitmapColors(result, resultData);

            if (outIndex == 0)
            {
                pictureBoxDisplacement.Image = result;
                outputDisplacement = result;
            }
            if (outIndex == 1)
            {
                pictureBoxAO.Image = result;
                outputOcclusion = result;
            }
        }

        int GetIndexOfFirstEnabledSet()
        {
            for (int i = 0; i < 4; i++)
            {
                if (setImages[i] != null)
                {
                    return i;
                }
            }
            return 0;
        }
        bool SizesMatch(int firstEnabledIndex)
        {
            int baseSizeW = setImages[firstEnabledIndex].Width;
            int baseSizeH = setImages[firstEnabledIndex].Height;
            firstEnabledIndex++;
            for (int i = firstEnabledIndex; i < 4; i++)
            {
                if (enabledSets[i])
                {
                    int sizeW = setImages[i].Width;
                    int sizeH = setImages[i].Height;

                    if (sizeW != baseSizeW || sizeH != baseSizeH)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static Color[,] GetBitmapColors(Bitmap bitmap)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            Color[,] colors = new Color[width, height];

            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, bitmap.PixelFormat);

            // Get the number of bytes per pixel
            int bytesPerPixel = Image.GetPixelFormatSize(bmpData.PixelFormat) / 8;

            // Get the address of the first pixel data
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold all bytes of the bitmap
            int bytesCount = Math.Abs(bmpData.Stride) * height;
            byte[] pixelData = new byte[bytesCount];

            // Copy the RGB values into the array
            Marshal.Copy(ptr, pixelData, 0, bytesCount);

            // Unlock the bits.
            bitmap.UnlockBits(bmpData);

            // Convert the byte array into the 2D color array
            Parallel.For(0, height, y =>
            {
                for (int x = 0; x < width; x++)
                {
                    int pixelIndex = y * bmpData.Stride + x * bytesPerPixel;

                    byte b = pixelData[pixelIndex];
                    byte g = pixelData[pixelIndex + 1];
                    byte r = pixelData[pixelIndex + 2];

                    // Check if the bitmap has an alpha channel (ARGB)
                    byte a = (bytesPerPixel == 4) ? pixelData[pixelIndex + 3] : (byte)255;

                    colors[x, y] = Color.FromArgb(a, r, g, b);
                }
            });

            return colors;
        }
        public static void SetBitmapColors(Bitmap bitmap, Color[,] colors)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;

            if (colors.GetLength(0) != width || colors.GetLength(1) != height)
                throw new ArgumentException("The dimensions of the color array must match the bitmap dimensions.");

            // Lock the bitmap's bits.
            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.WriteOnly, bitmap.PixelFormat);

            // Get the number of bytes per pixel
            int bytesPerPixel = Image.GetPixelFormatSize(bmpData.PixelFormat) / 8;

            // Get the address of the first pixel data
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold all bytes of the bitmap
            int bytesCount = Math.Abs(bmpData.Stride) * height;
            byte[] pixelData = new byte[bytesCount];

            // Convert the color array into the byte array
            Parallel.For(0, height, y =>
            {
                for (int x = 0; x < width; x++)
                {
                    int pixelIndex = y * bmpData.Stride + x * bytesPerPixel;
                    Color color = colors[x, y];

                    pixelData[pixelIndex] = color.B;       // Blue
                    pixelData[pixelIndex + 1] = color.G;   // Green
                    pixelData[pixelIndex + 2] = color.R;   // Red

                    if (bytesPerPixel == 4)                // If it’s 32-bit ARGB, set the Alpha
                        pixelData[pixelIndex + 3] = color.A;
                }
            });

            // Copy the modified byte array back into the bitmap
            Marshal.Copy(pixelData, 0, ptr, bytesCount);

            // Unlock the bits.
            bitmap.UnlockBits(bmpData);
        }

        private void pictureBoxLow_Click(object sender, EventArgs e)
        {
            OpenFile(0);
        }

        private void pictureBoxMid_Click(object sender, EventArgs e)
        {
            OpenFile(1);
        }

        private void pictureBoxHigh_Click(object sender, EventArgs e)
        {
            OpenFile(2);
        }

        private void pictureBoxSteep_Click(object sender, EventArgs e)
        {
            OpenFile(3);
        }

        private void checkBoxLow_CheckedChanged(object sender, EventArgs e)
        {
            enabledSets[0] = ((CheckBox)sender).Checked;
        }

        private void checkBoxMid_CheckedChanged(object sender, EventArgs e)
        {
            enabledSets[1] = ((CheckBox)sender).Checked;
        }

        private void checkBoxHigh_CheckedChanged(object sender, EventArgs e)
        {
            enabledSets[2] = ((CheckBox)sender).Checked;
        }

        private void checkBoxSteep_CheckedChanged(object sender, EventArgs e)
        {
            enabledSets[3] = ((CheckBox)sender).Checked;
        }

        private void buttonCombineDisplacement_Click(object sender, EventArgs e)
        {
            CombineChannels(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CombineChannels(1);
        }


        enum OutputType
        {
            displacement,
            occlusion
        }
        private void pictureBoxDisplacement_Click(object sender, EventArgs e)
        {
            if (outputDisplacement != null)
            {
                SaveFile("displacement.png", OutputType.displacement);
            }
        }

        private void pictureBoxAO_Click(object sender, EventArgs e)
        {
            if (outputOcclusion != null)
            {
                SaveFile("occlusion.png", OutputType.occlusion);
            }
        }

        private void buttonCopyDisplacement_Click(object sender, EventArgs e)
        {
            if (outputDisplacement != null)
            {
                Clipboard.SetImage(outputDisplacement);
            }
        }

        private void buttonCopyAO_Click(object sender, EventArgs e)
        {
            if (outputOcclusion != null)
            {
                Clipboard.SetImage(outputOcclusion);
            }
        }
    }
}