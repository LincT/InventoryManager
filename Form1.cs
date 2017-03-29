using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initializeControls();
        }
        List<string> colors = new List<string>
        {"Color?","Red","Blue","White","Black","Green" };
        List<string> sizes = new List<string>
        {"Size?","XS","S","M","L","XL"};
        List<string> types = new List<string>
        {"Type?","Pants","T-Shirt","Dress Shirt","Jacket"};

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string type = cboType.Text;
            string color = cboColor.Text;
            string size = cboSize.Text;
            string desc = txtDesc.Text;
            decimal price;
            decimal.TryParse(txtPrice.Text, out price);
            Item newItem = new Item(desc,type, color, size, price);
            Debug.Write(newItem.ToString());
            lstItems.Items.Add(newItem.GetDisplayText().ToString());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //initializeControls();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void initializeControls()
        {
            foreach (string size in sizes)
            {cboSize.Items.Add(size);}
            cboSize.SelectedIndex = 0;
            Debug.Write(string.Join(",", sizes));
            foreach (string color in colors)
            { cboColor.Items.Add(color); }
            cboColor.SelectedIndex = 0;
            foreach (string type in types)
            { cboType.Items.Add(type); }
            cboType.SelectedIndex = 0;
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstItems.Items.Remove(lstItems.SelectedItem);
        }
        private void imageUpdate()
        {
            Debug.Write(cboType.Text + cboColor.Text);
            string selection = cboType.Text + cboColor.Text;

            SortedList<string, System.Drawing.Bitmap> images =
                 new SortedList<string, System.Drawing.Bitmap>
                 {
                     //t-shirts
                     {"T-ShirtRed", InventoryManager.Properties.Resources.TShirtRed},
                     {"T-ShirtWhite", InventoryManager.Properties.Resources.TShirtWhite},
                     {"T-ShirtBlue", InventoryManager.Properties.Resources.TShirtBlue},
                     {"T-ShirtGreen", InventoryManager.Properties.Resources.TShirtGreen},
                     {"T-ShirtBlack", InventoryManager.Properties.Resources.TShirtBlack},
                     //dress shirts
                     {"Dress ShirtRed", InventoryManager.Properties.Resources.DressShirtRed},
                     {"Dress ShirtWhite", InventoryManager.Properties.Resources.DressShirtWhite},
                     {"Dress ShirtBlue", InventoryManager.Properties.Resources.DressShirtBlue},
                     {"Dress ShirtGreen", InventoryManager.Properties.Resources.DressShirtGreen},
                     {"Dress ShirtBlack", InventoryManager.Properties.Resources.DressShirtBlack},
                     //pants
                     {"PantsRed", InventoryManager.Properties.Resources.JeansRed},
                     {"PantsWhite", InventoryManager.Properties.Resources.JeansWhite},
                     {"PantsBlue", InventoryManager.Properties.Resources.JeansBlue},
                     {"PantsGreen", InventoryManager.Properties.Resources.JeansGreen},
                     {"PantsBlack", InventoryManager.Properties.Resources.JeansBlack},

                     //jacket
                     {"JacketRed", InventoryManager.Properties.Resources.JacketRed},
                     {"JacketWhite", InventoryManager.Properties.Resources.JacketWhite},
                     {"JacketBlue", InventoryManager.Properties.Resources.JacketBlue},
                     {"JacketGreen", InventoryManager.Properties.Resources.JacketGreen},
                     {"JacketBlack", InventoryManager.Properties.Resources.JacketBlack}
                 };
            if (cboType.SelectedIndex != 0 && cboColor.SelectedIndex != 0)
            { pbItem.Image = images[selection]; }
            else
            {
                pbItem.Image = null;
            }
            
            
        }

        private void indexChanges(object sender, EventArgs e)
        {
            imageUpdate();
        }
    }
}
