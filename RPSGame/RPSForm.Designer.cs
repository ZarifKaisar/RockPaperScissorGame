namespace RPSGame
{
    partial class RPSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPSForm));
            this.ComputerPicBox = new System.Windows.Forms.PictureBox();
            this.PlayerLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RockButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.ScissorButton = new System.Windows.Forms.Button();
            this.PlayerBox = new System.Windows.Forms.TextBox();
            this.ComputerBox = new System.Windows.Forms.TextBox();
            this.PlayerLabel2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.RoundColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WinnerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerPicBox = new System.Windows.Forms.PictureBox();
            this.RestartButton = new System.Windows.Forms.Button();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GridCheckBox = new System.Windows.Forms.CheckBox();
            this.HelpButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TimerDisplay = new System.Windows.Forms.TextBox();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ComputerPicBox
            // 
            this.ComputerPicBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComputerPicBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ComputerPicBox.ErrorImage")));
            this.ComputerPicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("ComputerPicBox.InitialImage")));
            this.ComputerPicBox.Location = new System.Drawing.Point(293, 62);
            this.ComputerPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComputerPicBox.Name = "ComputerPicBox";
            this.ComputerPicBox.Size = new System.Drawing.Size(162, 256);
            this.ComputerPicBox.TabIndex = 1;
            this.ComputerPicBox.TabStop = false;
            this.toolTip.SetToolTip(this.ComputerPicBox, "The Picture of Computer\'s Chosen Object");
            // 
            // PlayerLabel1
            // 
            this.PlayerLabel1.AutoSize = true;
            this.PlayerLabel1.Location = new System.Drawing.Point(110, 31);
            this.PlayerLabel1.Name = "PlayerLabel1";
            this.PlayerLabel1.Size = new System.Drawing.Size(48, 17);
            this.PlayerLabel1.TabIndex = 2;
            this.PlayerLabel1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Computer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "VS";
            // 
            // RockButton
            // 
            this.RockButton.Location = new System.Drawing.Point(78, 343);
            this.RockButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(121, 30);
            this.RockButton.TabIndex = 5;
            this.RockButton.Text = "Rock";
            this.toolTip.SetToolTip(this.RockButton, "Press this Button To Select Rock");
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.Location = new System.Drawing.Point(78, 384);
            this.PaperButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(121, 30);
            this.PaperButton.TabIndex = 6;
            this.PaperButton.Text = "Paper";
            this.toolTip.SetToolTip(this.PaperButton, "Press this Button To Select Paper");
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // ScissorButton
            // 
            this.ScissorButton.Location = new System.Drawing.Point(78, 426);
            this.ScissorButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScissorButton.Name = "ScissorButton";
            this.ScissorButton.Size = new System.Drawing.Size(121, 31);
            this.ScissorButton.TabIndex = 7;
            this.ScissorButton.Text = "Scissor";
            this.toolTip.SetToolTip(this.ScissorButton, "Press this Button To Select Scissor");
            this.ScissorButton.UseVisualStyleBackColor = true;
            this.ScissorButton.Click += new System.EventHandler(this.ScissorButton_Click);
            // 
            // PlayerBox
            // 
            this.PlayerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayerBox.Location = new System.Drawing.Point(604, 343);
            this.PlayerBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.ReadOnly = true;
            this.PlayerBox.Size = new System.Drawing.Size(101, 22);
            this.PlayerBox.TabIndex = 8;
            this.toolTip.SetToolTip(this.PlayerBox, "Your Score");
            // 
            // ComputerBox
            // 
            this.ComputerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComputerBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComputerBox.Location = new System.Drawing.Point(604, 422);
            this.ComputerBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComputerBox.Name = "ComputerBox";
            this.ComputerBox.ReadOnly = true;
            this.ComputerBox.Size = new System.Drawing.Size(101, 22);
            this.ComputerBox.TabIndex = 9;
            this.toolTip.SetToolTip(this.ComputerBox, "Computer\'s Score");
            // 
            // PlayerLabel2
            // 
            this.PlayerLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerLabel2.AutoSize = true;
            this.PlayerLabel2.Location = new System.Drawing.Point(601, 320);
            this.PlayerLabel2.Name = "PlayerLabel2";
            this.PlayerLabel2.Size = new System.Drawing.Size(48, 17);
            this.PlayerLabel2.TabIndex = 10;
            this.PlayerLabel2.Text = "Player";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Computer";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoundColumn,
            this.PlayerColumn,
            this.ComputerColumn,
            this.WinnerColumn});
            this.dataGridView.Location = new System.Drawing.Point(486, 78);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(452, 223);
            this.dataGridView.TabIndex = 13;
            this.toolTip.SetToolTip(this.dataGridView, "GridView Score Board");
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // RoundColumn
            // 
            this.RoundColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoundColumn.HeaderText = "Round";
            this.RoundColumn.Name = "RoundColumn";
            this.RoundColumn.ReadOnly = true;
            // 
            // PlayerColumn
            // 
            this.PlayerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlayerColumn.HeaderText = "Player";
            this.PlayerColumn.Name = "PlayerColumn";
            this.PlayerColumn.ReadOnly = true;
            // 
            // ComputerColumn
            // 
            this.ComputerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ComputerColumn.HeaderText = "Computer";
            this.ComputerColumn.Name = "ComputerColumn";
            this.ComputerColumn.ReadOnly = true;
            // 
            // WinnerColumn
            // 
            this.WinnerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WinnerColumn.HeaderText = "Winner";
            this.WinnerColumn.Name = "WinnerColumn";
            this.WinnerColumn.ReadOnly = true;
            // 
            // PlayerPicBox
            // 
            this.PlayerPicBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PlayerPicBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PlayerPicBox.ErrorImage")));
            this.PlayerPicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("PlayerPicBox.InitialImage")));
            this.PlayerPicBox.Location = new System.Drawing.Point(54, 62);
            this.PlayerPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerPicBox.Name = "PlayerPicBox";
            this.PlayerPicBox.Size = new System.Drawing.Size(162, 256);
            this.PlayerPicBox.TabIndex = 14;
            this.PlayerPicBox.TabStop = false;
            this.toolTip.SetToolTip(this.PlayerPicBox, "The Picture of Your Chosen Object");
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(387, 419);
            this.RestartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(121, 30);
            this.RestartButton.TabIndex = 15;
            this.RestartButton.Text = "Restart";
            this.toolTip.SetToolTip(this.RestartButton, "Press this Button To Restart The Game");
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(580, 41);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(69, 25);
            this.ScoreLabel.TabIndex = 16;
            this.ScoreLabel.Text = "Score";
            // 
            // GridCheckBox
            // 
            this.GridCheckBox.AutoSize = true;
            this.GridCheckBox.Location = new System.Drawing.Point(757, 45);
            this.GridCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridCheckBox.Name = "GridCheckBox";
            this.GridCheckBox.Size = new System.Drawing.Size(134, 21);
            this.GridCheckBox.TabIndex = 17;
            this.GridCheckBox.Text = "Enable Gridlines";
            this.toolTip.SetToolTip(this.GridCheckBox, "Enable or Disable GridLines in GridView");
            this.GridCheckBox.UseVisualStyleBackColor = true;
            this.GridCheckBox.CheckStateChanged += new System.EventHandler(this.GridCheckBox_CheckStateChanged);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(817, 435);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(121, 26);
            this.HelpButton.TabIndex = 18;
            this.HelpButton.Text = "Need Help?";
            this.toolTip.SetToolTip(this.HelpButton, "Need Help?");
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // TimerDisplay
            // 
            this.TimerDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimerDisplay.Location = new System.Drawing.Point(790, 364);
            this.TimerDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimerDisplay.Name = "TimerDisplay";
            this.TimerDisplay.ReadOnly = true;
            this.TimerDisplay.Size = new System.Drawing.Size(101, 22);
            this.TimerDisplay.TabIndex = 19;
            this.toolTip.SetToolTip(this.TimerDisplay, "Your Score");
            this.TimerDisplay.TextChanged += new System.EventHandler(this.TimerDisplay_TextChanged);
            // 
            // TimerLabel
            // 
            this.TimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(814, 333);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(44, 17);
            this.TimerLabel.TabIndex = 20;
            this.TimerLabel.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RPSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 470);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.TimerDisplay);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.GridCheckBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.PlayerPicBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlayerLabel2);
            this.Controls.Add(this.ComputerBox);
            this.Controls.Add(this.PlayerBox);
            this.Controls.Add(this.ScissorButton);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.RockButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayerLabel1);
            this.Controls.Add(this.ComputerPicBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RPSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissor Game";
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ComputerPicBox;
        private System.Windows.Forms.Label PlayerLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button ScissorButton;
        private System.Windows.Forms.TextBox PlayerBox;
        private System.Windows.Forms.TextBox ComputerBox;
        private System.Windows.Forms.Label PlayerLabel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox PlayerPicBox;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoundColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinnerColumn;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.CheckBox GridCheckBox;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox TimerDisplay;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

