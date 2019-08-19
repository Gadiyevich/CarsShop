using CarsShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsShop
{
    public partial class CarsShop : Form
    {
        private Store store = new Store();
        private List<Car> shoppingCartData = new List<Car>();
        private decimal storeProfit = 0;

        BindingSource cartListBinding = new BindingSource();
        BindingSource shoppingCartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();

        public CarsShop()
        {
            InitializeComponent();
            SetupData();

            cartListBinding.DataSource = store.Cars;
            carsListbox.DataSource = cartListBinding;

            carsListbox.DisplayMember = "Display";
            carsListbox.ValueMember = "Display";


            shoppingCartBinding.DataSource = shoppingCartData;
            shoppingCartListbox.DataSource = shoppingCartBinding;


            shoppingCartListbox.DisplayMember = "Display";
            shoppingCartListbox.ValueMember = "Display";


            vendorsBinding.DataSource = store.Vendors;
            vendorsListbox.DataSource = vendorsBinding;

            vendorsListbox.DisplayMember = "Display";
            vendorsListbox.ValueMember = "Display";
        }


        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Oliver", LastName = "Harris" });
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });


            store.Cars.Add(new Car
            {
                Name = "Nissan Altima",
                Description = "HORSEPOWER: 300, SEATING: 5",
                Price = 36.000M,
                Owner = store.Vendors[1]
            });

            store.Cars.Add(new Car
            {
                Name = "Toyota Corolla",
                Description = "HORSEPOWER: 250, SEATING: 5",
                Price = 19.600M,
                Owner = store.Vendors[0]
            });

            store.Cars.Add(new Car
            {
                Name = "Mitsubishi Outlander PHEV",
                Description = "HORSEPOWER: 340, SEATING: 5",
                Price = 35.700M,
                Owner = store.Vendors[1]
            });

            store.Cars.Add(new Car
            {
                Name = "BMW X5",
                Description = "HORSEPOWER: 400, SEATING: 6",
                Price = 61.700M,
                Owner = store.Vendors[1]
            });

            store.Cars.Add(new Car
            {
                Name = "Porsche Panamera 4S",
                Description = "HORSEPOWER: 500, SEATING: 5",
                Price = 81.600M,
                Owner = store.Vendors[1]
            });
            store.Cars.Add(new Car
            {
                Name = "Audi R8",
                Description = "HORSEPOWER: 350, SEATING: 5",
                Price = 40.500M,
                Owner = store.Vendors[0]
            });
            store.Cars.Add(new Car
            {
                Name = "Mercedes-Benz AMG GT",
                Description = "HORSEPOWER: 577, SEATING: 6",
                Price = 189.800M,
                Owner = store.Vendors[0]
            });

            store.Cars.Add(new Car
            {
                Name = "Hyundai Creta",
                Description = "HORSEPOWER: 400, SEATING: 7",
                Price = 34.000M,
                Owner = store.Vendors[1]
            });

            store.Cars.Add(new Car
            {
                Name = "Jeep Compass",
                Description = "HORSEPOWER: 408, SEATING: 7",
                Price = 56.000M,
                Owner = store.Vendors[0]
            });

            store.Cars.Add(new Car
            {
                Name = "Lamborghini Huracan",
                Description = "HORSEPOWER: 600, SEATING: 5",
                Price = 250.000M,
                Owner = store.Vendors[0]
            });


        }

        private void PurchaseItem_Click(object sender, EventArgs e)
        {
            try
            {
                Car selectedCar = (Car)carsListbox.SelectedItem;


                shoppingCartData.Add(selectedCar);

                shoppingCartBinding.ResetBindings(false);


            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong! Please repeat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void MakePurchase_Click(object sender, EventArgs e)
        {

            try
            {

                foreach (Car item in shoppingCartData)
                {
                    item.Sold = true;
                    cartListBinding.DataSource = store.Cars.Where(x => x.Sold == false).ToList();

                    item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                    storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;

                    storeProfitValue.Text = string.Format("${0}", storeProfit);
                }

                shoppingCartData.Clear();
                shoppingCartBinding.ResetBindings(false);
                vendorsBinding.ResetBindings(false);



            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong! Please repeat","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            
        }

        private void DeleteFromShopCart_Click(object sender, EventArgs e)
        {
           Car selected= (Car)shoppingCartListbox.SelectedItem;
            shoppingCartData.Remove(selected);
            shoppingCartBinding.ResetBindings(false);

        }
    }
}
