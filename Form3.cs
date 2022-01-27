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
    public partial class Form3 : Form
    {
        NorthwindEntities db = NorthwindEntities.MyDbContext;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Cas d'ajout


            Product p = new Product
            {
                ProductName = txtProductName.Text,
                CategoryID = (int)lsTest.SelectedValue
            };
            db.Products.Add(p);
            db.SaveChanges();
            this.Close();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            FillCombo();

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
    }
}
