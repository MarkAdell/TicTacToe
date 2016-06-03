namespace TicTacToe
{
    partial class MainForm
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
            this.Block00 = new System.Windows.Forms.TextBox();
            this.Block22 = new System.Windows.Forms.TextBox();
            this.Block21 = new System.Windows.Forms.TextBox();
            this.Block20 = new System.Windows.Forms.TextBox();
            this.Block12 = new System.Windows.Forms.TextBox();
            this.Block11 = new System.Windows.Forms.TextBox();
            this.Block10 = new System.Windows.Forms.TextBox();
            this.Block02 = new System.Windows.Forms.TextBox();
            this.Block01 = new System.Windows.Forms.TextBox();
            this.O_Score = new System.Windows.Forms.Label();
            this.X_Score = new System.Windows.Forms.Label();
            this.Score_X = new System.Windows.Forms.Label();
            this.Score_O = new System.Windows.Forms.Label();
            this.LabelToFocusOn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Block00
            // 
            this.Block00.Location = new System.Drawing.Point(60, 52);
            this.Block00.MaxLength = 1;
            this.Block00.Multiline = true;
            this.Block00.Name = "Block00";
            this.Block00.Size = new System.Drawing.Size(60, 57);
            this.Block00.TabIndex = 0;
            this.Block00.TextChanged += new System.EventHandler(this.Block_TextChanged);
            // 
            // Block22
            // 
            this.Block22.Location = new System.Drawing.Point(235, 206);
            this.Block22.Multiline = true;
            this.Block22.Name = "Block22";
            this.Block22.Size = new System.Drawing.Size(60, 57);
            this.Block22.TabIndex = 1;
            this.Block22.TextChanged += new System.EventHandler(this.Block_TextChanged);
            // 
            // Block21
            // 
            this.Block21.Location = new System.Drawing.Point(150, 206);
            this.Block21.Multiline = true;
            this.Block21.Name = "Block21";
            this.Block21.Size = new System.Drawing.Size(60, 57);
            this.Block21.TabIndex = 2;
            this.Block21.TextChanged += new System.EventHandler(this.Block_TextChanged);
            // 
            // Block20
            // 
            this.Block20.Location = new System.Drawing.Point(60, 206);
            this.Block20.Multiline = true;
            this.Block20.Name = "Block20";
            this.Block20.Size = new System.Drawing.Size(60, 57);
            this.Block20.TabIndex = 3;
            this.Block20.TextChanged += new System.EventHandler(this.Block_TextChanged);
            // 
            // Block12
            // 
            this.Block12.Location = new System.Drawing.Point(235, 133);
            this.Block12.Multiline = true;
            this.Block12.Name = "Block12";
            this.Block12.Size = new System.Drawing.Size(60, 57);
            this.Block12.TabIndex = 4;
            this.Block12.TextChanged += new System.EventHandler(this.Block_TextChanged);
            // 
            // Block11
            // 
            this.Block11.Location = new System.Drawing.Point(150, 133);
            this.Block11.Multiline = true;
            this.Block11.Name = "Block11";
            this.Block11.Size = new System.Drawing.Size(60, 57);
            this.Block11.TabIndex = 5;
            this.Block11.TextChanged += new System.EventHandler(this.Block_TextChanged);
            // 
            // Block10
            // 
            this.Block10.Location = new System.Drawing.Point(60, 133);
            this.Block10.Multiline = true;
            this.Block10.Name = "Block10";
            this.Block10.Size = new System.Drawing.Size(60, 57);
            this.Block10.TabIndex = 6;
            this.Block10.TextChanged += new System.EventHandler(this.Block_TextChanged);
            // 
            // Block02
            // 
            this.Block02.Location = new System.Drawing.Point(235, 52);
            this.Block02.Multiline = true;
            this.Block02.Name = "Block02";
            this.Block02.Size = new System.Drawing.Size(60, 57);
            this.Block02.TabIndex = 7;
            this.Block02.TextChanged += new System.EventHandler(this.Block_TextChanged);
            // 
            // Block01
            // 
            this.Block01.Location = new System.Drawing.Point(150, 52);
            this.Block01.Multiline = true;
            this.Block01.Name = "Block01";
            this.Block01.Size = new System.Drawing.Size(60, 57);
            this.Block01.TabIndex = 8;
            this.Block01.TextChanged += new System.EventHandler(this.Block_TextChanged);
            // 
            // O_Score
            // 
            this.O_Score.AutoSize = true;
            this.O_Score.Location = new System.Drawing.Point(57, 343);
            this.O_Score.Name = "O_Score";
            this.O_Score.Size = new System.Drawing.Size(85, 13);
            this.O_Score.TabIndex = 10;
            this.O_Score.Text = "O Player Score :";
            // 
            // X_Score
            // 
            this.X_Score.AutoSize = true;
            this.X_Score.Location = new System.Drawing.Point(57, 296);
            this.X_Score.Name = "X_Score";
            this.X_Score.Size = new System.Drawing.Size(83, 13);
            this.X_Score.TabIndex = 11;
            this.X_Score.Text = "X Player Score :";
            // 
            // Score_X
            // 
            this.Score_X.AutoSize = true;
            this.Score_X.Location = new System.Drawing.Point(205, 296);
            this.Score_X.Name = "Score_X";
            this.Score_X.Size = new System.Drawing.Size(13, 13);
            this.Score_X.TabIndex = 12;
            this.Score_X.Text = "0";
            // 
            // Score_O
            // 
            this.Score_O.AutoSize = true;
            this.Score_O.Location = new System.Drawing.Point(205, 343);
            this.Score_O.Name = "Score_O";
            this.Score_O.Size = new System.Drawing.Size(13, 13);
            this.Score_O.TabIndex = 13;
            this.Score_O.Text = "0";
            // 
            // LabelToFocusOn
            // 
            this.LabelToFocusOn.AutoSize = true;
            this.LabelToFocusOn.Location = new System.Drawing.Point(259, 379);
            this.LabelToFocusOn.Name = "LabelToFocusOn";
            this.LabelToFocusOn.Size = new System.Drawing.Size(0, 13);
            this.LabelToFocusOn.TabIndex = 14;
            this.LabelToFocusOn.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(350, 389);
            this.Controls.Add(this.LabelToFocusOn);
            this.Controls.Add(this.Score_O);
            this.Controls.Add(this.Score_X);
            this.Controls.Add(this.X_Score);
            this.Controls.Add(this.O_Score);
            this.Controls.Add(this.Block01);
            this.Controls.Add(this.Block02);
            this.Controls.Add(this.Block10);
            this.Controls.Add(this.Block11);
            this.Controls.Add(this.Block12);
            this.Controls.Add(this.Block20);
            this.Controls.Add(this.Block21);
            this.Controls.Add(this.Block22);
            this.Controls.Add(this.Block00);
            this.Name = "MainForm";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Block00;
        private System.Windows.Forms.TextBox Block22;
        private System.Windows.Forms.TextBox Block21;
        private System.Windows.Forms.TextBox Block20;
        private System.Windows.Forms.TextBox Block12;
        private System.Windows.Forms.TextBox Block11;
        private System.Windows.Forms.TextBox Block10;
        private System.Windows.Forms.TextBox Block02;
        private System.Windows.Forms.TextBox Block01;
        private System.Windows.Forms.Label O_Score;
        private System.Windows.Forms.Label X_Score;
        private System.Windows.Forms.Label Score_X;
        private System.Windows.Forms.Label Score_O;
        private System.Windows.Forms.Label LabelToFocusOn;
    }
}

