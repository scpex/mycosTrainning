using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataService;

namespace Nook
{
    public partial class Form1 : Form
    {
        DataTable dt, dt2;
        Class1 data = new Class1();
        List<TestCustomer> customerList;
        List<MycosShop> productList;
        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
            dt2 = new DataTable();
            dt.Columns.Add("CustomerID");
            dt.Columns.Add("CompanyName");
            dt.Columns.Add("ContractName");
            dt.Columns.Add("TotalOrderPrice");
      
            dt2.Columns.Add("ProductCode");
            dt2.Columns.Add("ProductName");
            dt2.Columns.Add("Price");
            dt2.Columns.Add("PriceIncludeVAT");

            getData();

        }

        public void getData()
        {
            
            customerList = new List<TestCustomer>();
            customerList = data.getCustomerAll();
            productList = new List<MycosShop>();
            productList = data.getProductAll();
            setData(customerList);
            setDataProduct(productList);
        }

        public void setDataProduct(List<MycosShop> _productList)
        {
            dt2.Clear();

            foreach(var product in _productList)
            {

                dt2.Rows.Add(product.ProductCode, product.ProductName, product.Price, product.PriceVAT);
            }
            dataGridView2.DataSource = dt2;

            if (_productList.Count() > 0)
            { 
                productMinLabel.Text = _productList.Min(m => m.Price).ToString();
                productMaxLabel.Text = _productList.Max(x => x.Price).ToString();
                ProductAVGLabel.Text = _productList.Average(a => a.Price).ToString();
            }
            else
            {
                ProductAVGLabel.Text = "0";
                productMaxLabel.Text = "0";
                productMinLabel.Text = "0";
            }

        }
        public void setData(List<TestCustomer> _listCustomer)
        {
            dt.Clear();

            foreach (var customer in _listCustomer)
            {
                dt.Rows.Add(customer.CustomerID, customer.CompanyName, customer.ContractName, customer.TotalOrderPrice);
            }
            dataGridView1.DataSource = dt;

            sumLabel.Text = _listCustomer.Sum(s => s.TotalOrderPrice).ToString();
            minLabel.Text = _listCustomer.Min(m => m.TotalOrderPrice).ToString();
            maxLabel.Text = _listCustomer.Max(x => x.TotalOrderPrice).ToString();
            avgLabel.Text = _listCustomer.Average(a => a.TotalOrderPrice).ToString();
        }
   
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.searchItems.KeyUp += new KeyEventHandler(enterValue);
        }
        public void enterValue(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                SearchItems(searchItems.Text);
              
            }
        }
        public void SearchItems(string values)
        {
            customerList = data.getCustomerAll();
            List<TestCustomer> _curList = new List<TestCustomer>();
            _curList = customerList.Where(c => c.CompanyName.Contains(values) || c.CustomerID.Contains(values) || c.ContractName.Contains(values)).ToList();
            setData(_curList);
            
        }
        public void SearchItemsProduct(string values)
        {
            productList = data.getProductAll();
            List<MycosShop> _curList = new List<MycosShop>();
            _curList = productList.Where(p => p.ProductCode.Contains(values) || p.ProductName.Contains(values)).ToList();
            setDataProduct(_curList);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maxLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                SearchItemsProduct(searchItems.Text);
            else if (tabControl1.SelectedIndex == 0)
                SearchItems(searchItems.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
               
        }
        private void tabPage2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    { }
                    break;
                case 1:
                    { label1.Text = "Mycos Shop"; }
                    break;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                label1.Text = "Mycos Shop";
            else if(tabControl1.SelectedIndex == 0)
                label1.Text = "Customer";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            
        }
    }
}
