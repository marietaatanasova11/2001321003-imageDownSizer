namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button downSizeButton;
        private OpenFileDialog openFileDialog1;
        private Button selectImageButton;
        private PictureBox originalPhotoPictureBox;
        private PictureBox DownSizedPhotoPictureBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox DownScalePercentageTextBox;
        private Button parallelDownSizeButton;
    }
}
