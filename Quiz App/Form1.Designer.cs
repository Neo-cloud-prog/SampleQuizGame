namespace Quiz_App
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
            this.lbQuestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.rbAnswer4 = new System.Windows.Forms.RadioButton();
            this.rbAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbResult = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCorrectAnswersCount = new System.Windows.Forms.Label();
            this.lbWrongAnswersCount = new System.Windows.Forms.Label();
            this.lvHistoryGame = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbCounter = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbBestTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.Location = new System.Drawing.Point(61, 0);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(209, 42);
            this.lbQuestion.TabIndex = 1;
            this.lbQuestion.Text = "Question 1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.rbAnswer4);
            this.panel1.Controls.Add(this.rbAnswer3);
            this.panel1.Controls.Add(this.rbAnswer2);
            this.panel1.Controls.Add(this.rbAnswer1);
            this.panel1.Controls.Add(this.lbQuestion);
            this.panel1.Location = new System.Drawing.Point(12, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 260);
            this.panel1.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Green;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.White;
            this.btnCheck.Location = new System.Drawing.Point(36, 199);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(112, 37);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Gray;
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(179, 199);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 37);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rbAnswer4
            // 
            this.rbAnswer4.AutoSize = true;
            this.rbAnswer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbAnswer4.Location = new System.Drawing.Point(115, 161);
            this.rbAnswer4.Name = "rbAnswer4";
            this.rbAnswer4.Size = new System.Drawing.Size(87, 20);
            this.rbAnswer4.TabIndex = 5;
            this.rbAnswer4.TabStop = true;
            this.rbAnswer4.Text = "Answer 4";
            this.rbAnswer4.UseVisualStyleBackColor = true;
            // 
            // rbAnswer3
            // 
            this.rbAnswer3.AutoSize = true;
            this.rbAnswer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbAnswer3.Location = new System.Drawing.Point(115, 125);
            this.rbAnswer3.Name = "rbAnswer3";
            this.rbAnswer3.Size = new System.Drawing.Size(87, 20);
            this.rbAnswer3.TabIndex = 4;
            this.rbAnswer3.TabStop = true;
            this.rbAnswer3.Text = "Answer 3";
            this.rbAnswer3.UseVisualStyleBackColor = true;
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.AutoSize = true;
            this.rbAnswer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbAnswer2.Location = new System.Drawing.Point(115, 89);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(87, 20);
            this.rbAnswer2.TabIndex = 3;
            this.rbAnswer2.TabStop = true;
            this.rbAnswer2.Text = "Answer 2";
            this.rbAnswer2.UseVisualStyleBackColor = true;
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.AutoSize = true;
            this.rbAnswer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbAnswer1.Location = new System.Drawing.Point(115, 53);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(87, 20);
            this.rbAnswer1.TabIndex = 2;
            this.rbAnswer1.TabStop = true;
            this.rbAnswer1.Text = "Answer 1";
            this.rbAnswer1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lbResult);
            this.panel2.Controls.Add(this.btnRestart);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 260);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.BackColor = System.Drawing.Color.Transparent;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Green;
            this.lbResult.Location = new System.Drawing.Point(114, 83);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(88, 39);
            this.lbResult.TabIndex = 13;
            this.lbResult.Text = "4 / 2";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Gray;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(84, 145);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(147, 36);
            this.btnRestart.TabIndex = 6;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 42);
            this.label5.TabIndex = 1;
            this.label5.Text = "Game Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quiz App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(529, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 73);
            this.label2.TabIndex = 8;
            this.label2.Text = "✅";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(682, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 73);
            this.label3.TabIndex = 9;
            this.label3.Text = "❎";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "0";
            // 
            // lbCorrectAnswersCount
            // 
            this.lbCorrectAnswersCount.AutoSize = true;
            this.lbCorrectAnswersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorrectAnswersCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCorrectAnswersCount.Location = new System.Drawing.Point(547, 135);
            this.lbCorrectAnswersCount.Name = "lbCorrectAnswersCount";
            this.lbCorrectAnswersCount.Size = new System.Drawing.Size(69, 73);
            this.lbCorrectAnswersCount.TabIndex = 11;
            this.lbCorrectAnswersCount.Text = "0";
            // 
            // lbWrongAnswersCount
            // 
            this.lbWrongAnswersCount.AutoSize = true;
            this.lbWrongAnswersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWrongAnswersCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbWrongAnswersCount.Location = new System.Drawing.Point(700, 135);
            this.lbWrongAnswersCount.Name = "lbWrongAnswersCount";
            this.lbWrongAnswersCount.Size = new System.Drawing.Size(69, 73);
            this.lbWrongAnswersCount.TabIndex = 12;
            this.lbWrongAnswersCount.Text = "0";
            // 
            // lvHistoryGame
            // 
            this.lvHistoryGame.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvHistoryGame.HideSelection = false;
            this.lvHistoryGame.Location = new System.Drawing.Point(362, 261);
            this.lvHistoryGame.Name = "lvHistoryGame";
            this.lvHistoryGame.Size = new System.Drawing.Size(426, 177);
            this.lvHistoryGame.TabIndex = 13;
            this.lvHistoryGame.UseCompatibleStateImageBehavior = false;
            this.lvHistoryGame.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Round";
            this.columnHeader1.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rigth Answers";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Wrong Answers";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date Time";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 144;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(501, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 39);
            this.label6.TabIndex = 14;
            this.label6.Text = "History";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Yellow;
            this.progressBar1.ForeColor = System.Drawing.Color.Yellow;
            this.progressBar1.Location = new System.Drawing.Point(13, 142);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(335, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(111, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Questions Progress";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbCounter
            // 
            this.lbCounter.AutoSize = true;
            this.lbCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCounter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCounter.Location = new System.Drawing.Point(166, 48);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(62, 42);
            this.lbCounter.TabIndex = 17;
            this.lbCounter.Text = "10";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Best Time In This Round";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 85;
            // 
            // lbBestTime
            // 
            this.lbBestTime.AutoSize = true;
            this.lbBestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBestTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbBestTime.Location = new System.Drawing.Point(397, 135);
            this.lbBestTime.Name = "lbBestTime";
            this.lbBestTime.Size = new System.Drawing.Size(69, 73);
            this.lbBestTime.TabIndex = 19;
            this.lbBestTime.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(383, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 73);
            this.label8.TabIndex = 20;
            this.label8.Text = "⌚";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(84, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Show Chart";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbBestTime);
            this.Controls.Add(this.lbCounter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvHistoryGame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbWrongAnswersCount);
            this.Controls.Add(this.lbCorrectAnswersCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton rbAnswer4;
        private System.Windows.Forms.RadioButton rbAnswer3;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCorrectAnswersCount;
        private System.Windows.Forms.Label lbWrongAnswersCount;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.ListView lvHistoryGame;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbCounter;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbBestTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

