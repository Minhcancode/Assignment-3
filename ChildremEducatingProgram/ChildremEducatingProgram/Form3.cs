using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildremEducatingProgram
{
    public partial class Form3 : Form
    {
        public Form3()
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

        // ==== All of the positions colors sizes and texts will be set when the form first loads ====
        private void Form3_Load(object sender, EventArgs e)
        {
            Color newColor = ColorGenerator.GetRandomColor();
            this.Width = this.Owner.Width;
            this.Height = this.Owner.Height + 100;
            this.Location = this.Owner.Location;
            this.lblEnd.ForeColor = newColor;
            CenterHeader();
            CenterControls(picBoxEnd);
            CenterControls(lblEnd);
        }

        // ==== Keep the header and the panel position stays in the centre of the form when the form size changes ====
        private void Form3_SizeChanged(object sender, EventArgs e)
        {
            CenterHeader();
            CenterControls(picBoxEnd);
            CenterControls(lblEnd);
        }

        // ==== The whole application will close when the quit button is clicked ====
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void CenterControls(Control aControl)
        {
            int newXCoord = (this.Width - aControl.Width) / 2;
            int curYCoord = aControl.Location.Y;
            aControl.Location = new Point(newXCoord, curYCoord);
        }




        //============================
    }
}
  
