namespace WarmUpExercise_WindowsForm_Menu
{
    partial class HomeActivity
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
            this.frmHomeView = new System.Windows.Forms.Panel();
            this.btnSumOfDigits = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnSwapper = new System.Windows.Forms.Button();
            this.btnOddEven = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OddEvenView = new System.Windows.Forms.Panel();
            this.btnOEResult = new System.Windows.Forms.Button();
            this.lblOEResult = new System.Windows.Forms.Label();
            this.txtOEInput = new System.Windows.Forms.TextBox();
            this.SwapperView = new System.Windows.Forms.Panel();
            this.txtSwapperResult = new System.Windows.Forms.Button();
            this.txtSwapValB = new System.Windows.Forms.TextBox();
            this.txtSwapValA = new System.Windows.Forms.TextBox();
            this.ReverseView = new System.Windows.Forms.Panel();
            this.btnReverseResult = new System.Windows.Forms.Button();
            this.lblReverseResult = new System.Windows.Forms.Label();
            this.txtReverseInput = new System.Windows.Forms.TextBox();
            this.SumOfDigitsView = new System.Windows.Forms.Panel();
            this.btnSODResult = new System.Windows.Forms.Button();
            this.lblSODResult = new System.Windows.Forms.Label();
            this.txtSODInput = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.frmHomeView.SuspendLayout();
            this.OddEvenView.SuspendLayout();
            this.SwapperView.SuspendLayout();
            this.ReverseView.SuspendLayout();
            this.SumOfDigitsView.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmHomeView
            // 
            this.frmHomeView.BackColor = System.Drawing.SystemColors.Control;
            this.frmHomeView.Controls.Add(this.btnSumOfDigits);
            this.frmHomeView.Controls.Add(this.btnReverse);
            this.frmHomeView.Controls.Add(this.btnSwapper);
            this.frmHomeView.Controls.Add(this.btnOddEven);
            this.frmHomeView.Location = new System.Drawing.Point(-2, 77);
            this.frmHomeView.Name = "frmHomeView";
            this.frmHomeView.Size = new System.Drawing.Size(509, 508);
            this.frmHomeView.TabIndex = 4;
            // 
            // btnSumOfDigits
            // 
            this.btnSumOfDigits.Location = new System.Drawing.Point(269, 238);
            this.btnSumOfDigits.Name = "btnSumOfDigits";
            this.btnSumOfDigits.Size = new System.Drawing.Size(188, 154);
            this.btnSumOfDigits.TabIndex = 7;
            this.btnSumOfDigits.Text = "SUM of DIGITS";
            this.btnSumOfDigits.UseVisualStyleBackColor = true;
            this.btnSumOfDigits.Click += new System.EventHandler(this.btnSumOfDigits_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(65, 238);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(188, 154);
            this.btnReverse.TabIndex = 6;
            this.btnReverse.Text = "REVERSE";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnSwapper
            // 
            this.btnSwapper.Location = new System.Drawing.Point(269, 80);
            this.btnSwapper.Name = "btnSwapper";
            this.btnSwapper.Size = new System.Drawing.Size(188, 154);
            this.btnSwapper.TabIndex = 5;
            this.btnSwapper.Text = "SWAPPER";
            this.btnSwapper.UseVisualStyleBackColor = true;
            this.btnSwapper.Click += new System.EventHandler(this.btnSwapper_Click);
            // 
            // btnOddEven
            // 
            this.btnOddEven.Location = new System.Drawing.Point(65, 80);
            this.btnOddEven.Name = "btnOddEven";
            this.btnOddEven.Size = new System.Drawing.Size(188, 154);
            this.btnOddEven.TabIndex = 4;
            this.btnOddEven.Text = "ODD ? EVEN";
            this.btnOddEven.UseVisualStyleBackColor = true;
            this.btnOddEven.Click += new System.EventHandler(this.btnOddEven_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alien Encounters", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Menu App";
            // 
            // OddEvenView
            // 
            this.OddEvenView.BackColor = System.Drawing.Color.White;
            this.OddEvenView.Controls.Add(this.btnOEResult);
            this.OddEvenView.Controls.Add(this.lblOEResult);
            this.OddEvenView.Controls.Add(this.txtOEInput);
            this.OddEvenView.Location = new System.Drawing.Point(0, 77);
            this.OddEvenView.Name = "OddEvenView";
            this.OddEvenView.Size = new System.Drawing.Size(509, 505);
            this.OddEvenView.TabIndex = 8;
            // 
            // btnOEResult
            // 
            this.btnOEResult.Location = new System.Drawing.Point(180, 127);
            this.btnOEResult.Name = "btnOEResult";
            this.btnOEResult.Size = new System.Drawing.Size(154, 52);
            this.btnOEResult.TabIndex = 10;
            this.btnOEResult.Text = "Check!";
            this.btnOEResult.UseVisualStyleBackColor = true;
            this.btnOEResult.Click += new System.EventHandler(this.btnOEResult_Click);
            // 
            // lblOEResult
            // 
            this.lblOEResult.AutoSize = true;
            this.lblOEResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOEResult.ForeColor = System.Drawing.Color.White;
            this.lblOEResult.Location = new System.Drawing.Point(132, 249);
            this.lblOEResult.Name = "lblOEResult";
            this.lblOEResult.Size = new System.Drawing.Size(0, 69);
            this.lblOEResult.TabIndex = 9;
            this.lblOEResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOEInput
            // 
            this.txtOEInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOEInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOEInput.Location = new System.Drawing.Point(138, 80);
            this.txtOEInput.Name = "txtOEInput";
            this.txtOEInput.Size = new System.Drawing.Size(233, 41);
            this.txtOEInput.TabIndex = 0;
            this.txtOEInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SwapperView
            // 
            this.SwapperView.BackColor = System.Drawing.Color.White;
            this.SwapperView.Controls.Add(this.txtSwapperResult);
            this.SwapperView.Controls.Add(this.txtSwapValB);
            this.SwapperView.Controls.Add(this.txtSwapValA);
            this.SwapperView.Location = new System.Drawing.Point(0, 77);
            this.SwapperView.Name = "SwapperView";
            this.SwapperView.Size = new System.Drawing.Size(509, 502);
            this.SwapperView.TabIndex = 9;
            // 
            // txtSwapperResult
            // 
            this.txtSwapperResult.Location = new System.Drawing.Point(180, 218);
            this.txtSwapperResult.Name = "txtSwapperResult";
            this.txtSwapperResult.Size = new System.Drawing.Size(154, 52);
            this.txtSwapperResult.TabIndex = 11;
            this.txtSwapperResult.Text = "Swap!";
            this.txtSwapperResult.UseVisualStyleBackColor = true;
            this.txtSwapperResult.Click += new System.EventHandler(this.txtSwapperResult_Click);
            // 
            // txtSwapValB
            // 
            this.txtSwapValB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSwapValB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSwapValB.Location = new System.Drawing.Point(138, 289);
            this.txtSwapValB.Name = "txtSwapValB";
            this.txtSwapValB.Size = new System.Drawing.Size(233, 41);
            this.txtSwapValB.TabIndex = 2;
            this.txtSwapValB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSwapValA
            // 
            this.txtSwapValA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSwapValA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSwapValA.Location = new System.Drawing.Point(138, 155);
            this.txtSwapValA.Name = "txtSwapValA";
            this.txtSwapValA.Size = new System.Drawing.Size(233, 41);
            this.txtSwapValA.TabIndex = 1;
            this.txtSwapValA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReverseView
            // 
            this.ReverseView.BackColor = System.Drawing.Color.White;
            this.ReverseView.Controls.Add(this.btnReverseResult);
            this.ReverseView.Controls.Add(this.lblReverseResult);
            this.ReverseView.Controls.Add(this.txtReverseInput);
            this.ReverseView.Location = new System.Drawing.Point(0, 77);
            this.ReverseView.Name = "ReverseView";
            this.ReverseView.Size = new System.Drawing.Size(509, 505);
            this.ReverseView.TabIndex = 10;
            // 
            // btnReverseResult
            // 
            this.btnReverseResult.Location = new System.Drawing.Point(180, 127);
            this.btnReverseResult.Name = "btnReverseResult";
            this.btnReverseResult.Size = new System.Drawing.Size(154, 52);
            this.btnReverseResult.TabIndex = 16;
            this.btnReverseResult.Text = "Reverse!";
            this.btnReverseResult.UseVisualStyleBackColor = true;
            this.btnReverseResult.Click += new System.EventHandler(this.btnReverseResult_Click);
            // 
            // lblReverseResult
            // 
            this.lblReverseResult.AutoSize = true;
            this.lblReverseResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReverseResult.ForeColor = System.Drawing.Color.White;
            this.lblReverseResult.Location = new System.Drawing.Point(132, 249);
            this.lblReverseResult.Name = "lblReverseResult";
            this.lblReverseResult.Size = new System.Drawing.Size(0, 69);
            this.lblReverseResult.TabIndex = 15;
            this.lblReverseResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReverseInput
            // 
            this.txtReverseInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReverseInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReverseInput.Location = new System.Drawing.Point(138, 80);
            this.txtReverseInput.Name = "txtReverseInput";
            this.txtReverseInput.Size = new System.Drawing.Size(233, 41);
            this.txtReverseInput.TabIndex = 14;
            this.txtReverseInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SumOfDigitsView
            // 
            this.SumOfDigitsView.BackColor = System.Drawing.SystemColors.Control;
            this.SumOfDigitsView.Controls.Add(this.btnSODResult);
            this.SumOfDigitsView.Controls.Add(this.lblSODResult);
            this.SumOfDigitsView.Controls.Add(this.txtSODInput);
            this.SumOfDigitsView.Location = new System.Drawing.Point(0, 77);
            this.SumOfDigitsView.Name = "SumOfDigitsView";
            this.SumOfDigitsView.Size = new System.Drawing.Size(509, 508);
            this.SumOfDigitsView.TabIndex = 8;
            // 
            // btnSODResult
            // 
            this.btnSODResult.Location = new System.Drawing.Point(180, 114);
            this.btnSODResult.Name = "btnSODResult";
            this.btnSODResult.Size = new System.Drawing.Size(154, 52);
            this.btnSODResult.TabIndex = 13;
            this.btnSODResult.Text = "Get Sum!";
            this.btnSODResult.UseVisualStyleBackColor = true;
            this.btnSODResult.Click += new System.EventHandler(this.btnSODResult_Click);
            // 
            // lblSODResult
            // 
            this.lblSODResult.AutoSize = true;
            this.lblSODResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSODResult.ForeColor = System.Drawing.Color.White;
            this.lblSODResult.Location = new System.Drawing.Point(132, 236);
            this.lblSODResult.Name = "lblSODResult";
            this.lblSODResult.Size = new System.Drawing.Size(0, 69);
            this.lblSODResult.TabIndex = 12;
            this.lblSODResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSODInput
            // 
            this.txtSODInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSODInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSODInput.Location = new System.Drawing.Point(138, 67);
            this.txtSODInput.Name = "txtSODInput";
            this.txtSODInput.Size = new System.Drawing.Size(233, 41);
            this.txtSODInput.TabIndex = 11;
            this.txtSODInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(0, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 53);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HomeActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(505, 580);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmHomeView);
            this.Controls.Add(this.ReverseView);
            this.Controls.Add(this.SumOfDigitsView);
            this.Controls.Add(this.SwapperView);
            this.Controls.Add(this.OddEvenView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.frmHomeView.ResumeLayout(false);
            this.OddEvenView.ResumeLayout(false);
            this.OddEvenView.PerformLayout();
            this.SwapperView.ResumeLayout(false);
            this.SwapperView.PerformLayout();
            this.ReverseView.ResumeLayout(false);
            this.ReverseView.PerformLayout();
            this.SumOfDigitsView.ResumeLayout(false);
            this.SumOfDigitsView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel frmHomeView;
        private System.Windows.Forms.Button btnSumOfDigits;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnSwapper;
        private System.Windows.Forms.Button btnOddEven;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel OddEvenView;
        private System.Windows.Forms.Panel SwapperView;
        private System.Windows.Forms.Panel ReverseView;
        private System.Windows.Forms.Panel SumOfDigitsView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblOEResult;
        private System.Windows.Forms.TextBox txtOEInput;
        private System.Windows.Forms.Button btnOEResult;
        private System.Windows.Forms.TextBox txtSwapValB;
        private System.Windows.Forms.TextBox txtSwapValA;
        private System.Windows.Forms.Button txtSwapperResult;
        private System.Windows.Forms.Button btnSODResult;
        private System.Windows.Forms.Label lblSODResult;
        private System.Windows.Forms.TextBox txtSODInput;
        private System.Windows.Forms.Button btnReverseResult;
        private System.Windows.Forms.Label lblReverseResult;
        private System.Windows.Forms.TextBox txtReverseInput;
    }
}

