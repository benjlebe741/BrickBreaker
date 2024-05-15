namespace BrickBreaker
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.levelButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.skinsButton = new System.Windows.Forms.Button();
            this.timerToggleButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.DimGray;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(191, 441);
            this.playButton.Margin = new System.Windows.Forms.Padding(4);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(685, 44);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "P L A Y";
            this.playButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.playButton.UseCompatibleTextRendering = true;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DimGray;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(191, 565);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(685, 44);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "E X I T";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitButton.UseCompatibleTextRendering = true;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // levelButton
            // 
            this.levelButton.BackColor = System.Drawing.Color.DimGray;
            this.levelButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.levelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelButton.ForeColor = System.Drawing.Color.White;
            this.levelButton.Location = new System.Drawing.Point(191, 503);
            this.levelButton.Margin = new System.Windows.Forms.Padding(4);
            this.levelButton.Name = "levelButton";
            this.levelButton.Size = new System.Drawing.Size(685, 44);
            this.levelButton.TabIndex = 2;
            this.levelButton.Text = "L E V E L";
            this.levelButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.levelButton.UseCompatibleTextRendering = true;
            this.levelButton.UseVisualStyleBackColor = false;
            this.levelButton.Click += new System.EventHandler(this.levelButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.LightGray;
            this.titleLabel.Location = new System.Drawing.Point(3, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1064, 384);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "BRICK BREAKER";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.titleLabel.UseCompatibleTextRendering = true;
            // 
            // skinsButton
            // 
            this.skinsButton.BackColor = System.Drawing.Color.DimGray;
            this.skinsButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.skinsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.skinsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinsButton.ForeColor = System.Drawing.Color.White;
            this.skinsButton.Location = new System.Drawing.Point(19, 70);
            this.skinsButton.Margin = new System.Windows.Forms.Padding(4);
            this.skinsButton.Name = "skinsButton";
            this.skinsButton.Size = new System.Drawing.Size(152, 44);
            this.skinsButton.TabIndex = 4;
            this.skinsButton.Text = "S K I N S";
            this.skinsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.skinsButton.UseCompatibleTextRendering = true;
            this.skinsButton.UseVisualStyleBackColor = false;
            this.skinsButton.Click += new System.EventHandler(this.skinsButton_Click);
            // 
            // timerToggleButton
            // 
            this.timerToggleButton.BackColor = System.Drawing.Color.IndianRed;
            this.timerToggleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.timerToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerToggleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerToggleButton.ForeColor = System.Drawing.Color.White;
            this.timerToggleButton.Location = new System.Drawing.Point(19, 18);
            this.timerToggleButton.Margin = new System.Windows.Forms.Padding(4);
            this.timerToggleButton.Name = "timerToggleButton";
            this.timerToggleButton.Size = new System.Drawing.Size(176, 44);
            this.timerToggleButton.TabIndex = 5;
            this.timerToggleButton.Text = "Timer: OFF";
            this.timerToggleButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.timerToggleButton.UseCompatibleTextRendering = true;
            this.timerToggleButton.UseVisualStyleBackColor = false;
            this.timerToggleButton.Click += new System.EventHandler(this.timerToggleButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timerLabel.Location = new System.Drawing.Point(199, 18);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(389, 44);
            this.timerLabel.TabIndex = 6;
            this.timerLabel.Text = "Fail when time = 0";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.timerToggleButton);
            this.Controls.Add(this.skinsButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.levelButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1067, 676);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuScreen_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button levelButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button skinsButton;
        private System.Windows.Forms.Button timerToggleButton;
        private System.Windows.Forms.Label timerLabel;
    }
}
