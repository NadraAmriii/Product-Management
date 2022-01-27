using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisionExamen
{
    public partial class Form1 : Form
    {
        NorthwindEntities db = NorthwindEntities.MyDbContext;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //Récupérer tous les objets Products et afficher seulement : ProductName et CategoryName
            var query1 = from p in db.Products
                        select new
                        { 
                            p.ProductName,
                            p.Category.CategoryName
                        };

            //Récupérer tous les objets Customers(CustomerID et ContactName) dont le nom commence par « A » (trié dans l’ordre croissant) en utilisant la fonction StartsWith.
            var query2 = from c in db.Customers
                         where c.CompanyName.StartsWith("A")
                         where c.Country.Equals("brasil")
                         orderby c.ContactName
                         select new
                         {
                             c.CustomerID,
                             c.ContactName
                         };



            //Récupérer et afficher les données suivantes : OrderID [Orders], CompanyName [Customers],ProductName[Products] en utilisant seulement les propriétés de navigation
            var query3 = from o in db.Orders
                         join od in db.Order_Details on o.OrderID equals od.OrderID
                         orderby o.OrderID ascending, od.Product.ProductName descending
                         select new
                         {
                             o.OrderID,
                             o.Customer.CompanyName,
                             od.Product.ProductName
                         };


            /*
              Afficher les données suivantes (nombre de produits par catégorie) : CategoryID, CategoryName
               et ProdNumber (champ calculé). Trier le résultat sur le champ ProdNumber dans l’ordre décroissant
             */

            var query4 = from p in db.Products
                         
                         group p by new
                         {
                             p.Category.CategoryID,
                             p.Category.CategoryName,
                             //p.UnitPrice
                         }
                         into grp
                         orderby grp.Count()
                         select new
                         {
                             grp.Key.CategoryID,
                             grp.Key.CategoryName,
                             ProdNumber = grp.Count(),
                             HigherPrice = grp.Max(p => p.UnitPrice),
                             LessPrice =  grp.Min(p => p.UnitPrice)

                         };

            var query5 = from c in db.Categories
                         select c;
            dgTest.DataSource = query5.ToList();
            lblTest.Text = "Lignés Trouvés: " +(query4.Count()).ToString();
            dgTest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


        public void FillCombo()
        {
            var query = from c in db.Categories
                        orderby c.CategoryName
                        select c.CategoryName;
            lsTest.Items.Add("Toutes");
            lsTest.Items.AddRange(query.ToArray());
            lsTest.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCombo();
            this.ActiveControl = dgTest;
        }

        private void lsTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            var category = lsTest.Text;
            /*if (category.Equals("Toutes"))
            {
                var query1 = from p in db.Products
                             //where p.Category.CategoryName ==category
                             select p;
                dgTest.DataSource = query1.ToList();
            }

            else
            {
                var query2 = from p in db.Products
                             where p.Category.CategoryName.Equals(category)
                             select p;
                dgTest.DataSource = query2.ToList();
            }*/
            var query = from p in db.Products
                        orderby p.ProductName
                        where p.Category.CategoryName.Equals(category)
                        || lsTest.SelectedIndex == 0
                        select p;

            /*var query = from o in db.Orders
                        join od in db.Order_Details on o.OrderID equals od.OrderID
                        orderby o.Customer.CompanyName
                        where od.Product.Category.CategoryName.Equals(category)
                        || lsTest.SelectedIndex == 0
                        select o.Customer;*/
            dgTest.DataSource = query.ToList();
            lblTest.Text = "Lignes Trouvés: " + query.Count().ToString();
            dgTest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var query = from p in db.Products

                      //.Where(productFilter)
                      //.Where (delegate (Product p) { return p.ProductName.Contains(txtTest.Text); })
                      .Where((Product p) => p.ProductName.Contains(txtTest.Text))

                       //orderby p.ProductName
                       .OrderBy((p) => p.ProductName)
                       select new
                       {
                           p.ProductID,
                           p.ProductName,
                           p.Category.CategoryName,
                           total = p.UnitPrice * p.UnitsInStock
                       };

                       /*.Select(p => new
                       {
                           p.ProductID,
                           p.ProductName,
                           p.Category.CategoryName,
                           total = p.UnitPrice * p.UnitsInStock
                       }
                       ).ToList();*/
           /* var query = from c in db.Customers
                        .Where((Customer c) => c.CompanyName.Contains(txtTest.Text))
                        select c;*/
            dgTest.DataSource = query.ToList();
            dgTest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public bool productFilter(Product p)
        {
            return p.ProductName.Contains(txtTest.Text);
        }

        private void dgTest_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt2.Text = dgTest.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            var query = from p in db.Products
                        orderby p.ProductName
                        where lsTest.SelectedIndex == 0
                        select p;

            dgTest.DataSource = query.ToList();
            this.ActiveControl = dgTest;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            int id = (int)dgTest.SelectedRows[0].Cells[0].Value;
            Product p = db.Products.Find(id);
            Form2 form = new Form2(p);
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //supprimer le produit selectionné
            int id = (int)dgTest.SelectedRows[0].Cells[0].Value;
            DialogResult result = MessageBox.Show("Supprimer", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Product p = db.Products.Find(id);
                if (p != null)
                {
                    db.Products.Remove(p);
                    db.SaveChanges();
                    var query = from prod in db.Products
                        orderby prod.ProductName
                        where lsTest.SelectedIndex == 0
                        select prod;

                    dgTest.DataSource = query.ToList();
                }
            }


        }

        private void dgTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    