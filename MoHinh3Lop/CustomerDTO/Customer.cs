using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDTO
{
    class Customer
    {
        private string _CustomerID;
        private string _CompanyName;
        private string _ContactName;
        private string _ContactTitle;
        private string _Address;
        private string _City;
        private string _Region;
        private string _PostalCode;
        private string _Country;
        private string _Phone;
        private string _Fax;

        public string CustomerID
        {
            get
            {
                return _CustomerID;
            }

            set
            {
                _CustomerID = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return _CompanyName;
            }

            set
            {
                _CompanyName = value;
            }
        }

        public string ContactName
        {
            get
            {
                return _ContactName;
            }

            set
            {
                _ContactName = value;
            }
        }

        public string ContactTitle
        {
            get
            {
                return _ContactTitle;
            }

            set
            {
                _ContactTitle = value;
            }
        }

        public string Address
        {
            get
            {
                return _Address;
            }

            set
            {
                _Address = value;
            }
        }

        public string City
        {
            get
            {
                return _City;
            }

            set
            {
                _City = value;
            }
        }

        public string Region
        {
            get
            {
                return _Region;
            }

            set
            {
                _Region = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return _PostalCode;
            }

            set
            {
                _PostalCode = value;
            }
        }

        public string Country
        {
            get
            {
                return _Country;
            }

            set
            {
                _Country = value;
            }
        }

        public string Phone
        {
            get
            {
                return _Phone;
            }

            set
            {
                _Phone = value;
            }
        }

        public string Fax
        {
            get
            {
                return _Fax;
            }

            set
            {
                _Fax = value;
            }
        }
        //hàm dựng có tham số
        public Customer(string customerId, string companyName, string contactname, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax)
        {
            this.customerId = customerId;
            this.companyName = companyName;
            this.contactName = contactName;
            this.contactTitle = contactTitle;
            this.address = adddress;
            this.city = city;
            this.region = region;
            this.postalCode = postalCode;
            this.country = country;
            this.phone = phone;
            this.fax = fax;
        }
    }
}
