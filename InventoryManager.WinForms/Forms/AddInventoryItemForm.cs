using System.Windows.Forms;
using InventoryManager.Data;
using System.Collections.Generic;

namespace InventoryManager.WinForms.Forms
{
    public partial class AddInventoryItemForm : Form
    {
        public string ItemName
        {
            get => itemComboBox.SelectedValue.ToString();
        }

        public int ItemIndex
        {
            get => itemComboBox.SelectedIndex;
        }

        public AddInventoryItemForm()
        {
            InitializeComponent();
        }

        public AddInventoryItemForm(List<Item> items)
        {
            InitializeComponent();
            itemsBindingSource.DataSource = items;
            okButton.Enabled = !string.IsNullOrEmpty(ItemName);
        }

        private void ItemComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            okButton.Enabled = !string.IsNullOrEmpty(ItemName);
        }
    }
}
