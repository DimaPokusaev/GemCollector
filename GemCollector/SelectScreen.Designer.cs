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
            this.SuspendLayout();
            // 
            // EasyButton
            // 
            this.EasyButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EasyButton.Location = new System.Drawing.Point(27, 344);
            this.EasyButton.Margin = new System.Windows.Forms.Padding(4);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(283, 89);
            this.EasyButton.TabIndex = 0;
            this.EasyButton.Text = "Can I play, Daddy?\r\n(Easy)\r\n";
            this.EasyButton.UseVisualStyleBackColor = true;
            this.EasyButton.Click += new System.EventHandler(this.EasyButton_Click);
            // 
            // NormalButton
            // 
            this.NormalButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.HardButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.CustomButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
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
            this.LoadButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.SortByClicks.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByClicks.Location = new System.Drawing.Point(1287, 431);
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
            this.SortByTime.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByTime.Location = new System.Drawing.Point(1287, 344);
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
            this.TitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.TitleLable.Location = new System.Drawing.Point(387, 37);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(803, 132);
            this.TitleLable.TabIndex = 8;
            this.TitleLable.Text = "Gem Collector";
            // 
            // SelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Size = new System.Drawing.Size(1574, 974);
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
    }
}
