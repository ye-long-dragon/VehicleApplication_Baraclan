using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApplication_Baraclan
{
    public partial class Component1 : Component
    {
        public Component1()
        {
            InitializeComponent();
        }

        public Component1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

namespace VehicleNamespace
{

    abstract class Vehicle
    {
        private string make;
        private string model;
        private int year;
        private string color;

        protected double price;
        protected double discounted_price;
        protected double payment_amount;
        protected double change;

        protected Vehicle(string make, string model, int year, string color, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            this.price = price;
        }

        public abstract double getVehiclePrice();

        public abstract void setPayment(double amount);

        public abstract double getChange(double amount);

    }


    class Car : Vehicle
    {
        private string car_type;
        private string power_source;
        private int doors;
        private int trunk_capacity;

        public Car(string make, string model, int year, string car_type, string power_source, string color, int doors, int trunk_capacity, double price) : base(make, model, year, color, price)
        { 
            this.car_type = car_type;
            this.power_source = power_source;
            this.doors = doors;
            this.trunk_capacity = trunk_capacity;
        }

        public override double getVehiclePrice() 
        {
            return discounted_price = price  - (price * .03);

        }

        public override void setPayment(double amount)
        { 
            payment_amount = amount;
        }

        public override double getChange(double amount)
        {
            return change = payment_amount-amount;
        }


       
        }
    class Motorcycle : Vehicle
    {

        private string motor_type;
        private int engine_displacement;

        public Motorcycle(string make, string model, int year, string motor_type, int engine_displacement, string color, double price) : base(make, model, year, color, price)
        {
            this.motor_type = motor_type;
            this.engine_displacement = engine_displacement;
        }

        public override double getVehiclePrice()
        {
            return discounted_price = price - (price * .02);

        }

        public override void setPayment(double amount)
        {
            payment_amount = amount;
        }

        public override double getChange(double amount)
        {
           return  change = payment_amount - amount;
        }
    }
}


namespace UserAccountNamespace
{

    abstract class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string full_name, string user_name, string user_password)
        {
            this.full_name = full_name;
            this.user_name = user_name;
            this.user_password = user_password;
        }

        public abstract bool validateLogin(string user_name, string user_password);

        public abstract string getFullName();
    }


    class SalesPerson : UserAccount
    {
        private string department;

        public SalesPerson(string full_name, string department, string user_name, string user_password) : base(full_name, user_name, user_password)
        {
            this.department = department;
        }

        public override bool validateLogin(string user_name, string user_password)
        {
            if (user_name != this.user_name && user_password != this.user_password) return false;
            else return true;
        }

        public override string getFullName()
        {
            return "Vince Lawrence Baraclan";
        }
    }
}