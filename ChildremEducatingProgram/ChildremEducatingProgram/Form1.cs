using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildremEducatingProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.picFront.SizeMode = PictureBoxSizeMode.StretchImage;
            Color randomColor = ColorGenerator.GetRandomColor();
            this.txtbox.ForeColor = randomColor;
        }
        //===============WORKING CODES =============================


        // ==== Keep the header position stays in the centre of the form ====
        private void CenterHeader()
        {
            int newXCoord = (this.Width - this.MainHeader.Width) / 2;
            int curYCoord = this.MainHeader.Location.Y;
            this.MainHeader.Location = new Point(newXCoord, curYCoord);
        }

        // ==== Keep the header position stays in the centre of the form when the form first loads ====
        private void Form1_Load(object sender, EventArgs e)
        {
            CenterHeader();
        }

        // ==== The exit button can be enabled to allow user to leave the application ====
        private void EnableLearning_ExitButtons()
        { 
                this.btnQuit.Enabled = true;
                this.btnQuit.Visible = true;
                this.btnNext.Enabled = true;
                this.btnNext.Visible = true;            
        }

        // ==== Keep the header position stays in the centre of the form when the form resize everytime ====
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            CenterHeader();
        }

        // ==== The greeting line appear when the continue button is clicked ====
        private void btnContinue_Click(object sender, EventArgs e)
        {
            string template = "Hello ###! You are going to learn Object Oriented Programming concept.";
            string greeting = template.Replace("###", this.txtbox.Text);
            this.Greeting1.Text = greeting;
            this.Greeting2.Text = "I hope you will enjoy the learning!";

            Color myColor = ColorGenerator.GetRandomColor();
            this.Greeting1.ForeColor = myColor; //Color.Fuchsia;
            this.Greeting2.ForeColor = myColor; //Color.Fuchsia;

            this.btnContinue.Enabled = false;
            this.btnContinue.ForeColor = Color.Gray;
            this.btnContinue.BackColor = Color.LightGray;
            this.txtbox.Enabled = false;

            EnableLearning_ExitButtons();
        }

        // ==== Enable the OK button only if the name text line is filled ====
        private void EnableOkButton(object sender, EventArgs e)
        {
            this.btnContinue.Enabled = false;
            this.btnContinue.BackColor = Color.LightGray;
            this.btnContinue.ForeColor = Color.Gray;

            if (this.txtbox.Text != string.Empty)
            {
                this.btnContinue.Enabled = true;
                this.btnContinue.BackColor = Color.LightGreen;
                this.btnContinue.ForeColor = Color.Green; 
            }
        }

        // ==== The form will close and switch to form 2 when the next button is clicked ====
        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 frmTeaching = new Form2();
            frmTeaching.Owner = this;
            frmTeaching.StartPosition = FormStartPosition.Manual;
            frmTeaching.Location = this.Location;
            frmTeaching.Show();
            this.Hide();
        }

        // ==== The whole application will close when the quit button is clicked ====
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    // ==== This public class using random in color generator to make the texts be more fancy ====
    public class ColorGenerator
    {
        // Generate a random color
        public static Color GetRandomColor()
        {
            Random rnd = new Random();
            int brightness = rnd.Next(245, 256);
            Color aColor = Color.FromArgb(brightness, rnd.Next(256), rnd.Next(256), rnd.Next(256));
            return aColor;
        }
        
        //============================
    }
}
