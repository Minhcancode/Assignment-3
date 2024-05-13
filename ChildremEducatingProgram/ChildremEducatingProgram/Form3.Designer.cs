namespace ChildremEducatingProgram
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.MainHeader = new System.Windows.Forms.Label();
            this.picBoxEnd = new System.Windows.Forms.PictureBox();
            this.lblEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // MainHeader
            // 
            this.MainHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainHeader.AutoSize = true;
            this.MainHeader.Font = new System.Drawing.Font("Comic Sans MS", 25.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainHeader.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.MainHeader.Location = new System.Drawing.Point(41, 27);
            this.MainHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainHeader.Name = "MainHeader";
            this.MainHeader.Size = new System.Drawing.Size(647, 48);
            this.MainHeader.TabIndex = 2;
            this.MainHeader.Text = "Minh\'s Programming Class for Juniors";
            this.MainHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxEnd
            // 
            this.picBoxEnd.Image = ((System.Drawing.Image)(resources.GetObject("picBoxEnd.Image")));
            this.picBoxEnd.Location = new System.Drawing.Point(140, 192);
            this.picBoxEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBoxEnd.Name = "picBoxEnd";
            this.picBoxEnd.Size = new System.Drawing.Size(472, 274);
            this.picBoxEnd.TabIndex = 3;
            this.picBoxEnd.TabStop = false;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(206, 136);
            this.lblEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(251, 25);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "Thank you for studying!";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 496);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.picBoxEnd);
            this.Controls.Add(this.MainHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(904, 535);
            this.MinimumSize = new System.Drawing.Size(679, 535);
            this.Name = "Form3";
            this.Text = "Children Educating Program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.SizeChanged += new System.EventHandler(this.Form3_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainHeader;
        private System.Windows.Forms.PictureBox picBoxEnd;
        private System.Windows.Forms.Label lblEnd;
    }
}