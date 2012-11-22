namespace Binarisation120
{
    partial class MaskForm
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
            this.MaskGridView = new System.Windows.Forms.DataGridView();
            this.SetMaskButton = new System.Windows.Forms.Button();
            this.Col0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MaskGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MaskGridView
            // 
            this.MaskGridView.AllowUserToAddRows = false;
            this.MaskGridView.AllowUserToDeleteRows = false;
            this.MaskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaskGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col0,
            this.Col1,
            this.Col2});
            this.MaskGridView.Location = new System.Drawing.Point(8, 2);
            this.MaskGridView.Name = "MaskGridView";
            this.MaskGridView.RowTemplate.Height = 30;
            this.MaskGridView.Size = new System.Drawing.Size(163, 150);
            this.MaskGridView.TabIndex = 0;
            // 
            // SetMaskButton
            // 
            this.SetMaskButton.Location = new System.Drawing.Point(8, 158);
            this.SetMaskButton.Name = "SetMaskButton";
            this.SetMaskButton.Size = new System.Drawing.Size(160, 23);
            this.SetMaskButton.TabIndex = 1;
            this.SetMaskButton.Text = "Set mask";
            this.SetMaskButton.UseVisualStyleBackColor = true;
            this.SetMaskButton.Click += new System.EventHandler(this.SetMaskButton_Click);
            // 
            // Col0
            // 
            this.Col0.HeaderText = "0";
            this.Col0.MaxInputLength = 1;
            this.Col0.Name = "Col0";
            this.Col0.Width = 40;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "1";
            this.Col1.MaxInputLength = 1;
            this.Col1.Name = "Col1";
            this.Col1.Width = 40;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "2";
            this.Col2.MaxInputLength = 1;
            this.Col2.Name = "Col2";
            this.Col2.Width = 40;
            // 
            // MaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 185);
            this.Controls.Add(this.SetMaskButton);
            this.Controls.Add(this.MaskGridView);
            this.Name = "MaskForm";
            this.Text = "Mask";
            ((System.ComponentModel.ISupportInitialize)(this.MaskGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MaskGridView;
        private System.Windows.Forms.Button SetMaskButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col0;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
    }
}