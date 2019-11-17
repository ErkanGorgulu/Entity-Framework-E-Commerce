using Northwind.BLL;
using Northwind.DAL;
using Northwind.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinUI.Forms.FormOrders
{
    public partial class FormPlaceOrder : Form
    {
        public FormPlaceOrder()
        {
            InitializeComponent();
        }
        ProductController productController = new ProductController();
        List<Product> products = new List<Product>();
        Product product;
        List<Product> productsInCart = new List<Product>();

        static decimal finalPrice;
        private void FormPlaceOrder_Load(object sender, EventArgs e)
        {
            FillDiscountList();
            FillProductList();
            SetTotalPrice();
            dateOrderDate.MinDate = DateTime.Now;
            dateRequiredDate.MinDate = DateTime.Now;


        }

        private void FillProductList()
        {
            products = productController.GetProducts();
            cmbProductList.DataSource = products;
            cmbProductList.DisplayMember = "ProductName";
            cmbProductList.ValueMember = "ProductID";
        }

        private void FillDiscountList()
        {
            List<Discount> discounts = new List<Discount>();
            for (int i = 0; i <= 30; i += 5)
            {
                Discount discount = new Discount();
                discount.DisplayMember = $"%{i}";
                discount.ValueMember = i;
                discounts.Add(discount);
            }
            cmbDiscountList.DataSource = discounts;
            cmbDiscountList.DisplayMember = "DisplayMember";
            cmbDiscountList.ValueMember = "ValueMember";
        }

        private void cmbProductList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SetTotalPrice();
        }               

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            SetTotalPrice();
        }

        private void cmbDiscountList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SetTotalPrice();
        }
        private void SetTotalPrice()
        {
            product = productController.GetProductById(Convert.ToInt32(cmbProductList.SelectedValue));
            decimal discountValue = Convert.ToDecimal(cmbDiscountList.SelectedValue);
            decimal priceWithoutDiscount = (decimal)product.UnitPrice * numericQuantity.Value;
            decimal totalPrice = priceWithoutDiscount - (priceWithoutDiscount * (discountValue / 100));

            Font fnt = new Font(lblTotalPrice.Font, FontStyle.Strikeout);
            if (discountValue > 0)
            {
                lblDiscountedTotalPrice.Text = $"{totalPrice}$";
                lblTotalPrice.Font = fnt;
                lblTotalPrice.Text = $"{priceWithoutDiscount}$";
                finalPrice = totalPrice;
            }
            else
            {
                lblDiscountedTotalPrice.Text = string.Empty;
                lblTotalPrice.Text = $"{totalPrice}";
                lblTotalPrice.Font = default;
                finalPrice = totalPrice;
            }
            
        }

        private void btnAddProductToList_Click(object sender, EventArgs e)
        {
            SetTotalPrice();
            string selectedItem = cmbProductList.GetItemText(cmbProductList.SelectedItem);
            string selectedProduct = $"{selectedItem}, Quantity:{numericQuantity.Value}, Total Price:{finalPrice}";
            lstAddedProducts.Items.Add(selectedProduct);
        }
    }
}
