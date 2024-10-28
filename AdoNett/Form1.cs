using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNett
{
    public partial class gbxAdd : Form
    {
        public gbxAdd()
        {
            InitializeComponent();
        }


        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product

            {
                Name = tbxName.Text,
                Fiyat = Convert.ToDecimal(tbxPrice.Text),
                Stok = Convert.ToInt32(tbxStock.Text)
            });
            LoadProducts();
            MessageBox.Show("Ürün eklendi!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxFiyatUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStokUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                Fiyat = Convert.ToDecimal(tbxFiyatUpdate.Text),
                Stok = Convert.ToInt32(tbxStokUpdate.Text)
            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Güncellendi!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Silindi!");
        }
    }
}
