namespace BigBucksBank
{
    partial class ATMForm
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
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.rbWithdrawal = new System.Windows.Forms.RadioButton();
            this.rbBalance = new System.Windows.Forms.RadioButton();
            this.rbTransfer = new System.Windows.Forms.RadioButton();
            this.rbExit = new System.Windows.Forms.RadioButton();
            this.btnProceed = new System.Windows.Forms.Button();
            this.gboxMenu = new System.Windows.Forms.GroupBox();
            this.gboxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Big Bucks Bank ATM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to";
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Location = new System.Drawing.Point(44, 36);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(100, 17);
            this.rbDeposit.TabIndex = 1;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Make a Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            this.rbDeposit.CheckedChanged += new System.EventHandler(this.rbDeposit_CheckedChanged);
            // 
            // rbWithdrawal
            // 
            this.rbWithdrawal.AutoSize = true;
            this.rbWithdrawal.Location = new System.Drawing.Point(44, 59);
            this.rbWithdrawal.Name = "rbWithdrawal";
            this.rbWithdrawal.Size = new System.Drawing.Size(117, 17);
            this.rbWithdrawal.TabIndex = 2;
            this.rbWithdrawal.TabStop = true;
            this.rbWithdrawal.Text = "Make a Withdrawal";
            this.rbWithdrawal.UseVisualStyleBackColor = true;
            this.rbWithdrawal.CheckedChanged += new System.EventHandler(this.rbWithdrawal_CheckedChanged);
            // 
            // rbBalance
            // 
            this.rbBalance.AutoSize = true;
            this.rbBalance.Location = new System.Drawing.Point(44, 82);
            this.rbBalance.Name = "rbBalance";
            this.rbBalance.Size = new System.Drawing.Size(98, 17);
            this.rbBalance.TabIndex = 3;
            this.rbBalance.TabStop = true;
            this.rbBalance.Text = "Check Balance";
            this.rbBalance.UseVisualStyleBackColor = true;
            this.rbBalance.CheckedChanged += new System.EventHandler(this.rbBalance_CheckedChanged);
            // 
            // rbTransfer
            // 
            this.rbTransfer.AutoSize = true;
            this.rbTransfer.Location = new System.Drawing.Point(44, 105);
            this.rbTransfer.Name = "rbTransfer";
            this.rbTransfer.Size = new System.Drawing.Size(96, 17);
            this.rbTransfer.TabIndex = 4;
            this.rbTransfer.TabStop = true;
            this.rbTransfer.Text = "Transfer Funds";
            this.rbTransfer.UseVisualStyleBackColor = true;
            this.rbTransfer.CheckedChanged += new System.EventHandler(this.rbTransfer_CheckedChanged);
            // 
            // rbExit
            // 
            this.rbExit.AutoSize = true;
            this.rbExit.Location = new System.Drawing.Point(44, 128);
            this.rbExit.Name = "rbExit";
            this.rbExit.Size = new System.Drawing.Size(49, 17);
            this.rbExit.TabIndex = 5;
            this.rbExit.TabStop = true;
            this.rbExit.Text = "EXIT";
            this.rbExit.UseVisualStyleBackColor = true;
            this.rbExit.CheckedChanged += new System.EventHandler(this.rbExit_CheckedChanged);
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(218, 404);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(171, 44);
            this.btnProceed.TabIndex = 6;
            this.btnProceed.Text = "ENTER";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // gboxMenu
            // 
            this.gboxMenu.Controls.Add(this.rbExit);
            this.gboxMenu.Controls.Add(this.rbTransfer);
            this.gboxMenu.Controls.Add(this.rbBalance);
            this.gboxMenu.Controls.Add(this.rbWithdrawal);
            this.gboxMenu.Controls.Add(this.rbDeposit);
            this.gboxMenu.Location = new System.Drawing.Point(219, 149);
            this.gboxMenu.Name = "gboxMenu";
            this.gboxMenu.Size = new System.Drawing.Size(170, 170);
            this.gboxMenu.TabIndex = 10;
            this.gboxMenu.TabStop = false;
            this.gboxMenu.Text = "MENU";
            // 
            // ATMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 532);
            this.ControlBox = false;
            this.Controls.Add(this.gboxMenu);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ATMForm";
            this.Text = "ATMForm";
            this.Load += new System.EventHandler(this.ATMForm_Load);
            this.gboxMenu.ResumeLayout(false);
            this.gboxMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.RadioButton rbWithdrawal;
        private System.Windows.Forms.RadioButton rbBalance;
        private System.Windows.Forms.RadioButton rbTransfer;
        private System.Windows.Forms.RadioButton rbExit;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.GroupBox gboxMenu;
    }
}