using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;
using VehicleNamespace;

namespace VehicleApplication_Baraclan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCar_CheckedChanged(object sender, EventArgs e)
        {            
            //disabling
            txtMotorType.Hide();
            txtEngine.Hide();

            //enabling
            txtCarType.Enabled = true;
            txtPowerSource.Enabled = true;
            txtDoors.Enabled = true;
            txtTrunk.Enabled = true;
        }

        private void btnMotorcycle_CheckedChanged(object sender, EventArgs e)
        {            
            //disabling
            txtCarType.Enabled = false;
            txtPowerSource.Enabled = false;
            txtDoors.Enabled = false;
            txtTrunk.Enabled = false;

            //enabling
            txtMotorType.Show();
            txtEngine.Show();
        }

        public int catchInt(string num) 
        {
            int number;
            if (int.TryParse(num, out number)==false){
                MessageBox.Show("Invalid Integer\nPlease input a valid integer", "Invalid Integer");
                return 0;

            }
            else return number;

        }
        public double catchDouble(string num)
        {
            double number;
            if (double.TryParse(num, out number)==false){
                MessageBox.Show("Invalid Integer\nPlease input a valid integer", "Invalid Integer");
                return 0;

            }
            else return number;

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string make, model, car_type, motor_type, color, power_source;
            int doors, trunk, engine, year;
            double price;



            if (btnCar.Checked == true)
            {
                make = txtMake.Text;
                model = txtModel.Text;
                car_type = txtCarType.Text;
                color = txtColor.Text;
                power_source = txtPowerSource.Text;

                doors = catchInt(txtDoors.Text);
                trunk = catchInt(txtTrunk.Text);
                year = catchInt(txtYear.Text);

                price = catchDouble(txtPrice.Text);

                if (make == "" || model == "" || car_type == "" || color == "" || power_source == "" || txtDoors.Text == ""
                    || txtTrunk.Text == "" || txtYear.Text == "" || txtPrice.Text == "")
                {
                    MessageBox.Show("Please input Properly", "Invalid Input");
                }
                else
                {

                    Car car1 = new Car(make, model, year, car_type, power_source, color, doors, trunk, price);

                    lblNoTotal.Text = Convert.ToString(car1.getVehiclePrice());


                }

            }
            else if (btnMotorcycle.Checked == true)
            {
                make = txtMake.Text;
                model = txtModel.Text;
                motor_type = txtMotorType.Text;
                color = txtColor.Text;

                year = catchInt(txtYear.Text);
                engine = catchInt(txtEngine.Text);

                price = catchDouble(txtPrice.Text);

                if (make == "" || model == "" || motor_type == "" || color == "" || txtYear.Text == "" || txtEngine.Text == ""
                    || txtPrice.Text == "")
                {
                    MessageBox.Show("Please input Properly", "Invalid Input");
                }
                else
                {

                    Motorcycle Motor = new Motorcycle(make, model, year, motor_type, engine, color, price);

                    lblNoTotal.Text = Convert.ToString(Motor.getVehiclePrice());

                }
            }


        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string make, model, car_type, motor_type, color, power_source;
            int doors, trunk, engine, year;
            double price, payment;

            if (btnMotorcycle.Checked == true)
            {
                make = txtMake.Text;
                model = txtModel.Text;
                motor_type = txtMotorType.Text;
                color = txtColor.Text;

                year = Convert.ToInt32(txtYear.Text);
                engine = Convert.ToInt32(txtEngine.Text);
                price = Convert.ToDouble(txtPrice.Text);

                

                    Motorcycle Motor = new Motorcycle(make, model, year, motor_type, engine, color, price);
                    lblNoTotal.Text = Convert.ToString(Motor.getVehiclePrice());
                    price = Motor.getVehiclePrice();

                    Motor.setPayment(Convert.ToDouble(txtPayment.Text));

                    lblNoChange.Text = Convert.ToString(Motor.getChange(price));

                
            }
            else if (btnCar.Checked == true)
            {
                make = txtMake.Text;
                model = txtModel.Text;
                car_type = txtCarType.Text;
                color = txtColor.Text;
                power_source = txtPowerSource.Text;

                doors = Convert.ToInt32(txtDoors.Text);
                trunk = Convert.ToInt32(txtTrunk.Text);
                year = Convert.ToInt32(txtYear.Text);

                price = Convert.ToDouble(txtPrice.Text);

                


                Car car1 = new Car(make, model, year, car_type, power_source, color, doors, trunk, price);
                lblNoTotal.Text = Convert.ToString(car1.getVehiclePrice());
                price = car1.getVehiclePrice();

                car1.setPayment(Convert.ToDouble(txtPayment.Text));

                lblNoChange.Text = Convert.ToString(car1.getChange(price));

            }
        }
        

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
