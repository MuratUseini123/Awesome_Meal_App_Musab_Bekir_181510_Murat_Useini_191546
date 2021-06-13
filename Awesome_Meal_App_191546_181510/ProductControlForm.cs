using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Awesome_Meal_App_191546_181510
{
    public partial class ProductControlForm : Form
    {
        public ProductControlForm()
        {
            InitializeComponent();
        }

        private void foodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.foodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.foodDatabaseDataSet);
            DialogResult = DialogResult.OK;

        }

        private void ProductControlForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodDatabaseDataSet.Food' table. You can move, or remove it, as needed.
            this.foodTableAdapter.Fill(this.foodDatabaseDataSet.Food);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.foodBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.foodDatabaseDataSet);
            DialogResult = DialogResult.OK;
        }
    }
}
