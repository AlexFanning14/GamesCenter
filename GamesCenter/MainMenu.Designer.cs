namespace GamesCenter
{
    partial class MainMenu
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
            this.btnSnake = new System.Windows.Forms.Button();
            this.btnCandyCrush = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSnake
            // 
            this.btnSnake.Location = new System.Drawing.Point(84, 47);
            this.btnSnake.Name = "btnSnake";
            this.btnSnake.Size = new System.Drawing.Size(357, 43);
            this.btnSnake.TabIndex = 0;
            this.btnSnake.Text = "Snake";
            this.btnSnake.UseVisualStyleBackColor = true;
            this.btnSnake.Click += new System.EventHandler(this.btnSnake_Click);
            // 
            // btnCandyCrush
            // 
            this.btnCandyCrush.Location = new System.Drawing.Point(84, 132);
            this.btnCandyCrush.Name = "btnCandyCrush";
            this.btnCandyCrush.Size = new System.Drawing.Size(357, 43);
            this.btnCandyCrush.TabIndex = 1;
            this.btnCandyCrush.Text = "Candy Crush";
            this.btnCandyCrush.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 581);
            this.Controls.Add(this.btnCandyCrush);
            this.Controls.Add(this.btnSnake);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSnake;
        private System.Windows.Forms.Button btnCandyCrush;
    }
}

