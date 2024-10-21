namespace DownloaderForm
{
    partial class VideoDwonloader
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.outputLbl = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpenDestination = new System.Windows.Forms.Button();
            this.btnSetDestination = new System.Windows.Forms.Button();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblDwonloadingFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(328, 238);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(134, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Start Dwonload";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(201, 157);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(343, 20);
            this.textUrl.TabIndex = 1;
            this.textUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // outputLbl
            // 
            this.outputLbl.AutoSize = true;
            this.outputLbl.Location = new System.Drawing.Point(284, 257);
            this.outputLbl.Name = "outputLbl";
            this.outputLbl.Size = new System.Drawing.Size(0, 13);
            this.outputLbl.TabIndex = 2;
            this.outputLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(139, 295);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(524, 23);
            this.progressBar.TabIndex = 3;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(202, 203);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxFrom.TabIndex = 4;
            this.textBoxFrom.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(559, 203);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTo.TabIndex = 5;
            this.textBoxTo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "From";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Base URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Video Dwonloader";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnOpenDestination
            // 
            this.btnOpenDestination.Location = new System.Drawing.Point(559, 354);
            this.btnOpenDestination.Name = "btnOpenDestination";
            this.btnOpenDestination.Size = new System.Drawing.Size(104, 23);
            this.btnOpenDestination.TabIndex = 10;
            this.btnOpenDestination.Text = "Open Destination";
            this.btnOpenDestination.UseVisualStyleBackColor = true;
            this.btnOpenDestination.Click += new System.EventHandler(this.btnOpenDestination_Click);
            // 
            // btnSetDestination
            // 
            this.btnSetDestination.Location = new System.Drawing.Point(559, 157);
            this.btnSetDestination.Name = "btnSetDestination";
            this.btnSetDestination.Size = new System.Drawing.Size(104, 23);
            this.btnSetDestination.TabIndex = 9;
            this.btnSetDestination.Text = "Set Destination";
            this.btnSetDestination.UseVisualStyleBackColor = true;
            this.btnSetDestination.Click += new System.EventHandler(this.btnSetDestination_Click);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(142, 333);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(0, 13);
            this.lblDestination.TabIndex = 12;
            // 
            // lblDwonloadingFile
            // 
            this.lblDwonloadingFile.AutoSize = true;
            this.lblDwonloadingFile.Location = new System.Drawing.Point(258, 270);
            this.lblDwonloadingFile.Margin = new System.Windows.Forms.Padding(0);
            this.lblDwonloadingFile.Name = "lblDwonloadingFile";
            this.lblDwonloadingFile.Size = new System.Drawing.Size(119, 13);
            this.lblDwonloadingFile.TabIndex = 13;
            this.lblDwonloadingFile.Text = "Dwonloading File Name";
            this.lblDwonloadingFile.Click += new System.EventHandler(this.label5_Click);
            // 
            // VideoDwonloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDwonloadingFile);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOpenDestination);
            this.Controls.Add(this.btnSetDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.outputLbl);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.btnDownload);
            this.Name = "VideoDwonloader";
            this.Text = "Video Dwonloader";
            this.Load += new System.EventHandler(this.VideoDwonloader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.Label outputLbl;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpenDestination;
        private System.Windows.Forms.Button btnSetDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblDwonloadingFile;
    }
}

