using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            downSizeButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            selectImageButton = new Button();
            originalPhotoPictureBox = new PictureBox();
            DownSizedPhotoPictureBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            DownScalePercentageTextBox = new TextBox();
            parallelDownSizeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)originalPhotoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DownSizedPhotoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // downSizeButton
            // 
            downSizeButton.BackColor = SystemColors.ControlLight;
            downSizeButton.FlatStyle = FlatStyle.Popup;
            downSizeButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            downSizeButton.Location = new Point(490, 12);
            downSizeButton.Name = "downSizeButton";
            downSizeButton.Size = new Size(124, 55);
            downSizeButton.TabIndex = 0;
            downSizeButton.Text = "Consequentual \r\nDown size";
            downSizeButton.UseVisualStyleBackColor = false;
            downSizeButton.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // selectImageButton
            // 
            selectImageButton.BackColor = SystemColors.ControlLight;
            selectImageButton.FlatStyle = FlatStyle.Popup;
            selectImageButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            selectImageButton.Location = new Point(79, 12);
            selectImageButton.Name = "selectImageButton";
            selectImageButton.Size = new Size(135, 55);
            selectImageButton.TabIndex = 1;
            selectImageButton.Text = "Select the image";
            selectImageButton.UseVisualStyleBackColor = false;
            selectImageButton.Click += selectImageButton_Click;
            // 
            // originalPhotoPictureBox
            // 
            originalPhotoPictureBox.BackColor = SystemColors.ControlLight;
            originalPhotoPictureBox.BorderStyle = BorderStyle.Fixed3D;
            originalPhotoPictureBox.Location = new Point(12, 83);
            originalPhotoPictureBox.Name = "originalPhotoPictureBox";
            originalPhotoPictureBox.Size = new Size(283, 215);
            originalPhotoPictureBox.TabIndex = 2;
            originalPhotoPictureBox.TabStop = false;
            // 
            // DownSizedPhotoPictureBox
            // 
            DownSizedPhotoPictureBox.BackColor = SystemColors.ControlLight;
            DownSizedPhotoPictureBox.BorderStyle = BorderStyle.Fixed3D;
            DownSizedPhotoPictureBox.Location = new Point(487, 79);
            DownSizedPhotoPictureBox.Name = "DownSizedPhotoPictureBox";
            DownSizedPhotoPictureBox.Size = new Size(276, 219);
            DownSizedPhotoPictureBox.TabIndex = 3;
            DownSizedPhotoPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(108, 302);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 4;
            label1.Text = "Original image";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(586, 302);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 5;
            label2.Text = "Down sized image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(321, 123);
            label3.Name = "label3";
            label3.Size = new Size(137, 38);
            label3.TabIndex = 6;
            label3.Text = "Enter the percentage \r\nfor down-sizing";
            label3.Click += label3_Click;
            // 
            // DownScalePercentageTextBox
            // 
            DownScalePercentageTextBox.Location = new Point(310, 164);
            DownScalePercentageTextBox.Name = "DownScalePercentageTextBox";
            DownScalePercentageTextBox.Size = new Size(148, 23);
            DownScalePercentageTextBox.TabIndex = 7;
            DownScalePercentageTextBox.TextChanged += DownScalePercentageTextBox_TextChanged;
            // 
            // parallelDownSizeButton
            // 
            parallelDownSizeButton.BackColor = SystemColors.ControlLight;
            parallelDownSizeButton.FlatStyle = FlatStyle.Popup;
            parallelDownSizeButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            parallelDownSizeButton.Location = new Point(639, 12);
            parallelDownSizeButton.Name = "parallelDownSizeButton";
            parallelDownSizeButton.Size = new Size(124, 55);
            parallelDownSizeButton.TabIndex = 8;
            parallelDownSizeButton.Text = "Parallel\r\n Down size";
            parallelDownSizeButton.UseVisualStyleBackColor = false;
            parallelDownSizeButton.Click += parallelDownSizeButton_Click;
            // 
            // Form1
            // 
            BackColor = SystemColors.Control;
            ClientSize = new Size(778, 364);
            Controls.Add(parallelDownSizeButton);
            Controls.Add(DownScalePercentageTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DownSizedPhotoPictureBox);
            Controls.Add(originalPhotoPictureBox);
            Controls.Add(selectImageButton);
            Controls.Add(downSizeButton);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)originalPhotoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DownSizedPhotoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Bitmap originalImage;

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(openFileDialog.FileName);
                    originalPhotoPictureBox.Image = originalImage;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("You have not selected an image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(DownScalePercentageTextBox.Text, out double downscaleFactor) || downscaleFactor <= 0 || downscaleFactor >= 100)
            {
                MessageBox.Show("Enter a valid percentage!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bitmap downsizeImage = SequentialDownsizeImage(originalImage, downscaleFactor);
            DownSizedPhotoPictureBox.Image = downsizeImage;
        }
        private Bitmap SequentialDownsizeImage(Bitmap original, double downscalePercentage)
        {
            int newWidth = (int)(original.Width * downscalePercentage / 100);
            int newHeight = (int)(original.Height * downscalePercentage / 100);

            Bitmap downsizeImage = new Bitmap(newWidth, newHeight);

            Rectangle originalRect = new Rectangle(0, 0, original.Width, original.Height);
            Rectangle resultRect = new Rectangle(0, 0, newWidth, newHeight);

            BitmapData originalImage = original.LockBits(originalRect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData resultImage = downsizeImage.LockBits(resultRect, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            try
            {
                int originalPixelSize = 4;
                byte[] originalPixels = new byte[originalImage.Stride * originalImage.Height];
                Marshal.Copy(originalImage.Scan0, originalPixels, 0, originalPixels.Length);

                byte[] resultPixels = new byte[resultImage.Stride * resultImage.Height];

                for (int y = 0; y < newHeight; y++)
                {
                    for (int x = 0; x < newWidth; x++)
                    {
                        int originalX = (int)((x * originalImage.Width) / newWidth);
                        int originalY = (int)((y * originalImage.Height) / newHeight);

                        int originalIndex = (originalY * originalImage.Stride) + (originalX * originalPixelSize);
                        int resultIndex = (y * resultImage.Stride) + (x * originalPixelSize);

                        Array.Copy(originalPixels, originalIndex, resultPixels, resultIndex, originalPixelSize);
                    }
                }

                Marshal.Copy(resultPixels, 0, resultImage.Scan0, resultPixels.Length);
            }

            finally
            {
                original.UnlockBits(originalImage);
                downsizeImage.UnlockBits(resultImage);
            }

            return downsizeImage;
        }


        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void DownScalePercentageTextBox_TextChanged(object sender, EventArgs e) { }

        private void parallelDownSizeButton_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("You have not selected an image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(DownScalePercentageTextBox.Text, out double downscaleFactor) || downscaleFactor <= 0)
            {
                MessageBox.Show("Enter a valid percentage!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bitmap downsizeResult = ParallelDownsizeImage(originalImage, downscaleFactor);
            DownSizedPhotoPictureBox.Image = downsizeResult;
        }

        private Bitmap ParallelDownsizeImage(Bitmap original, double downscaleFactor)
        {
            int newWidth = (int)(original.Width * downscaleFactor / 100);
            int newHeight = (int)(original.Height * downscaleFactor / 100);

            Bitmap downsizeResult = new Bitmap(newWidth, newHeight);

            BitmapData originalImage = original.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData resultImage = downsizeResult.LockBits(new Rectangle(0, 0, newWidth, newHeight), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            try
            {
                int originalPixelSize = 4; 
                byte[] originalPixels = new byte[originalImage.Stride * originalImage.Height];
                Marshal.Copy(originalImage.Scan0, originalPixels, 0, originalPixels.Length);

                byte[] resultPixels = new byte[resultImage.Stride * resultImage.Height];

                Parallel.For(0, newHeight, y =>
                {
                    for (int x = 0; x < newWidth; x++)
                    {
                        int originalX = (int)((x * originalImage.Width) / newWidth);
                        int originalY = (int)((y * originalImage.Height) / newHeight);

                        int originalIndex = (originalY * originalImage.Stride) + (originalX * originalPixelSize);
                        int resultIndex = (y * resultImage.Stride) + (x * originalPixelSize);

                        Array.Copy(originalPixels, originalIndex, resultPixels, resultIndex, originalPixelSize);
                    }
                });

                Marshal.Copy(resultPixels, 0, resultImage.Scan0, resultPixels.Length);
            }
            finally
            {
                original.UnlockBits(originalImage);
                downsizeResult.UnlockBits(resultImage);
            }

            return downsizeResult;
        }


    }
}
