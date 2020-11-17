using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using InventoryManager.Data;
using InventoryManager.WinForms.ViewModels;

namespace InventoryManager.WinForms
{
    public partial class MainForm : Form
    {
        private WorldViewModel mViewModel;

        private WorldViewModel ViewModel 
        { 
            get => mViewModel;
            set
            {
                if(mViewModel != value)
                {
                    mViewModel = value;
                    worldViewModelBindingSource.DataSource = mViewModel;
                }
            } 
        }

        public MainForm()
        {
            InitializeComponent();
            ViewModel = new WorldViewModel();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ViewModel.World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                ViewModel.Filename = openFileDialog.FileName;
            }
        }
    }
}
