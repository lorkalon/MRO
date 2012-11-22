using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MRO_Lib;


namespace Binarization120
{
    public partial class Binarization120Form : Form
    {
        
        byte[,] mask = { { 255, 0, 255 }, { 255, 0, 255 }, { 0, 0, 255 } };

        bool IsPictureloaded = false;
        ImageManager manager;
        
        public Binarization120Form()
        {
            InitializeComponent();

        }


        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                string path = openFileDialog.FileName;
                Bitmap bmp = new Bitmap(path);
                PictureBox.Image = bmp;

                bmp = new Bitmap(PictureBox.Image);

                IsPictureloaded = true;
                
                manager = new ImageManager(bmp);
                
            }
        }

        void ProcessingLabel(string s)
        {
            StatusLabel.Text = s;
            statusStrip1.Update();
        }

        private void grayscaleButton_Click(object sender, EventArgs e)
        {
            if (manager != null)
            {
                Bitmap bmp;

                if (IsPictureloaded)
                {
                    ProcessingLabel("Grayscaling starting...");

                    bmp = manager.ExecuteCommand(((Button)sender).Text);

                    if (bmp != null)
                        PictureBox.Image = bmp;

                    ProcessingLabel("Ready");
                }
            }

        }


        private void binarizeButton_Click(object sender, EventArgs e)
        {
            if (manager != null)
            {
                Bitmap bmp;
                try
                {
                    int threshold = Convert.ToInt32(AddValueTextBox.Text);
                    manager.SetThreshold = threshold;
                    ProcessingLabel("Binarize starting...");
                    bmp = manager.ExecuteCommand(((Button)sender).Text);

                    if (bmp != null)
                        PictureBox.Image = bmp;

                    ProcessingLabel("Ready");
                }

                catch (System.FormatException)
                {
                    MessageBox.Show("Check threshold value!(Only int)");
                }
            }

        }


           private void SetMaskButton_Click(object sender, EventArgs e)
           {
               if (manager != null)
               {
                   Binarisation120.MaskForm mf = new Binarisation120.MaskForm(mask);
                   mf.ShowDialog();
                   mask = mf.GetMask;
                   manager.SetMask = mask;
               }
           }

           private void ErosionButton_Click(object sender, EventArgs e)
           {
               if (manager != null)
               {
                   Bitmap bmp;
                   manager.SetMask = mask;

                   ProcessingLabel("Erosion starting...");

                   bmp = manager.ExecuteCommand(((Button)sender).Text);

                   if (bmp != null)
                       PictureBox.Image = bmp;

                   ProcessingLabel("Ready");
               }

           }

       
        private void SaveButton_Click(object sender, EventArgs e)
           {
               if (manager != null)
               {
                   saveFileDialog.ShowDialog();
                   string path = saveFileDialog.FileName;
                   PictureBox.Image.Save(path);
               }
           }

        private void Undo_Redo_Button_Click(object sender, EventArgs e)
        {

            if (manager != null)
            {
                ProcessingLabel("loading...");

                Bitmap temp = null;

                switch (((ToolStripButton)sender).Text)
                {
                    case "undo":
                    {
                       temp = manager.Undo();
                        break;
                    }
                    
                    case "redo":
                    {
                        temp = manager.Redo();
                        break;
                    }
                }

                if (temp != null)
                    PictureBox.Image = temp;

                ProcessingLabel("Ready");
            }


        }

        private void LRTB_Button_Click(object sender, EventArgs e)
        {
            if (manager != null)
            {
                Bitmap bmp;

                ProcessingLabel("Erosion starting...");

                bmp = manager.ExecuteCommand(((Button)sender).Text);

                if (bmp != null)
                    PictureBox.Image = bmp;

                ProcessingLabel("Ready");
            }
        }

    }
}
