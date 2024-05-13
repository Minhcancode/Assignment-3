namespace ChildremEducatingProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainHeader = new System.Windows.Forms.Label();
            this.StudentLabel = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.Greeting1 = new System.Windows.Forms.Label();
            this.Greeting2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.picFront = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFront)).BeginInit();
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
            this.MainHeader.Location = new System.Drawing.Point(150, 19);
            this.MainHeader.Name = "MainHeader";
            this.MainHeader.Size = new System.Drawing.Size(647, 48);
            this.MainHeader.TabIndex = 1;
            this.MainHeader.Text = "Minh\'s Programming Class for Juniors";
            this.MainHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentLabel
            // 
            this.StudentLabel.AutoSize = true;
            this.StudentLabel.Font = new System.Drawing.Font("MV Boli", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StudentLabel.Location = new System.Drawing.Point(26, 98);
            this.StudentLabel.Name = "StudentLabel";
            this.StudentLabel.Size = new System.Drawing.Size(211, 25);
            this.StudentLabel.TabIndex = 3;
            this.StudentLabel.Text = "What is your name?";
            // 
            // txtbox
            // 
            this.txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox.ForeColor = System.Drawing.Color.Blue;
            this.txtbox.Location = new System.Drawing.Point(250, 102);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(465, 22);
            this.txtbox.TabIndex = 4;
            this.txtbox.TextChanged += new System.EventHandler(this.EnableOkButton);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnContinue.Enabled = false;
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContinue.Font = new System.Drawing.Font("MV Boli", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnContinue.Location = new System.Drawing.Point(888, 95);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(112, 34);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Ok";
            this.btnContinue.UseCompatibleTextRendering = true;
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // Greeting1
            // 
            this.Greeting1.AutoSize = true;
            this.Greeting1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greeting1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Greeting1.Location = new System.Drawing.Point(32, 145);
            this.Greeting1.Name = "Greeting1";
            this.Greeting1.Size = new System.Drawing.Size(93, 25);
            this.Greeting1.TabIndex = 7;
            this.Greeting1.Text = "greeting1";
            // 
            // Greeting2
            // 
            this.Greeting2.AutoSize = true;
            this.Greeting2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greeting2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Greeting2.Location = new System.Drawing.Point(32, 177);
            this.Greeting2.Name = "Greeting2";
            this.Greeting2.Size = new System.Drawing.Size(93, 25);
            this.Greeting2.TabIndex = 8;
            this.Greeting2.Text = "greeting2";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnNext.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Purple;
            this.btnNext.Location = new System.Drawing.Point(621, 524);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(320, 67);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "I want to learn !";
            this.btnNext.UseCompatibleTextRendering = true;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuit.Enabled = false;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuit.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQuit.Location = new System.Drawing.Point(91, 524);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(320, 67);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "No, I\'ll learn later";
            this.btnQuit.UseCompatibleTextRendering = true;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Visible = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // picFront
            // 
            this.picFront.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picFront.ErrorImage = null;
            this.picFront.Image = ((System.Drawing.Image)(resources.GetObject("picFront.Image")));
            this.picFront.InitialImage = null;
            this.picFront.Location = new System.Drawing.Point(170, 213);
            this.picFront.Name = "picFront";
            this.picFront.Size = new System.Drawing.Size(698, 291);
            this.picFront.TabIndex = 11;
            this.picFront.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1029, 611);
            this.Controls.Add(this.picFront);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.Greeting2);
            this.Controls.Add(this.Greeting1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.StudentLabel);
            this.Controls.Add(this.MainHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Children Educating Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picFront)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MainHeader;
        private System.Windows.Forms.Label StudentLabel;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label Greeting1;
        private System.Windows.Forms.Label Greeting2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox picFront;
    }
}

