namespace Pac_Man
{
    partial class PacMan
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
            this.PlayGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayGame
            // 
            this.PlayGame.BackColor = System.Drawing.Color.White;
            this.PlayGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGame.Location = new System.Drawing.Point(101, 210);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(91, 39);
            this.PlayGame.TabIndex = 0;
            this.PlayGame.Text = "Run";
            this.PlayGame.UseVisualStyleBackColor = false;
            this.PlayGame.Click += new System.EventHandler(this.PlayGame_Click);
            // 
            // PacMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(305, 261);
            this.Controls.Add(this.PlayGame);
            this.Name = "PacMan";
            this.Text = "PacMan!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayGame;
    }
}

