namespace WORK_1
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button_rgb_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "|*.png;*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(dialog.FileName);
                pictureBox.Image = bitmap;
                pictureBox.Refresh();
            }
        }
    }
}
