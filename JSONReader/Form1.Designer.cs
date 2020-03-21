﻿namespace JSONReader
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
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(30, 162);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 102;
            this.dgView.RowTemplate.Height = 40;
            this.dgView.Size = new System.Drawing.Size(2223, 888);
            this.dgView.TabIndex = 0;
            // 
            // btnReadJson
            // 
            this.btnReadJson.Location = new System.Drawing.Point(2323, 577);
            this.btnReadJson.Name = "btnReadJson";
            this.btnReadJson.Size = new System.Drawing.Size(179, 85);
            this.btnReadJson.TabIndex = 1;
            this.btnReadJson.Text = "Read JSON";
            this.btnReadJson.UseVisualStyleBackColor = true;
            this.btnReadJson.Click += new System.EventHandler(this.btnReadJson_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(2310, 962);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 86);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(32, 24);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(848, 80);
            this.lblFile.TabIndex = 3;
            this.lblFile.Text = "D:\\Temp\\JSON\\9946.json";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(2302, 38);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(200, 84);
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
            this.btnRun.Location = new System.Drawing.Point(2323, 778);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(179, 80);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run M61";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // frmJSONReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2524, 1154);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReadJson);
            this.Controls.Add(this.dgView);
            this.Name = "frmJSONReader";
            this.Text = "Read JSON Files";
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
    }
}
