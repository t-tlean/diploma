using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLAY_IN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool draging = false;
        Point dragCursorPoint;
        Point dragFormPoint;

        private Color ActBackgroundColor = Color.FromArgb(52, 52, 52);
        private Color ActForegroundColor = Color.FromArgb(5, 0, 50);

        private Color DefBackgroundColor = Color.FromArgb(46, 46, 50);
        private Color DefForegroundColor = Color.FromArgb(227, 227, 227);

        private void SetButtonColors(FontAwesome.Sharp.IconButton button, Color backcolor, Color forecolor)
        {
            button.BackColor = backcolor;
            button.ForeColor = forecolor;
            button.IconColor = forecolor;
        }

        private void Strip_Games_Click(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton activeButton = (FontAwesome.Sharp.IconButton)sender;
            SetButtonColors(activeButton, ActBackgroundColor, ActForegroundColor);
            Panel_Shade_Games.Visible = true;
            SetButtonColors(Strip_Sessions, DefBackgroundColor, DefForegroundColor);
            SetButtonColors(Strip_Stats, DefBackgroundColor, DefForegroundColor);
            Panel_Shade_Sessions.Visible = false;
            Panel_Shade_Stats.Visible = false;
        }

        private void Strip_Sessions_Click(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton activeButton = (FontAwesome.Sharp.IconButton)sender;
            SetButtonColors(activeButton, ActBackgroundColor, ActForegroundColor);
            Panel_Shade_Sessions.Visible = true;
            SetButtonColors(Strip_Games, DefBackgroundColor, DefForegroundColor);
            SetButtonColors(Strip_Stats, DefBackgroundColor, DefForegroundColor);
            Panel_Shade_Games.Visible = false;
            Panel_Shade_Stats.Visible = false;
        }

        private void Strip_Stats_Click(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconButton activeButton = (FontAwesome.Sharp.IconButton)sender;
            SetButtonColors(activeButton, ActBackgroundColor, ActForegroundColor);
            Panel_Shade_Stats.Visible = true;
            SetButtonColors(Strip_Sessions, DefBackgroundColor, DefForegroundColor);
            SetButtonColors(Strip_Games, DefBackgroundColor, DefForegroundColor);
            Panel_Shade_Sessions.Visible = false;
            Panel_Shade_Games.Visible = false;
        }

        private void Strip_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Min_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Max_Button_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel_Menu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Panel_Menu_MouseDown(object sender, MouseEventArgs e)
        {
            draging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Panel_Menu_MouseUp(object sender, MouseEventArgs e)
        {
            draging = false;
        }

        private void Panel_Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (draging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
    }
}
