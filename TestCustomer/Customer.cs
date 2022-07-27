using System;

namespace TestCustomer
{
    public class Customer 
    {
        protected int customer_id;
        protected string customer_name;
        protected string customer_address;
        protected string phone;
        protected string city;
        protected string state;
        protected int pincode;
        protected string emailid; 
        
        public int Cust_id
        {
            set
            {
                customer_id = value;
            }
            get
            {
                return customer_id;
            }
        }

        public string Cust_name
        { 
            set
            {
                customer_name = value;
            }
            get
            {
                return customer_name;
            }
        }

        public string Cust_address
        {
            set
            {
                customer_address = value;
            }
            get
            {
                return customer_address;
            }
        }

        public string Cust_phone
        {
            set
            {
                phone = value;
            }
            get
            {
                return phone;
            }
        }

        public string Cust_city
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }

        public string Cust_state
        {
            set
            {
                state = value;
            }
            get
            {
                return state;
            }
        }
        public int Cust_pincode
        {
            set
            {
                pincode = value;
            }
            get
            {
                return pincode;
            }
        }

        public string Cust_email
        {
            set
            {
                emailid = value;
            }
            get
            {
                return emailid;
            }
        }



    }

}
