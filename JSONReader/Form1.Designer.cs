namespace JSONReader
{
    partial class frmJSONReader
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
            this.dgView = new System.Windows.Forms.DataGridView();
            this.btnReadJson = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnVSTO = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.chkSaveWithoutCalc = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(835, 79);
            this.dgView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 102;
            this.dgView.RowTemplate.Height = 40;
            this.dgView.Size = new System.Drawing.Size(592, 455);
            this.dgView.TabIndex = 0;
            // 
            // btnReadJson
            // 
            this.btnReadJson.Location = new System.Drawing.Point(1485, 200);
            this.btnReadJson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadJson.Name = "btnReadJson";
            this.btnReadJson.Size = new System.Drawing.Size(243, 86);
            this.btnReadJson.TabIndex = 1;
            this.btnReadJson.Text = "Read JSON";
            this.btnReadJson.UseVisualStyleBackColor = true;
            this.btnReadJson.Click += new System.EventHandler(this.btnReadJson_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1485, 548);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(243, 86);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFile.Location = new System.Drawing.Point(32, 24);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(341, 34);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "D:\\Temp\\JSON\\9946.json";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(1485, 81);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(237, 83);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(813, 553);
            this.btnRun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(243, 103);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "CalcNoteAnd SaveByNoteID";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnVSTO
            // 
            this.btnVSTO.Location = new System.Drawing.Point(1115, 553);
            this.btnVSTO.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnVSTO.Name = "btnVSTO";
            this.btnVSTO.Size = new System.Drawing.Size(229, 103);
            this.btnVSTO.TabIndex = 6;
            this.btnVSTO.Text = "CalcandSave VSTOJson";
            this.btnVSTO.UseVisualStyleBackColor = true;
            this.btnVSTO.Click += new System.EventHandler(this.btnVSTO_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(34, 85);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(753, 431);
            this.txtStatus.TabIndex = 7;
            // 
            // chkSaveWithoutCalc
            // 
            this.chkSaveWithoutCalc.AutoSize = true;
            this.chkSaveWithoutCalc.Location = new System.Drawing.Point(67, 553);
            this.chkSaveWithoutCalc.Name = "chkSaveWithoutCalc";
            this.chkSaveWithoutCalc.Size = new System.Drawing.Size(272, 36);
            this.chkSaveWithoutCalc.TabIndex = 8;
            this.chkSaveWithoutCalc.Text = "SaveWithoutCalc";
            this.chkSaveWithoutCalc.UseVisualStyleBackColor = true;
            this.chkSaveWithoutCalc.CheckedChanged += new System.EventHandler(this.chkSaveWithoutCalc_CheckedChanged);
            // 
            // frmJSONReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 658);
            this.Controls.Add(this.chkSaveWithoutCalc);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnVSTO);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReadJson);
            this.Controls.Add(this.dgView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmJSONReader";
            this.Text = "Read JSON Files";
            this.Load += new System.EventHandler(this.frmJSONReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button btnReadJson;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnVSTO;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.CheckBox chkSaveWithoutCalc;
    }
}

