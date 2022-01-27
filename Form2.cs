using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisionExamen
{
    public partial class Form2 : Form
    {
        Product product;
        NorthwindEntities db = NorthwindEntities.MyDbContext;
        public Form2(Product p = null)
        {
            this.product = p; 
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FillCombo();
            if (product != null)
                FillForm(product);

        }

        private void FillForm(Product product)
        {
            txtProductName.Text = product.ProductName;
            lsTest.Text = product.Category.CategoryName;
        }

        public void FillCombo()
        {
            var query = from c in db.Categories
                        orderby c.CategoryName
                        select c;
            lsTest.DataSource = query.ToList();
            lsTest.DisplayMember = "CategoryName"; // colonne a affiché

            //colonne a caché
            lsTest.ValueMember = "CategoryID";

        }

        private void btAdd_Click(object sender, EventArgs e)
        {

            //Cas d'ajout
            if (product == null)
            {
                Product p = new Product
                {
                    ProductName = txtProductName.Text,
                    CategoryID = (int)lsTest.SelectedValue
                };
                db.Products.Add(p);
            }
            else
            {
                //Cas de modification
                product.ProductName = txtProductName.Text;
                product.CategoryID = (int)lsTest.SelectedValue;
            }
            db.SaveChanges();
            this.Close();
        }
    }
}
