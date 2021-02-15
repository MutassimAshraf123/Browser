namespace we_browser_
{
    partial class init__
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
            this.extendAero1 = new ExtendAero.ExtendAero();
            this.SuspendLayout();
            // 
            // extendAero1
            // 
            this.extendAero1.BackColor = System.Drawing.Color.Black;
            this.extendAero1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extendAero1.Location = new System.Drawing.Point(0, 0);
            this.extendAero1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.extendAero1.Name = "extendAero1";
            this.extendAero1.Size = new System.Drawing.Size(800, 450);
            this.extendAero1.TabIndex = 0;
            // 
            // init__
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.extendAero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "init__";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "init__";
            this.Load += new System.EventHandler(this.init___Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendAero.ExtendAero extendAero1;
    }
}