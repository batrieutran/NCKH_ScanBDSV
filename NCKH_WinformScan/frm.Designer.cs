namespace NCKH_WinformScan
{
    partial class frmDisplayScan
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblResultPicture = new System.Windows.Forms.Label();
            this.lblPicture = new System.Windows.Forms.Label();
            this.rtbResultImage = new System.Windows.Forms.RichTextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnProcess.Location = new System.Drawing.Point(447, 373);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(112, 37);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoad.Location = new System.Drawing.Point(116, 634);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 37);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Browser";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblResultPicture
            // 
            this.lblResultPicture.AutoSize = true;
            this.lblResultPicture.Font = new System.Drawing.Font("SVN-Aaron Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblResultPicture.Location = new System.Drawing.Point(846, 36);
            this.lblResultPicture.Name = "lblResultPicture";
            this.lblResultPicture.Size = new System.Drawing.Size(233, 45);
            this.lblResultPicture.TabIndex = 6;
            this.lblResultPicture.Text = "Result Picture";
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Font = new System.Drawing.Font("SVN-Aaron Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPicture.Location = new System.Drawing.Point(124, 36);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(126, 45);
            this.lblPicture.TabIndex = 7;
            this.lblPicture.Text = "Picture";
            // 
            // rtbResultImage
            // 
            this.rtbResultImage.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbResultImage.Location = new System.Drawing.Point(618, 84);
            this.rtbResultImage.Name = "rtbResultImage";
            this.rtbResultImage.Size = new System.Drawing.Size(753, 536);
            this.rtbResultImage.TabIndex = 5;
            this.rtbResultImage.Text = "";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.Location = new System.Drawing.Point(29, 94);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(346, 512);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 10;
            this.pbImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmDisplayScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1439, 691);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblResultPicture);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.rtbResultImage);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmDisplayScan";
            this.Text = "DISPLAY SCAN DOCUMENT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblResultPicture;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.RichTextBox rtbResultImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

