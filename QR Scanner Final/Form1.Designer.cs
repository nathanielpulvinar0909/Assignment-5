namespace QR_Scanner_Final
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmcbxDevice = new System.Windows.Forms.ComboBox();
            this.pctrbxDevice = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblQRCodeScanner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Bisque;
            this.btnStart.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(533, 139);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(297, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmcbxDevice
            // 
            this.cmcbxDevice.FormattingEnabled = true;
            this.cmcbxDevice.Location = new System.Drawing.Point(131, 147);
            this.cmcbxDevice.Name = "cmcbxDevice";
            this.cmcbxDevice.Size = new System.Drawing.Size(305, 21);
            this.cmcbxDevice.TabIndex = 1;
            // 
            // pctrbxDevice
            // 
            this.pctrbxDevice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctrbxDevice.Location = new System.Drawing.Point(29, 190);
            this.pctrbxDevice.Name = "pctrbxDevice";
            this.pctrbxDevice.Size = new System.Drawing.Size(498, 508);
            this.pctrbxDevice.TabIndex = 2;
            this.pctrbxDevice.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Camera: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(533, 190);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 508);
            this.textBox1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblQRCodeScanner
            // 
            this.lblQRCodeScanner.AutoSize = true;
            this.lblQRCodeScanner.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQRCodeScanner.Location = new System.Drawing.Point(186, 43);
            this.lblQRCodeScanner.Name = "lblQRCodeScanner";
            this.lblQRCodeScanner.Size = new System.Drawing.Size(590, 74);
            this.lblQRCodeScanner.TabIndex = 5;
            this.lblQRCodeScanner.Text = "QR Code Scanner";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 719);
            this.Controls.Add(this.lblQRCodeScanner);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctrbxDevice);
            this.Controls.Add(this.cmcbxDevice);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code FInal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmcbxDevice;
        private System.Windows.Forms.PictureBox pctrbxDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblQRCodeScanner;
    }
}

