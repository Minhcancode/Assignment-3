using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChildremEducatingProgram
{
    public partial class Form2 : Form
    {
        private int stateCounter = 0;
        public Form2()
        {
            InitializeComponent();
        }
        //===============WORKING CODES =============================

        // ==== Keep the header position stays in the centre of the form ====
        private void CenterHeader()
        {
            int newXCoord = (this.Width - this.MainHeader.Width) / 2;
            int curYCoord = this.MainHeader.Location.Y;
            this.MainHeader.Location = new Point(newXCoord, curYCoord);
        }

        // ==== Keep the frame position stays in the centre of the form ====

        private void CenterFrontFrame()
        {
            this.FrontPanel.Width = this.Width - 60;
            this.FrontPanel.Height = this.Height - 160;
        }

        // ==== All of the positions colors sizes and texts will be set when the form first loads ====
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Width = this.Owner.Width;
            this.Height = this.Owner.Height + 100;
            this.Location = this.Owner.Location;
            SetControlLocation(picAmbulance, 19, 16);
            SetControlLocation(txtBoxAmbulance, 400, 16);
            SetControlLocation(picPoliceCar, 19, 177);
            SetControlLocation(txtBoxPoliceCar, 400, 177);
            SetControlLocation(picTaxi, 19, 340);
            SetControlLocation(txtBoxTaxi, 400, 340);

            CenterHeader();
            CenterFrontFrame();
            PanelHeightChange();

            this.picAmbulance.SizeMode = PictureBoxSizeMode.AutoSize;
            this.picPoliceCar.SizeMode = PictureBoxSizeMode.AutoSize;
            this.picTaxi.SizeMode = PictureBoxSizeMode.AutoSize;
            Color newColor = ColorGenerator.GetRandomColor();
            this.lblHint1.ForeColor = newColor;
            this.lblHint2.ForeColor = newColor;

            this.lblHint1.Text = "Today I am going to teach you about \"Class\" in coding!";
            this.lblHint2.Text = " Click the \"next\" button to continue.";
        }

        // ==== Keep the header and the panel position stays in the centre of the form when the form size changes ====
        private void Form_SizeChanged(object sender, EventArgs e)
        {
            CenterHeader();
            CenterFrontFrame();
            PanelHeightChange();
        }

        // ==== The whole application will close when the quit button is clicked ====
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        // ==== Position a control to a location ====
        private void SetControlLocation(Control aControl, int xLocation, int yLocation)
        {
            aControl.Location = new Point(xLocation, yLocation);
        }

        // ==== Assign a picture file to a picture box ====
        private void AssignPicture(PictureBox picBox, string picFileLocation)
        {
            picBox.Image = null;
            picBox.Image = Image.FromFile(picFileLocation);
        }

        // ==== Setting the perfect height for the panel ====
        private void PanelHeightChange()
        {
            this.FrontPanel.Height = this.Height - this.FrontPanel.Height + 350;
        }

        // ==== Write a string to a label ====
        private void AssignTextBox(TextBox txtboxName, string text, Color myColour)
        {
            txtboxName.Text = string.Empty;
            txtboxName.Text = text;
            txtboxName.ForeColor = myColour;
        }

        // ==== When the button next is clicked the pictures and texts will appear and disappear in an order ====
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            stateCounter++;

            switch (stateCounter)
            {
                case 1:
                    AssignPicture(picAmbulance, Directory.GetCurrentDirectory() + "/Images/Ambulance.jpg");
                    SetControlLocation(txtBoxAmbulance,
                                       this.picAmbulance.Location.X + this.picAmbulance.Width + 30,
                                       this.picAmbulance.Location.Y);
                    string myText = "This is an ambulance, it is used to save people. It has many funky things, such as: big engine, 4 big wheels and beautiful colors like red, white.";
                    AssignTextBox(txtBoxAmbulance, myText, ColorGenerator.GetRandomColor());
                    this.lblHint1.Text = "Imagine you are having 3 toys in your toy box, and they are:";
                    this.lblHint2.Text = string.Empty;
                    //txtBoxAmbulance.Width = this.FrontPanel.Width - this.picAmbulance.Width - 50;
                    SetControlWidth(txtBoxAmbulance, picAmbulance, 50);
                    break;

                case 2:
                    AssignPicture(picPoliceCar, Directory.GetCurrentDirectory() + "/Images/PoliceCar.jpg");
                    SetControlLocation(txtBoxPoliceCar,
                                       this.picPoliceCar.Location.X + this.picPoliceCar.Width + 30,
                                       this.picPoliceCar.Location.Y);
                    myText = "This is a police car, it is used to protect the people. This car have powerful engine for chasing, brightful colors like red, blue and black. This car also has loud honk and siren.";
                    AssignTextBox(txtBoxPoliceCar, myText, ColorGenerator.GetRandomColor());
                    //txtBoxPoliceCar.Width = this.FrontPanel.Width - this.picPoliceCar.Width - 50;
                    SetControlWidth(txtBoxPoliceCar, picPoliceCar, 50);
                    break;

                case 3:
                    AssignPicture(picTaxi, Directory.GetCurrentDirectory() + "/Images/TaxiCar.jpg");
                    SetControlLocation(txtBoxTaxi,
                                       this.picTaxi.Location.X + this.picTaxi.Width + 30,
                                       this.picTaxi.Location.Y);
                    myText = "This is a taxi and it transport people everywhere. It have fancy colors like yellow and black, it also has strong engine and fast wheels, and also have a steering wheel as well.";
                    AssignTextBox(txtBoxTaxi, myText, ColorGenerator.GetRandomColor());
                    txtBoxTaxi.Width = this.FrontPanel.Width - this.picTaxi.Width - 50;
                    break;

                case 4:
                    this.lblHint2.Text = "What characteristics each of your toys have?";
                    break;

                case 5:
                    picPoliceCar.Image = null;
                    picAmbulance.Image = null;
                    picTaxi.Image = null;
                    txtBoxAmbulance.Width = this.FrontPanel.Width - 40;
                    txtBoxAmbulance.Text = string.Empty;
                    txtBoxPoliceCar.Text = string.Empty;
                    txtBoxTaxi.Text = string.Empty;
                    SetControlLocation(picAmbulance, 19, 177);
                    SetControlLocation(picPoliceCar, 336, 177);
                    SetControlLocation(picTaxi, 661, 177);
                    AssignPicture(picAmbulance, Directory.GetCurrentDirectory() + "/Images/CarWheel.png");
                    AssignPicture(picPoliceCar, Directory.GetCurrentDirectory() + "/Images/CarEngine.jpg");
                    AssignPicture(picTaxi, Directory.GetCurrentDirectory() + "/Images/DrivingWHeel.jpg");
                    SetControlLocation(txtBoxAmbulance, 19, 16);
                    txtBoxPoliceCar.Visible = !txtBoxPoliceCar.Visible;
                    txtBoxTaxi.Visible = !txtBoxTaxi.Visible;
                    myText = "Your toys do have things in commons such as: Driving wheels, car wheels, car engines, honks, etc. And in coding (Object Oriented Programming), we call the things that objects have in common is class.";
                    AssignTextBox(txtBoxAmbulance, myText, ColorGenerator.GetRandomColor());
                    lblHint1.Text = "Although your toys are different, they still have things that in common!";
                    lblHint2.Text = "Let see things that they do have the same!";
                    break;

                case 6:
                    picPoliceCar.Image = null;
                    picAmbulance.Image = null;
                    picTaxi.Image = null;
                    picAmbulance.Visible = false;
                    picPoliceCar.Visible = false;
                    picTaxi.Visible = false;
                    txtBoxAmbulance.Width = this.FrontPanel.Width - 40;
                    txtBoxAmbulance.Text = string.Empty;
                    txtBoxPoliceCar.Text = string.Empty;
                    txtBoxTaxi.Text = string.Empty;
                    lblHint1.Text = "Coding have the same idea to show things that objects have in common, which is class.";
                    lblHint2.Text = "So what is Object Oriented Programming and class in coding?";
                    break;

                case 7:
                    picAmbulance.Visible = true;
                    SetControlLocation(picAmbulance, 19, 16);
                    AssignPicture(picAmbulance, Directory.GetCurrentDirectory() + "/Images/OOPPicture.png");
                    txtBoxAmbulance.Visible = true;
                    SetControlWidth(txtBoxAmbulance, picAmbulance, 100);

                    SetControlLocation(txtBoxAmbulance, picAmbulance.Location.X + picAmbulance.Width + 30, 16);
                    myText = "What is Object Oriented Programming? It is a concept that uses classes and their objects in programming.";
                    AssignTextBox(txtBoxAmbulance, myText, ColorGenerator.GetRandomColor());
                    break;

                case 8:
                    picPoliceCar.Visible = true;
                    SetControlLocation(picPoliceCar, 19, 177);
                    AssignPicture(picPoliceCar, Directory.GetCurrentDirectory() + "/Images/Class.jpg");
                    txtBoxPoliceCar.Visible = true;
                    SetControlWidth(txtBoxPoliceCar, picPoliceCar, 100);

                    SetControlLocation(txtBoxPoliceCar, picPoliceCar.Location.X + picPoliceCar.Width + 30, 177);
                    myText = "In object-oriented programming (OOP), a class is a mould to create similar objects. In this way, we create many objects of the same type.";
                    AssignTextBox(txtBoxPoliceCar, myText, ColorGenerator.GetRandomColor());
                    break;

                case 9:
                    picTaxi.Visible = true;
                    SetControlLocation(picTaxi, 19, 340);
                    AssignPicture(picTaxi, Directory.GetCurrentDirectory() + "/Images/Coding-online-for-kids.jpg");
                    txtBoxTaxi.Visible = true;
                    SetControlWidth(txtBoxTaxi, picTaxi, 100);

                    SetControlLocation(txtBoxTaxi, picTaxi.Location.X + picTaxi.Width + 30, 340);
                    myText = "Class is very useful in coding, for example, when you are making more than 2 small games in a big game, you can combine them together using class and then calling them using the main of that class.";
                    AssignTextBox(txtBoxTaxi, myText, ColorGenerator.GetRandomColor());
                    break;

                case 10:
                    picTaxi.Visible = false;
                    picAmbulance.Visible = false;
                    picPoliceCar.Visible = false;
                    txtBoxAmbulance.Visible = false;
                    txtBoxPoliceCar.Visible = false;
                    txtBoxTaxi.Visible = false;
                    Form3 frmTeaching = new Form3();
                    frmTeaching.Owner = this;
                    frmTeaching.StartPosition = FormStartPosition.Manual;
                    frmTeaching.Location = this.Location;
                    frmTeaching.Show();
                    this.Hide();
                    break;

            }
        }
        // ==== Create distance between the textbox and the picturebox ====
        private void SetControlWidth(Control aControl, Control offsetControl,int differentWidth)
        {
            aControl.Width = this.FrontPanel.Width - offsetControl.Width - differentWidth;
        }

       
        //============================


    }
}
