
namespace PLAY_IN
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Panel_Strip = new System.Windows.Forms.Panel();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.App_Name = new System.Windows.Forms.Label();
            this.Panel_User = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Panel_Shade_Games = new System.Windows.Forms.Panel();
            this.Strip_Games = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Strip_Sessions = new FontAwesome.Sharp.IconButton();
            this.Panel_Shade_Sessions = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Strip_Stats = new FontAwesome.Sharp.IconButton();
            this.Panel_Shade_Stats = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.Strip_Exit = new FontAwesome.Sharp.IconButton();
            this.Close_Button = new FontAwesome.Sharp.IconButton();
            this.User = new FontAwesome.Sharp.IconButton();
            this.Panel_Menu.SuspendLayout();
            this.Panel_Strip.SuspendLayout();
            this.Panel_User.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.Panel_Menu.Controls.Add(this.Close_Button);
            this.Panel_Menu.Controls.Add(this.App_Name);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(1100, 70);
            this.Panel_Menu.TabIndex = 0;
            // 
            // Panel_Strip
            // 
            this.Panel_Strip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.Panel_Strip.Controls.Add(this.panel11);
            this.Panel_Strip.Controls.Add(this.panel9);
            this.Panel_Strip.Controls.Add(this.panel7);
            this.Panel_Strip.Controls.Add(this.panel5);
            this.Panel_Strip.Controls.Add(this.Panel_User);
            this.Panel_Strip.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Strip.Location = new System.Drawing.Point(0, 70);
            this.Panel_Strip.Name = "Panel_Strip";
            this.Panel_Strip.Size = new System.Drawing.Size(300, 530);
            this.Panel_Strip.TabIndex = 1;
            // 
            // Panel_Main
            // 
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(300, 70);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(800, 530);
            this.Panel_Main.TabIndex = 2;
            // 
            // App_Name
            // 
            this.App_Name.AutoSize = true;
            this.App_Name.Font = new System.Drawing.Font("Fugaz One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_Name.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.App_Name.Location = new System.Drawing.Point(71, 21);
            this.App_Name.Name = "App_Name";
            this.App_Name.Size = new System.Drawing.Size(125, 39);
            this.App_Name.TabIndex = 0;
            this.App_Name.Text = "PLAY-IN";
            // 
            // Panel_User
            // 
            this.Panel_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.Panel_User.Controls.Add(this.User);
            this.Panel_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_User.Location = new System.Drawing.Point(0, 0);
            this.Panel_User.Name = "Panel_User";
            this.Panel_User.Size = new System.Drawing.Size(300, 150);
            this.Panel_User.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Strip_Games);
            this.panel5.Controls.Add(this.Panel_Shade_Games);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 68);
            this.panel5.TabIndex = 1;
            // 
            // Panel_Shade_Games
            // 
            this.Panel_Shade_Games.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel_Shade_Games.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Shade_Games.Location = new System.Drawing.Point(0, 0);
            this.Panel_Shade_Games.Name = "Panel_Shade_Games";
            this.Panel_Shade_Games.Size = new System.Drawing.Size(10, 68);
            this.Panel_Shade_Games.TabIndex = 0;
            // 
            // Strip_Games
            // 
            this.Strip_Games.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Strip_Games.FlatAppearance.BorderSize = 0;
            this.Strip_Games.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Strip_Games.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Strip_Games.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Strip_Games.IconChar = FontAwesome.Sharp.IconChar.List;
            this.Strip_Games.IconColor = System.Drawing.SystemColors.ControlLight;
            this.Strip_Games.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Strip_Games.IconSize = 36;
            this.Strip_Games.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Strip_Games.Location = new System.Drawing.Point(10, 0);
            this.Strip_Games.Name = "Strip_Games";
            this.Strip_Games.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Strip_Games.Size = new System.Drawing.Size(290, 68);
            this.Strip_Games.TabIndex = 1;
            this.Strip_Games.Text = "ACTIVE GAMES";
            this.Strip_Games.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Strip_Games.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Strip_Games.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Strip_Sessions);
            this.panel7.Controls.Add(this.Panel_Shade_Sessions);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 218);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 68);
            this.panel7.TabIndex = 2;
            // 
            // Strip_Sessions
            // 
            this.Strip_Sessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Strip_Sessions.FlatAppearance.BorderSize = 0;
            this.Strip_Sessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Strip_Sessions.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Strip_Sessions.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Strip_Sessions.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.Strip_Sessions.IconColor = System.Drawing.SystemColors.ControlLight;
            this.Strip_Sessions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Strip_Sessions.IconSize = 36;
            this.Strip_Sessions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Strip_Sessions.Location = new System.Drawing.Point(10, 0);
            this.Strip_Sessions.Name = "Strip_Sessions";
            this.Strip_Sessions.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Strip_Sessions.Size = new System.Drawing.Size(290, 68);
            this.Strip_Sessions.TabIndex = 1;
            this.Strip_Sessions.Text = "MY SESSIONS";
            this.Strip_Sessions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Strip_Sessions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Strip_Sessions.UseVisualStyleBackColor = true;
            // 
            // Panel_Shade_Sessions
            // 
            this.Panel_Shade_Sessions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel_Shade_Sessions.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Shade_Sessions.Location = new System.Drawing.Point(0, 0);
            this.Panel_Shade_Sessions.Name = "Panel_Shade_Sessions";
            this.Panel_Shade_Sessions.Size = new System.Drawing.Size(10, 68);
            this.Panel_Shade_Sessions.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.Strip_Stats);
            this.panel9.Controls.Add(this.Panel_Shade_Stats);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 286);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(300, 68);
            this.panel9.TabIndex = 3;
            // 
            // Strip_Stats
            // 
            this.Strip_Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Strip_Stats.FlatAppearance.BorderSize = 0;
            this.Strip_Stats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Strip_Stats.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Strip_Stats.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Strip_Stats.IconChar = FontAwesome.Sharp.IconChar.Signal;
            this.Strip_Stats.IconColor = System.Drawing.SystemColors.ControlLight;
            this.Strip_Stats.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Strip_Stats.IconSize = 36;
            this.Strip_Stats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Strip_Stats.Location = new System.Drawing.Point(10, 0);
            this.Strip_Stats.Name = "Strip_Stats";
            this.Strip_Stats.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Strip_Stats.Size = new System.Drawing.Size(290, 68);
            this.Strip_Stats.TabIndex = 1;
            this.Strip_Stats.Text = "STATS";
            this.Strip_Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Strip_Stats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Strip_Stats.UseVisualStyleBackColor = true;
            // 
            // Panel_Shade_Stats
            // 
            this.Panel_Shade_Stats.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel_Shade_Stats.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Shade_Stats.Location = new System.Drawing.Point(0, 0);
            this.Panel_Shade_Stats.Name = "Panel_Shade_Stats";
            this.Panel_Shade_Stats.Size = new System.Drawing.Size(10, 68);
            this.Panel_Shade_Stats.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.Strip_Exit);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 462);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(300, 68);
            this.panel11.TabIndex = 4;
            // 
            // Strip_Exit
            // 
            this.Strip_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Strip_Exit.FlatAppearance.BorderSize = 0;
            this.Strip_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Strip_Exit.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Strip_Exit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Strip_Exit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.Strip_Exit.IconColor = System.Drawing.SystemColors.ControlLight;
            this.Strip_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Strip_Exit.IconSize = 36;
            this.Strip_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Strip_Exit.Location = new System.Drawing.Point(0, 0);
            this.Strip_Exit.Name = "Strip_Exit";
            this.Strip_Exit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Strip_Exit.Size = new System.Drawing.Size(300, 68);
            this.Strip_Exit.TabIndex = 1;
            this.Strip_Exit.Text = "EXIT";
            this.Strip_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Strip_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Strip_Exit.UseVisualStyleBackColor = true;
            // 
            // Close_Button
            // 
            this.Close_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Fugaz One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Button.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Close_Button.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.Close_Button.IconColor = System.Drawing.SystemColors.ControlLight;
            this.Close_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Close_Button.IconSize = 40;
            this.Close_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close_Button.Location = new System.Drawing.Point(1040, 21);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(48, 39);
            this.Close_Button.TabIndex = 2;
            this.Close_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Close_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Close_Button.UseVisualStyleBackColor = true;
            // 
            // User
            // 
            this.User.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User.Enabled = false;
            this.User.FlatAppearance.BorderSize = 0;
            this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User.Font = new System.Drawing.Font("Fugaz One", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.User.IconChar = FontAwesome.Sharp.IconChar.User;
            this.User.IconColor = System.Drawing.SystemColors.ControlLight;
            this.User.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.User.IconSize = 62;
            this.User.Location = new System.Drawing.Point(0, 0);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(300, 150);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            this.User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.User.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.Panel_Main);
            this.Controls.Add(this.Panel_Strip);
            this.Controls.Add(this.Panel_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Panel_Menu.ResumeLayout(false);
            this.Panel_Menu.PerformLayout();
            this.Panel_Strip.ResumeLayout(false);
            this.Panel_User.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Panel Panel_Strip;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton Strip_Games;
        private System.Windows.Forms.Panel Panel_Shade_Games;
        private System.Windows.Forms.Panel Panel_User;
        private System.Windows.Forms.Label App_Name;
        private System.Windows.Forms.Panel panel11;
        private FontAwesome.Sharp.IconButton Strip_Exit;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton Strip_Stats;
        private System.Windows.Forms.Panel Panel_Shade_Stats;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton Strip_Sessions;
        private System.Windows.Forms.Panel Panel_Shade_Sessions;
        private FontAwesome.Sharp.IconButton Close_Button;
        private FontAwesome.Sharp.IconButton User;
    }
}

