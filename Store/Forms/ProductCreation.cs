using Microsoft.Extensions.Configuration;
using Store.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.Forms
{
    public partial class ProductCreation : Form
    {
        public ProductCreation()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Program.Configuration != null)
            {
                var mySettings = Program.Configuration.GetSection("SystemSettings").Get<SystemSettings>();

                if (mySettings != null)
                {
                    Text = mySettings.Text;
                    ForeColor = mySettings.ForeColor;
                    BackColor = mySettings.BackColor;
                    Size = mySettings.Size;
                }
            }
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            Products products = new Products();

            products.InsertProduct(txtProductName.Text,txtPrice.Text);
        }
    }
}
