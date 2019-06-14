namespace GemCollector
{
    partial class CustomLevel
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
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.GemInput = new System.Windows.Forms.TextBox();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.HeightLable = new System.Windows.Forms.Label();
            this.WidthLable = new System.Windows.Forms.Label();
            this.GemsLable = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeightInput
            // 
            this.HeightInput.Location = new System.Drawing.Point(244, 94);
            this.HeightInput.Margin = new System.Windows.Forms.Padding(4);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(132, 22);
            this.HeightInput.TabIndex = 0;
            // 
            // GemInput
            // 
            this.GemInput.Location = new System.Drawing.Point(245, 230);
            this.GemInput.Margin = new System.Windows.Forms.Padding(4);
            this.GemInput.Name = "GemInput";
            this.GemInput.Size = new System.Drawing.Size(132, 22);
            this.GemInput.TabIndex = 1;
            // 
            // WidthInput
            // 
            this.WidthInput.Location = new System.Drawing.Point(245, 164);
            this.WidthInput.Margin = new System.Windows.Forms.Padding(4);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(132, 22);
            this.WidthInput.TabIndex = 2;
            // 
            // HeightLable
            // 
            this.HeightLable.AutoSize = true;
            this.HeightLable.Font = new System.Drawing.Font("Lucida Fax", 20F);
            this.HeightLable.Location = new System.Drawing.Point(95, 79);
            this.HeightLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightLable.Name = "HeightLable";
            this.HeightLable.Size = new System.Drawing.Size(130, 39);
            this.HeightLable.TabIndex = 3;
            this.HeightLable.Text = "Height";
            // 
            // WidthLable
            // 
            this.WidthLable.AutoSize = true;
            this.WidthLable.Font = new System.Drawing.Font("Lucida Fax", 20F);
            this.WidthLable.Location = new System.Drawing.Point(95, 147);
            this.WidthLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WidthLable.Name = "WidthLable";
            this.WidthLable.Size = new System.Drawing.Size(118, 39);
            this.WidthLable.TabIndex = 4;
            this.WidthLable.Text = "Width";
            // 
            // GemsLable
            // 
            this.GemsLable.AutoSize = true;
            this.GemsLable.Font = new System.Drawing.Font("Lucida Fax", 20F);
            this.GemsLable.Location = new System.Drawing.Point(95, 213);
            this.GemsLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GemsLable.Name = "GemsLable";
            this.GemsLable.Size = new System.Drawing.Size(112, 39);
            this.GemsLable.TabIndex = 5;
            this.GemsLable.Text = "Gems";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.DimGray;
            this.StartButton.FlatAppearance.BorderSize = 7;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(403, 109);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(278, 119);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Wanna start the game now?";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Lucida Fax", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.Location = new System.Drawing.Point(207, 300);
            this.OutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(0, 55);
            this.OutputLabel.TabIndex = 7;
            // 
            // CustomLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GemsLable);
            this.Controls.Add(this.WidthLable);
            this.Controls.Add(this.HeightLable);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.GemInput);
            this.Controls.Add(this.HeightInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomLevel";
            this.Size = new System.Drawing.Size(930, 407);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.TextBox GemInput;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.Label HeightLable;
        private System.Windows.Forms.Label WidthLable;
        private System.Windows.Forms.Label GemsLable;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label OutputLabel;
    }
}
