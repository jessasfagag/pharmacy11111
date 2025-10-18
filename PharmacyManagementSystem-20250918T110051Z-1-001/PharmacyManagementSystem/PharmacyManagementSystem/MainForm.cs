using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace PharmacyManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Method para palitan ang laman ng panel
        private void LoadUserControl(UserControl uc)
        {
            mainPanel.Controls.Clear();    // Linisin ang laman
            uc.Dock = DockStyle.Fill;      // Para sakupin ang buong panel
            mainPanel.Controls.Add(uc);    // Idagdag ang bagong UserControl
        }

        // Button para ipakita ang Dashboard
        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AdminDashboard());
        }

        // Button para ipakita ang Inventory
        private void invBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Inventory());
        }

        // Button para ipakita ang Orders
        private void ordBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new CategoriesManagement());
        }

        // ➡️ Button para ipakita ang Alerts
        private void alertBtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new OrderManagement());
        }


        //archivebutton
        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new Archive());
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            LoadUserControl(new User_management());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Report());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new set());
        }


        private void adminDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadUserControl(new announcement());
        }
    }
}
