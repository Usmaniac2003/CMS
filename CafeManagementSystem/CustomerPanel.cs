using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CafeManagementSystem
    {
    public partial class CustomerPanel : MaterialForm
        {
        public CustomerPanel()
            {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {

        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
