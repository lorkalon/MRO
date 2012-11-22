namespace Binarization120
{
    partial class Binarization120Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Binarization120Form));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grayscaleButton = new System.Windows.Forms.Button();
            this.binarizeButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.AddValueTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SetMaskButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.UndoButton = new System.Windows.Forms.ToolStripButton();
            this.RedoButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.PictureTabPage = new System.Windows.Forms.TabPage();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.PictureTabControl = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LRTB_Button = new System.Windows.Forms.Button();
            this.ErosionButton = new System.Windows.Forms.Button();
            this.newWindowButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.PictureTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.PictureTabControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grayscaleButton
            // 
            this.grayscaleButton.Location = new System.Drawing.Point(3, 15);
            this.grayscaleButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grayscaleButton.Name = "grayscaleButton";
            this.grayscaleButton.Size = new System.Drawing.Size(119, 30);
            this.grayscaleButton.TabIndex = 7;
            this.grayscaleButton.Text = "To Grayscale";
            this.grayscaleButton.UseVisualStyleBackColor = true;
            this.grayscaleButton.Click += new System.EventHandler(this.grayscaleButton_Click);
            // 
            // binarizeButton
            // 
            this.binarizeButton.Location = new System.Drawing.Point(3, 62);
            this.binarizeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.binarizeButton.Name = "binarizeButton";
            this.binarizeButton.Size = new System.Drawing.Size(119, 30);
            this.binarizeButton.TabIndex = 7;
            this.binarizeButton.Text = "Start Binarize";
            this.binarizeButton.UseVisualStyleBackColor = true;
            this.binarizeButton.Click += new System.EventHandler(this.binarizeButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Forte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Label,
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1034, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Label
            // 
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(53, 17);
            this.Label.Text = "Status:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(48, 17);
            this.StatusLabel.Text = "Ready";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStrip1.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.AddValueTextBox,
            this.toolStripSeparator2,
            this.SetMaskButton,
            this.toolStripSeparator3,
            this.UndoButton,
            this.RedoButton,
            this.toolStripSeparator4,
            this.SaveButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1034, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenFileButton.Image")));
            this.OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(95, 22);
            this.OpenFileButton.Text = "Load Image";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(166, 22);
            this.toolStripLabel1.Text = "Add to the threshold value";
            // 
            // AddValueTextBox
            // 
            this.AddValueTextBox.MaxLength = 2;
            this.AddValueTextBox.Name = "AddValueTextBox";
            this.AddValueTextBox.Size = new System.Drawing.Size(40, 25);
            this.AddValueTextBox.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SetMaskButton
            // 
            this.SetMaskButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SetMaskButton.Image = ((System.Drawing.Image)(resources.GetObject("SetMaskButton.Image")));
            this.SetMaskButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SetMaskButton.Name = "SetMaskButton";
            this.SetMaskButton.Size = new System.Drawing.Size(62, 22);
            this.SetMaskButton.Text = "Set mask";
            this.SetMaskButton.Click += new System.EventHandler(this.SetMaskButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // UndoButton
            // 
            this.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(23, 22);
            this.UndoButton.Text = "undo";
            this.UndoButton.Click += new System.EventHandler(this.Undo_Redo_Button_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedoButton.Image = ((System.Drawing.Image)(resources.GetObject("RedoButton.Image")));
            this.RedoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(23, 22);
            this.RedoButton.Text = "redo";
            this.RedoButton.Click += new System.EventHandler(this.Undo_Redo_Button_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(23, 22);
            this.SaveButton.Text = "toolStripButton1";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PictureTabPage
            // 
            this.PictureTabPage.Controls.Add(this.PictureBox);
            this.PictureTabPage.Location = new System.Drawing.Point(4, 26);
            this.PictureTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureTabPage.Name = "PictureTabPage";
            this.PictureTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureTabPage.Size = new System.Drawing.Size(865, 514);
            this.PictureTabPage.TabIndex = 0;
            this.PictureTabPage.Text = "Picture";
            this.PictureTabPage.UseVisualStyleBackColor = true;
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(3, 4);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(859, 506);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // PictureTabControl
            // 
            this.PictureTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureTabControl.Controls.Add(this.PictureTabPage);
            this.PictureTabControl.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureTabControl.Location = new System.Drawing.Point(12, 29);
            this.PictureTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PictureTabControl.Name = "PictureTabControl";
            this.PictureTabControl.SelectedIndex = 0;
            this.PictureTabControl.Size = new System.Drawing.Size(873, 544);
            this.PictureTabControl.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.newWindowButton);
            this.panel1.Controls.Add(this.LRTB_Button);
            this.panel1.Controls.Add(this.ErosionButton);
            this.panel1.Controls.Add(this.grayscaleButton);
            this.panel1.Controls.Add(this.binarizeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(894, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 552);
            this.panel1.TabIndex = 10;
            // 
            // LRTB_Button
            // 
            this.LRTB_Button.Location = new System.Drawing.Point(3, 158);
            this.LRTB_Button.Name = "LRTB_Button";
            this.LRTB_Button.Size = new System.Drawing.Size(119, 30);
            this.LRTB_Button.TabIndex = 8;
            this.LRTB_Button.Text = "LRTB";
            this.LRTB_Button.UseVisualStyleBackColor = true;
            this.LRTB_Button.Click += new System.EventHandler(this.LRTB_Button_Click);
            // 
            // ErosionButton
            // 
            this.ErosionButton.Location = new System.Drawing.Point(3, 109);
            this.ErosionButton.Name = "ErosionButton";
            this.ErosionButton.Size = new System.Drawing.Size(119, 30);
            this.ErosionButton.TabIndex = 8;
            this.ErosionButton.Text = "Start erosion";
            this.ErosionButton.UseVisualStyleBackColor = true;
            this.ErosionButton.Click += new System.EventHandler(this.ErosionButton_Click);
            // 
            // newWindowButton
            // 
            this.newWindowButton.Location = new System.Drawing.Point(15, 520);
            this.newWindowButton.Name = "newWindowButton";
            this.newWindowButton.Size = new System.Drawing.Size(107, 29);
            this.newWindowButton.TabIndex = 9;
            this.newWindowButton.Text = "Go to OPR";
            this.newWindowButton.UseVisualStyleBackColor = true;
            // 
            // Binarization120Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PictureTabControl);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1235, 671);
            this.Name = "Binarization120Form";
            this.Text = "MRO";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.PictureTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.PictureTabControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button grayscaleButton;
        private System.Windows.Forms.Button binarizeButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpenFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox AddValueTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel Label;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabPage PictureTabPage;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.TabControl PictureTabControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ErosionButton;
        private System.Windows.Forms.ToolStripButton SetMaskButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton UndoButton;
        private System.Windows.Forms.ToolStripButton RedoButton;
        private System.Windows.Forms.Button LRTB_Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.Button newWindowButton;

    }
}

