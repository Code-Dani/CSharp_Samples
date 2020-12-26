using System.Windows;
using System.Drawing;
using System;

namespace Program_minimized
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Windows.Forms.NotifyIcon nIcon = new System.Windows.Forms.NotifyIcon();
        private System.Windows.Forms.ContextMenu cm = new System.Windows.Forms.ContextMenu();
        private System.Windows.Forms.Control Controller = new System.Windows.Forms.Control();
        bool check = false;

        public MainWindow()
        {
            nIcon.Icon = new Icon(@"..\..\Icons\RageBot.ico");
            nIcon.Visible = true;
            nIcon.MouseClick += NIcon_MouseClick;
            System.Windows.Forms.MenuItem Mi;
            for (int i = 0; i < 3; i++)
            {
                Mi = new System.Windows.Forms.MenuItem();
                Mi.Text = i.ToString();
                if (i == 0)
                {
                    Mi.Text = "close";
                }                   
                
                Mi.Index = i;
                Mi.Click += Mi_Click;
                cm.MenuItems.Add(Mi);
            }
            nIcon.ContextMenu = cm;
            InitializeComponent();
        }

        private void Mi_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.MenuItem obj = (System.Windows.Forms.MenuItem)sender;
            if(obj.Text == "close")
            {
                check = true;
                this.Close();
            }
            if(obj.Text == "1" || obj.Text == "2")
            {
                MessageBox.Show("Hai premuto: " + obj.Text);
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(check == false)
            { 
                e.Cancel = true;
                nIcon.ShowBalloonTip(500, "Minimized", "Your application has been minimized", System.Windows.Forms.ToolTipIcon.Info);
                this.Visibility = Visibility.Hidden;
            }
        }
        private void NIcon_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                try
                {
                    nIcon.ContextMenu.Show(Controller, e.Location);
                }
                catch (Exception err) { Console.WriteLine(err.Message); }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Visibility = Visibility.Visible;
                this.WindowState = WindowState.Normal;
            }

        }
    }
}
