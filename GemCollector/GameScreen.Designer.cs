namespace GemCollector
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.ClickLable = new System.Windows.Forms.Label();
            this.TimeLable = new System.Windows.Forms.Label();
            this.FlagLable = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.BackButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClickLable
            // 
            this.ClickLable.AutoSize = true;
            this.ClickLable.BackColor = System.Drawing.Color.Transparent;
            this.ClickLable.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickLable.ForeColor = System.Drawing.Color.Black;
            this.ClickLable.Location = new System.Drawing.Point(1553, 41);
            this.ClickLable.Name = "ClickLable";
            this.ClickLable.Size = new System.Drawing.Size(323, 38);
            this.ClickLable.TabIndex = 0;
            this.ClickLable.Text = "Number of Clicks";
            // 
            // TimeLable
            // 
            this.TimeLable.AutoSize = true;
            this.TimeLable.BackColor = System.Drawing.Color.Transparent;
            this.TimeLable.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLable.ForeColor = System.Drawing.Color.Black;
            this.TimeLable.Location = new System.Drawing.Point(1553, 102);
            this.TimeLable.Name = "TimeLable";
            this.TimeLable.Size = new System.Drawing.Size(225, 38);
            this.TimeLable.TabIndex = 1;
            this.TimeLable.Text = "Time Taken";
            // 
            // FlagLable
            // 
            this.FlagLable.AutoSize = true;
            this.FlagLable.BackColor = System.Drawing.Color.Transparent;
            this.FlagLable.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlagLable.ForeColor = System.Drawing.Color.Black;
            this.FlagLable.Location = new System.Drawing.Point(1553, 175);
            this.FlagLable.Name = "FlagLable";
            this.FlagLable.Size = new System.Drawing.Size(187, 38);
            this.FlagLable.TabIndex = 2;
            this.FlagLable.Text = "Flags Left";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.DimGray;
            this.BackButton.FlatAppearance.BorderSize = 7;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.BackButton.Location = new System.Drawing.Point(1556, 253);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(233, 64);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.OutputLabel.Location = new System.Drawing.Point(238, 129);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(299, 58);
            this.OutputLabel.TabIndex = 4;
            this.OutputLabel.Text = "OutputLabel";
            this.OutputLabel.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DimGray;
            this.SaveButton.FlatAppearance.BorderSize = 7;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SaveButton.Location = new System.Drawing.Point(1556, 353);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(233, 64);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save Grid";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.FlagLable);
            this.Controls.Add(this.TimeLable);
            this.Controls.Add(this.ClickLable);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(2050, 1980);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GameScreen_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClickLable;
        private System.Windows.Forms.Label TimeLable;
        private System.Windows.Forms.Label FlagLable;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button SaveButton;
    }
}
