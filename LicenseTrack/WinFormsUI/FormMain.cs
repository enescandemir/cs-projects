using Core.Utilities.Session;
using MaterialSkin;
using MaterialSkin.Controls;
using WinFormsUI.Customer;
using WinFormsUI.License;
using WinFormsUI.ProgramFrm;
using WinFormsUI.ProgramLicense;
using WinFormsUI.UpdateTable;
using WinFormsUI.Version;
using System.Runtime.InteropServices;
using WinFormsUI.Helpers;

namespace WinFormsUI
{

    public partial class FormMain : MaterialForm
    {

        private bool isMenuVisible = false;


        public FormMain()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(
            (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2
            );
            this.FormClosing += (s, e) => Application.Exit();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey100,
                Primary.BlueGrey200,
                Primary.BlueGrey300,
                Accent.LightBlue400,
                TextShade.BLACK
            );



            this.Load += FormMain_Load;



            SetAdminButtonVisibility();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyRoundedCorners(buttonAdmin, 20);
            UIHelper.ApplyRoundedCorners(buttonLogout, 10);
            UIHelper.ApplyRoundedCorners(buttonMenu, 10);
            PopulateSideMenu();
        }

        private void SetAdminButtonVisibility()
        {
            buttonAdmin.Visible = Session.UserRole == "Admin";
        }

        private void OpenForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.WindowState = FormWindowState.Maximized;       
            form.FormBorderStyle = FormBorderStyle.None;       
            form.Show();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            OpenForm(new FormCustomer());
        }

        private void buttonLicense_Click(object sender, EventArgs e)
        {
            OpenForm(new FormLicense());
        }

        private void buttonProgram_Click(object sender, EventArgs e)
        {
            OpenForm(new FormProgram());
        }

        private void buttonProgramLicense_Click(object sender, EventArgs e)
        {
            OpenForm(new FormProgramLicense());
        }

        private void buttonUpdateTable_Click(object sender, EventArgs e)
        {
            OpenForm(new FormUpdateTable());
        }

        private void buttonVersion_Click(object sender, EventArgs e)
        {
            OpenForm(new FormVersion());
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            OpenForm(new FormAdmin());
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            isMenuVisible = !isMenuVisible;
            int targetX = isMenuVisible ? 0 : -200;

            if (isMenuVisible)
                sideMenuPanel.BringToFront();
            else
                buttonMenu.BringToFront(); 

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += (s, ev) =>
            {
                int step = 20;
                if (isMenuVisible && sideMenuPanel.Left < targetX)
                {
                    sideMenuPanel.Left = Math.Min(sideMenuPanel.Left + step, targetX);
                }
                else if (!isMenuVisible && sideMenuPanel.Left > targetX)
                {
                    sideMenuPanel.Left = Math.Max(sideMenuPanel.Left - step, targetX);
                }
                else
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };
            timer.Start();
        }

        private void PopulateSideMenu()
        {
            var fullName = Session.UserName;
            var nameParts = fullName.Split(' '); 

            string displayName = nameParts.Length > 1
                ? nameParts[0] + " " + nameParts[1].Substring(0, 1) + "." 
                : nameParts[0];

            sideMenuPanel.Controls.Clear();

            Image userIconImage = Session.UserRole == "Admin"
                ? Properties.Resources.adminUser.ToBitmap()
                : Properties.Resources.user.ToBitmap();
            var userHeaderPanel = new Panel
            {
                Size = new Size(180, 60),
                Dock = DockStyle.Top 
            };
            var userIcon = new PictureBox
            {
                Image = userIconImage,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(50, 50),
                Location = new Point(10, 10)
            };
            var lblUserName = new Label
            {
                Text = displayName,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Black,
                AutoSize = true,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleCenter,
            };

            lblUserName.Location = new Point(
                userIcon.Right + 10,
                userIcon.Top + (userIcon.Height - lblUserName.PreferredHeight) / 2
            );



            userHeaderPanel.Controls.Add(userIcon);
            userHeaderPanel.Controls.Add(lblUserName);
            sideMenuPanel.Controls.Add(userHeaderPanel);

            var buttons = new (string Text, EventHandler Click)[]
            {
        ("Müþteri", buttonCustomer_Click),
        ("Lisans", buttonLicense_Click),
        ("Program", buttonProgram_Click),
        ("Program-Lisans", buttonProgramLicense_Click),
        ("Versiyon", buttonVersion_Click),
        ("Güncellemeler", buttonUpdateTable_Click),
            };

            if (Session.UserRole == "Admin")
            {
                buttons = buttons.Append(("Admin Panel", buttonAdmin_Click)).ToArray();
            }

            int y = userHeaderPanel.Bottom + 10;

            foreach (var (text, handler) in buttons)
            {
                var btn = new MaterialButton
                {
                    Text = text,

                    AutoSize = false,
                    Size = new Size(180, 40),
                    Location = new Point(10, y),
                    Type = MaterialButton.MaterialButtonType.Contained
                };

                btn.Click += handler;
                sideMenuPanel.Controls.Add(btn);
                y += 50;
            }
            if (buttonBack == null)
            {
                buttonBack = new MaterialButton
                {
                    Text = "Geri",
                    Size = new Size(180, 40),
                    Location = new Point(10, sideMenuPanel.Height-50),
                    Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                    Type = MaterialButton.MaterialButtonType.Contained
                };
                buttonBack.Click += (s, e) =>
                {
                    isMenuVisible = false;
                    int targetX = -200;

                    var timer = new System.Windows.Forms.Timer();
                    timer.Interval = 10;
                    timer.Tick += (sender, ev) =>
                    {
                        int step = 20;
                        if (sideMenuPanel.Left > targetX)
                        {
                            sideMenuPanel.Left = Math.Max(sideMenuPanel.Left - step, targetX);
                        }
                        else
                        {
                            timer.Stop();
                            timer.Dispose();
                        }
                    };
                    timer.Start();
                };
            }
            sideMenuPanel.Controls.Add(buttonBack);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Program.isLoggingOut = true;
            System.Diagnostics.Process.Start(Application.ExecutablePath);

            Environment.Exit(0);
        }


    }
}
