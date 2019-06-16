namespace DATABASE_RELATION_APP
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
            this.Savebutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Savebutton1
            // 
            this.Savebutton1.Location = new System.Drawing.Point(615, 121);
            this.Savebutton1.Name = "Savebutton1";
            this.Savebutton1.Size = new System.Drawing.Size(98, 33);
            this.Savebutton1.TabIndex = 0;
            this.Savebutton1.Text = "Save";
            this.Savebutton1.UseVisualStyleBackColor = true;
            this.Savebutton1.Click += new System.EventHandler(this.Savebutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Savebutton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Savebutton1;
    }
}

