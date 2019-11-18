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
        CustomerController customerController = new CustomerController();
        EmployeeController employeeController = new EmployeeController();
        ShipperController shipperController = new ShipperController();
        OrderController orderController = new OrderController();
        OrderDetailController orderDetailController = new OrderDetailController();

        List<Product> products = new List<Product>();
        Product product;
        List<ShoppingCartAddedProduct> productsInCart = new List<ShoppingCartAddedProduct>();

        static decimal finalPrice;
        static decimal priceWithoutDiscount;
        private void FormPlaceOrder_Load(object sender, EventArgs e)
        {
            FillDiscountList();
            FillProductList();
            SetTotalPrice();
            dateOrderDate.MinDate = DateTime.Now;
            dateRequiredDate.MinDate = DateTime.Now;
            FillCustomerList();
            FillEmployeeList();
            FillShipperList();
        }


        private void FillShipperList()
        {
            cmbShipperList.DataSource = shipperController.GetShippers();
            cmbShipperList.DisplayMember = "CompanyName";
            cmbShipperList.ValueMember = "ShipperID";
        }

        private void FillEmployeeList()
        {
            List<Employee> employees = employeeController.GetEmployees();
            foreach (Employee employee in employees)
            {
                employee.NameWithTitle = $"{employee.FirstName} {employee.LastName}";
            }
            cmbEmployeeList.DataSource = employees;
            cmbEmployeeList.DisplayMember = "NameWithTitle";
            cmbEmployeeList.ValueMember = "EmployeeID";
        }

        private void FillCustomerList()
        {
            cmbCustomerList.DataSource = customerController.GetCustomers();
            cmbCustomerList.DisplayMember = "CompanyName";
            cmbCustomerList.ValueMember = "CustomerID";
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
                discount.ValueMember = Decimal.Divide(i,100);
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
            priceWithoutDiscount = (decimal)product.UnitPrice * numericQuantity.Value;
            decimal totalPrice = priceWithoutDiscount - (priceWithoutDiscount * discountValue);

            Font fnt = new Font(lblTotalPrice.Font, FontStyle.Strikeout);
            if (discountValue > 0)
            {
                lblDiscountedTotalPrice.Text = $"{totalPrice}$";
                lblTotalPrice.Font = fnt;
                lblTotalPrice.Text = $"{priceWithoutDiscount}$";
                finalPrice = Math.Round(totalPrice, 2);

            }
            else
            {
                lblDiscountedTotalPrice.Text = string.Empty;
                lblTotalPrice.Text = $"{totalPrice}";
                lblTotalPrice.Font = default;
                finalPrice = Math.Round(totalPrice, 2);

            }

        }

        private void btnAddProductToList_Click(object sender, EventArgs e)
        {
            SetTotalPrice();

            Product product = productController.GetProductById
                (Convert.ToInt32(cmbProductList.SelectedValue));
            string addedProductDetail;
            foreach (var item in productsInCart)
            {
                if(item.ProductID == product.ProductID)
                {
                    item.Quantity += Convert.ToInt32(numericQuantity.Value);
                    MessageBox.Show($"There is already a product named {product.ProductName} in the shopping cart. On checkout, first discount rate will be applied on the extra products.");
                    addedProductDetail = $"{product.ProductName}, Quantity:{numericQuantity.Value}, Total Price:{priceWithoutDiscount}";
                    lstAddedProducts.Items.Add(addedProductDetail);
                    return;
                }
            }
            
            addedProductDetail = $"{product.ProductName}, Quantity:{numericQuantity.Value}, Total Price:{finalPrice}";
            lstAddedProducts.Items.Add(addedProductDetail);
            
             
            ShoppingCartAddedProduct addedProduct = new ShoppingCartAddedProduct
            {
                ProductID = product.ProductID,
                Quantity = Convert.ToInt32(numericQuantity.Value),
                UnitPrice = (decimal)product.UnitPrice,
                Discount = Convert.ToDecimal(cmbDiscountList.SelectedValue)
            };
            productsInCart.Add(addedProduct);
        }

        private void dateOrderDate_ValueChanged(object sender, EventArgs e)
        {
            dateRequiredDate.MinDate = dateOrderDate.Value;
            dateRequiredDate.Enabled = true;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Customer customer = customerController.GetCustomerById(cmbCustomerList.SelectedValue.ToString());
            int employeeID = Convert.ToInt32(cmbEmployeeList.SelectedValue);
            int shipperID = Convert.ToInt32(cmbShipperList.SelectedValue);
            Order order = new Order
            {
                CustomerID = customer.CustomerID,
                EmployeeID = employeeID,
                ShipVia = shipperID,
                OrderDate = dateOrderDate.Value.Date,
                RequiredDate = dateRequiredDate.Value.Date,
                ShipName = customer.CompanyName,
                ShipAddress = customer.Address,
                ShipCity = customer.City,
                ShipCountry = customer.Country,
                ShipRegion = customer.Region,
                ShipPostalCode = customer.PostalCode
            };
            order = orderController.AddOrder(order);
            int addedProductCount = productsInCart.Count;
            foreach (ShoppingCartAddedProduct addedProduct in productsInCart)
            {                
                Order_Detail order_Detail = new Order_Detail
                {
                    OrderID = order.OrderID,
                    ProductID = addedProduct.ProductID,
                    Quantity = Convert.ToInt16(addedProduct.Quantity),
                    UnitPrice = addedProduct.UnitPrice,
                    Discount = float.Parse(addedProduct.Discount.ToString())
                };
                orderDetailController.AddOrderDetail(order_Detail);
            }
            MessageBox.Show($"Order is placed with {addedProductCount} Products");


        }
    }
}
