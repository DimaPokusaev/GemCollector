using System.Windows.Forms;

namespace GemCollector
{
    partial class SelectScreen
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
            this.EasyButton = new System.Windows.Forms.Button();
            this.NormalButton = new System.Windows.Forms.Button();
            this.HardButton = new System.Windows.Forms.Button();
            this.CustomButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SortByClicks = new System.Windows.Forms.Button();
            this.SortByTime = new System.Windows.Forms.Button();
            this.TitleLable = new System.Windows.Forms.Label();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EasyButton
            // 
            this.EasyButton.BackColor = System.Drawing.Color.DimGray;
            this.EasyButton.FlatAppearance.BorderSize = 7;
            this.EasyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.EasyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EasyButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyButton.Location = new System.Drawing.Point(27, 344);
            this.EasyButton.Margin = new System.Windows.Forms.Padding(4);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(283, 89);
            this.EasyButton.TabIndex = 0;
            this.EasyButton.Text = "Can I play, Daddy?\r\n(Easy)\r\n";
            this.EasyButton.UseVisualStyleBackColor = false;
            this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // NormalButton
            // 
            this.NormalButton.BackColor = System.Drawing.Color.DimGray;
            this.NormalButton.FlatAppearance.BorderSize = 7;
            this.NormalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.NormalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalButton.Location = new System.Drawing.Point(27, 431);
            this.NormalButton.Margin = new System.Windows.Forms.Padding(4);
            this.NormalButton.Name = "NormalButton";
            this.NormalButton.Size = new System.Drawing.Size(283, 89);
            this.NormalButton.TabIndex = 1;
            this.NormalButton.Text = "Bring \'em on!\r\n(Normal)\r\n";
            this.NormalButton.UseVisualStyleBackColor = true;
            this.NormalButton.Click += new System.EventHandler(this.NormalButton_Click);
            // 
            // HardButton
            // 
            this.HardButton.BackColor = System.Drawing.Color.DimGray;
            this.HardButton.FlatAppearance.BorderSize = 7;
            this.HardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.HardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardButton.Location = new System.Drawing.Point(27, 518);
            this.HardButton.Margin = new System.Windows.Forms.Padding(4);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(283, 89);
            this.HardButton.TabIndex = 2;
            this.HardButton.Text = "I am Death incarnate!\r\n(Hard)\r\n";
            this.HardButton.UseVisualStyleBackColor = true;
            this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // CustomButton
            // 
            this.CustomButton.BackColor = System.Drawing.Color.DimGray;
            this.CustomButton.FlatAppearance.BorderSize = 7;
            this.CustomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomButton.Location = new System.Drawing.Point(27, 605);
            this.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.CustomButton.Name = "CustomButton";
            this.CustomButton.Size = new System.Drawing.Size(283, 89);
            this.CustomButton.TabIndex = 3;
            this.CustomButton.Text = "CustomizeYourLevel\r\n(Customise)";
            this.CustomButton.UseVisualStyleBackColor = true;
            this.CustomButton.Click += new System.EventHandler(this.CustomButtom_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DimGray;
            this.ExitButton.FlatAppearance.BorderSize = 7;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(27, 21);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(213, 62);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.DimGray;
            this.LoadButton.FlatAppearance.BorderSize = 7;
            this.LoadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(27, 691);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(283, 89);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load Saved Grid";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SortByClicks
            // 
            this.SortByClicks.BackColor = System.Drawing.Color.DimGray;
            this.SortByClicks.FlatAppearance.BorderSize = 7;
            this.SortByClicks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.SortByClicks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortByClicks.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByClicks.Location = new System.Drawing.Point(1720, 431);
            this.SortByClicks.Margin = new System.Windows.Forms.Padding(4);
            this.SortByClicks.Name = "SortByClicks";
            this.SortByClicks.Size = new System.Drawing.Size(283, 89);
            this.SortByClicks.TabIndex = 7;
            this.SortByClicks.Text = "Sort the score by clicks";
            this.SortByClicks.UseVisualStyleBackColor = true;
            this.SortByClicks.Click += new System.EventHandler(this.SortByClicks_Click);
            // 
            // SortByTime
            // 
            this.SortByTime.BackColor = System.Drawing.Color.DimGray;
            this.SortByTime.FlatAppearance.BorderSize = 7;
            this.SortByTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.SortByTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortByTime.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByTime.Location = new System.Drawing.Point(1720, 344);
            this.SortByTime.Margin = new System.Windows.Forms.Padding(4);
            this.SortByTime.Name = "SortByTime";
            this.SortByTime.Size = new System.Drawing.Size(283, 89);
            this.SortByTime.TabIndex = 6;
            this.SortByTime.Text = "Sort the score by time";
            this.SortByTime.UseVisualStyleBackColor = true;
            this.SortByTime.Click += new System.EventHandler(this.SortByTime_Click);
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.BackColor = System.Drawing.Color.Transparent;
            this.TitleLable.Font = new System.Drawing.Font("Lucida Fax", 70F);
            this.TitleLable.Location = new System.Drawing.Point(537, 29);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(897, 133);
            this.TitleLable.TabIndex = 8;
            this.TitleLable.Text = "Gem Collector";
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.DimGray;
            this.HelpButton.FlatAppearance.BorderSize = 7;
            this.HelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(27, 950);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(4);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(283, 89);
            this.HelpButton.TabIndex = 9;
            this.HelpButton.Text = "Help Screen";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // SelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.TitleLable);
            this.Controls.Add(this.SortByClicks);
            this.Controls.Add(this.SortByTime);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CustomButton);
            this.Controls.Add(this.HardButton);
            this.Controls.Add(this.NormalButton);
            this.Controls.Add(this.EasyButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SelectScreen";
            this.Size = new System.Drawing.Size(2050, 1980);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SelectScreen_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EasyButton;
        private System.Windows.Forms.Button NormalButton;
        private System.Windows.Forms.Button HardButton;
        private System.Windows.Forms.Button CustomButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LoadButton;
        private Button SortByClicks;
        private Button SortByTime;
        private Label TitleLable;
        private Button HelpButton;
    }
}
