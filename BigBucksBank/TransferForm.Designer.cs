namespace BigBucksBank
{
    partial class TransferForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFromSvngs = new System.Windows.Forms.RadioButton();
            this.rbFromChkg = new System.Windows.Forms.RadioButton();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbToSvngs = new System.Windows.Forms.RadioButton();
            this.rbToChkg = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 55);
            this.label2.TabIndex = 5;
            this.label2.Text = "Big Bucks Bank ATM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(99, 419);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(171, 44);
            this.btnTransfer.TabIndex = 7;
            this.btnTransfer.Text = "TRANSFER";
            this.btnTransfer.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(340, 419);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 44);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFromSvngs);
            this.groupBox1.Controls.Add(this.rbFromChkg);
            this.groupBox1.Location = new System.Drawing.Point(194, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 47);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FROM";
            // 
            // rbFromSvngs
            // 
            this.rbFromSvngs.AutoSize = true;
            this.rbFromSvngs.Location = new System.Drawing.Point(170, 15);
            this.rbFromSvngs.Name = "rbFromSvngs";
            this.rbFromSvngs.Size = new System.Drawing.Size(63, 17);
            this.rbFromSvngs.TabIndex = 14;
            this.rbFromSvngs.TabStop = true;
            this.rbFromSvngs.Text = "Savings";
            this.rbFromSvngs.UseVisualStyleBackColor = true;
            // 
            // rbFromChkg
            // 
            this.rbFromChkg.AutoSize = true;
            this.rbFromChkg.Location = new System.Drawing.Point(52, 15);
            this.rbFromChkg.Name = "rbFromChkg";
            this.rbFromChkg.Size = new System.Drawing.Size(70, 17);
            this.rbFromChkg.TabIndex = 13;
            this.rbFromChkg.TabStop = true;
            this.rbFromChkg.Text = "Checking";
            this.rbFromChkg.UseVisualStyleBackColor = true;
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(193, 280);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(258, 115);
            this.rtbMessage.TabIndex = 23;
            this.rtbMessage.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Amount:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(241, 245);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(209, 20);
            this.tbAmount.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbToSvngs);
            this.groupBox2.Controls.Add(this.rbToChkg);
            this.groupBox2.Location = new System.Drawing.Point(194, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 47);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TO";
            // 
            // rbToSvngs
            // 
            this.rbToSvngs.AutoSize = true;
            this.rbToSvngs.Location = new System.Drawing.Point(170, 15);
            this.rbToSvngs.Name = "rbToSvngs";
            this.rbToSvngs.Size = new System.Drawing.Size(63, 17);
            this.rbToSvngs.TabIndex = 14;
            this.rbToSvngs.TabStop = true;
            this.rbToSvngs.Text = "Savings";
            this.rbToSvngs.UseVisualStyleBackColor = true;
            // 
            // rbToChkg
            // 
            this.rbToChkg.AutoSize = true;
            this.rbToChkg.Location = new System.Drawing.Point(52, 15);
            this.rbToChkg.Name = "rbToChkg";
            this.rbToChkg.Size = new System.Drawing.Size(70, 17);
            this.rbToChkg.TabIndex = 13;
            this.rbToChkg.TabStop = true;
            this.rbToChkg.Text = "Checking";
            this.rbToChkg.UseVisualStyleBackColor = true;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 532);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFromSvngs;
        private System.Windows.Forms.RadioButton rbFromChkg;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbToSvngs;
        private System.Windows.Forms.RadioButton rbToChkg;
    }
}