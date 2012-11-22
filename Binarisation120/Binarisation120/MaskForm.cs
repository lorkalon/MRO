using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Binarisation120
{
    public partial class MaskForm : Form
    {
        private byte [,] defaultMask;
        private byte [,] mask;

        public MaskForm(byte [,] prevMask)
        {
            defaultMask = new byte[3, 3] { { 255, 0, 255 }, { 255, 0, 255 }, { 0, 0, 255 } };
            mask = prevMask;

            InitializeComponent();
            MaskGridView.Rows.Add(3);

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (mask[i, j] == 255)
                       MaskGridView[i, j].Value = 0;
                    else
                       MaskGridView[i, j].Value = 1;

        }


        private void SetMaskButton_Click(object sender, EventArgs e)
        {
            byte [,] tempMask = new byte [3,3];
            bool correct = true;

            try
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                    {
                        if (Convert.ToInt32(MaskGridView[i, j].Value) == 1)
                            tempMask[i, j] = 0;
                        else
                        {
                            if (Convert.ToInt32(MaskGridView[i, j].Value) == 0)
                                tempMask[i, j] = 255;
                            else 
                                throw(new Exception("Uncorrect mask! Only '0' or '1'."));
                        }
                    }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Mask was setted in default value { { 0, 1, 0 }, { 0, 1, 0 }, { 1, 1, 0 } }"); //"Uncorrect mask! Only '0' or '1'. Mask was setted in default value { { 0, 1, 0 }, { 0, 1, 0 }, { 1, 1, 0 } }"
                correct = false;
                mask = defaultMask;
            }

            if (correct == true)
            {
                mask = tempMask;
            }

            this.Close();
        }

        public byte[,] GetMask
        {
          get
          {
              return mask;
          }
        }

        

    }
}
