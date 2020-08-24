using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class MainAdmin : Form
    {

        static MainAdmin _obj;

        public static MainAdmin Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new MainAdmin();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return PanelContainer; }
            set { PanelContainer = value; }
        }

        public MainAdmin()
        {
            InitializeComponent();
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {
            _obj = this;
            HomeAdmin home = new HomeAdmin
            {
                Dock = DockStyle.Fill
            };
            PanelContainer.Controls.Add(home);
        }

        private void BtnCarReg_Click(object sender, EventArgs e)
        {
            if (!Instance.PnlContainer.Controls.ContainsKey("CarRegistration"))
            {
                CarRegistration cars = new CarRegistration
                {
                    Dock = DockStyle.Fill
                };
                Instance.PnlContainer.Controls.Add(cars);
            }
            Instance.PnlContainer.Controls["CarRegistration"].BringToFront();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        /*DROPDOWNS*/
        private bool isCollapsed = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed == true)
            {
                PanelDropdown.Height += 10;
                if (PanelDropdown.Size == PanelDropdown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                PanelDropdown.Height -= 10;
                if (PanelDropdown.Size == PanelDropdown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }


        private void BtnReport_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void BtnClientReport_Click_1(object sender, EventArgs e)
        {
            if (!Instance.PnlContainer.Controls.ContainsKey("ClientReport"))
            {
                ClientReport client = new ClientReport
                {
                    Dock = DockStyle.Fill
                };
                Instance.PnlContainer.Controls.Add(client);
            }
            Instance.PnlContainer.Controls["ClientReport"].BringToFront();
        }

        private void BtnCarReport_Click(object sender, EventArgs e)
        {
            if (!Instance.PnlContainer.Controls.ContainsKey("CarReport"))
            {
                CarReport carreport = new CarReport
                {
                    Dock = DockStyle.Fill
                };
                Instance.PnlContainer.Controls.Add(carreport);
            }
            Instance.PnlContainer.Controls["CarReport"].BringToFront();
        }

        private void BtnTransaction_Click(object sender, EventArgs e)
        {
            if (!Instance.PnlContainer.Controls.ContainsKey("TransactionReport"))
            {
                TransactionReport rentreport = new TransactionReport
                {
                    Dock = DockStyle.Fill
                };
                Instance.PnlContainer.Controls.Add(rentreport);
            }
            Instance.PnlContainer.Controls["TransactionReport"].BringToFront();
        }

    }
}
