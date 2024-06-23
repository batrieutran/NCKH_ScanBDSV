namespace NCKH_WinformScan
{
    partial class frmCources
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
            this.lblCources = new System.Windows.Forms.Label();
            this.gbCources = new System.Windows.Forms.GroupBox();
            this.nrCredits = new System.Windows.Forms.NumericUpDown();
            this.cbCourceName = new System.Windows.Forms.ComboBox();
            this.cbIDCource = new System.Windows.Forms.ComboBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblCourceName = new System.Windows.Forms.Label();
            this.lblIDCource = new System.Windows.Forms.Label();
            this.gbFunctionCources = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupset = new System.Windows.Forms.Button();
            this.btnfix = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dtMonHoc = new System.Windows.Forms.DataGridView();
            this.gbCources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrCredits)).BeginInit();
            this.gbFunctionCources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCources
            // 
            this.lblCources.AutoSize = true;
            this.lblCources.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCources.Location = new System.Drawing.Point(258, 22);
            this.lblCources.Name = "lblCources";
            this.lblCources.Size = new System.Drawing.Size(375, 40);
            this.lblCources.TabIndex = 1;
            this.lblCources.Text = "Management Cources\r\n";
            this.lblCources.Click += new System.EventHandler(this.lblCources_Click);
            // 
            // gbCources
            // 
            this.gbCources.Controls.Add(this.nrCredits);
            this.gbCources.Controls.Add(this.cbCourceName);
            this.gbCources.Controls.Add(this.cbIDCource);
            this.gbCources.Controls.Add(this.lblCredits);
            this.gbCources.Controls.Add(this.lblCourceName);
            this.gbCources.Controls.Add(this.lblIDCource);
            this.gbCources.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbCources.Location = new System.Drawing.Point(52, 87);
            this.gbCources.Name = "gbCources";
            this.gbCources.Size = new System.Drawing.Size(476, 312);
            this.gbCources.TabIndex = 2;
            this.gbCources.TabStop = false;
            this.gbCources.Text = "Infomation Cources";
            this.gbCources.Enter += new System.EventHandler(this.gbCources_Enter);
            // 
            // nrCredits
            // 
            this.nrCredits.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nrCredits.Location = new System.Drawing.Point(135, 177);
            this.nrCredits.Name = "nrCredits";
            this.nrCredits.Size = new System.Drawing.Size(48, 28);
            this.nrCredits.TabIndex = 2;
            // 
            // cbCourceName
            // 
            this.cbCourceName.FormattingEnabled = true;
            this.cbCourceName.Location = new System.Drawing.Point(135, 103);
            this.cbCourceName.Name = "cbCourceName";
            this.cbCourceName.Size = new System.Drawing.Size(256, 29);
            this.cbCourceName.TabIndex = 1;
            this.cbCourceName.SelectedIndexChanged += new System.EventHandler(this.cbCourceName_SelectedIndexChanged);
            // 
            // cbIDCource
            // 
            this.cbIDCource.FormattingEnabled = true;
            this.cbIDCource.Location = new System.Drawing.Point(135, 36);
            this.cbIDCource.Name = "cbIDCource";
            this.cbIDCource.Size = new System.Drawing.Size(135, 29);
            this.cbIDCource.TabIndex = 1;
            this.cbIDCource.SelectedIndexChanged += new System.EventHandler(this.cbIDCource_SelectedIndexChanged);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCredits.Location = new System.Drawing.Point(56, 184);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(73, 21);
            this.lblCredits.TabIndex = 0;
            this.lblCredits.Text = "Credits: ";
            this.lblCredits.Click += new System.EventHandler(this.lblCredits_Click);
            // 
            // lblCourceName
            // 
            this.lblCourceName.AutoSize = true;
            this.lblCourceName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCourceName.Location = new System.Drawing.Point(14, 106);
            this.lblCourceName.Name = "lblCourceName";
            this.lblCourceName.Size = new System.Drawing.Size(115, 21);
            this.lblCourceName.TabIndex = 0;
            this.lblCourceName.Text = "Cource Name:";
            this.lblCourceName.Click += new System.EventHandler(this.lblCourceName_Click);
            // 
            // lblIDCource
            // 
            this.lblIDCource.AutoSize = true;
            this.lblIDCource.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIDCource.Location = new System.Drawing.Point(50, 39);
            this.lblIDCource.Name = "lblIDCource";
            this.lblIDCource.Size = new System.Drawing.Size(79, 21);
            this.lblIDCource.TabIndex = 0;
            this.lblIDCource.Text = "IDCource";
            this.lblIDCource.Click += new System.EventHandler(this.lblIDCource_Click);
            // 
            // gbFunctionCources
            // 
            this.gbFunctionCources.Controls.Add(this.btndelete);
            this.gbFunctionCources.Controls.Add(this.btnupset);
            this.gbFunctionCources.Controls.Add(this.btnfix);
            this.gbFunctionCources.Controls.Add(this.btnadd);
            this.gbFunctionCources.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbFunctionCources.Location = new System.Drawing.Point(585, 87);
            this.gbFunctionCources.Name = "gbFunctionCources";
            this.gbFunctionCources.Size = new System.Drawing.Size(172, 312);
            this.gbFunctionCources.TabIndex = 3;
            this.gbFunctionCources.TabStop = false;
            this.gbFunctionCources.Text = "Function Cources";
            // 
            // btndelete
            // 
            this.btndelete.ForeColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(39, 103);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(96, 51);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupset
            // 
            this.btnupset.ForeColor = System.Drawing.Color.Black;
            this.btnupset.Location = new System.Drawing.Point(39, 245);
            this.btnupset.Name = "btnupset";
            this.btnupset.Size = new System.Drawing.Size(96, 51);
            this.btnupset.TabIndex = 0;
            this.btnupset.Text = "UPSET";
            this.btnupset.UseVisualStyleBackColor = true;
            // 
            // btnfix
            // 
            this.btnfix.ForeColor = System.Drawing.Color.Blue;
            this.btnfix.Location = new System.Drawing.Point(39, 169);
            this.btnfix.Name = "btnfix";
            this.btnfix.Size = new System.Drawing.Size(96, 51);
            this.btnfix.TabIndex = 0;
            this.btnfix.Text = "FIX";
            this.btnfix.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnadd.Location = new System.Drawing.Point(39, 27);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(96, 51);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // dtMonHoc
            // 
            this.dtMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMonHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtMonHoc.Location = new System.Drawing.Point(0, 422);
            this.dtMonHoc.Name = "dtMonHoc";
            this.dtMonHoc.RowHeadersWidth = 51;
            this.dtMonHoc.RowTemplate.Height = 24;
            this.dtMonHoc.Size = new System.Drawing.Size(807, 231);
            this.dtMonHoc.TabIndex = 4;
            // 
            // frmCources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 653);
            this.Controls.Add(this.dtMonHoc);
            this.Controls.Add(this.gbFunctionCources);
            this.Controls.Add(this.gbCources);
            this.Controls.Add(this.lblCources);
            this.MaximumSize = new System.Drawing.Size(825, 700);
            this.MinimumSize = new System.Drawing.Size(825, 700);
            this.Name = "frmCources";
            this.Text = "COURCES";
            this.Load += new System.EventHandler(this.frmCources_Load);
            this.gbCources.ResumeLayout(false);
            this.gbCources.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrCredits)).EndInit();
            this.gbFunctionCources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCources;
        private System.Windows.Forms.GroupBox gbCources;
        private System.Windows.Forms.ComboBox cbCourceName;
        private System.Windows.Forms.Label lblCourceName;
        private System.Windows.Forms.ComboBox cbIDCource;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblIDCource;
        private System.Windows.Forms.GroupBox gbFunctionCources;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnfix;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupset;
        private System.Windows.Forms.DataGridView dtMonHoc;
        private System.Windows.Forms.NumericUpDown nrCredits;
    }
}