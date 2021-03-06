﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDTO
{
    public class user
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
        private string id;
        private string cpnName;
        private string ctcName;
        private string ctcTitle;
        private string addr;
        private string posCode;

        public user(string id, string cpnName, string ctcName, string ctcTitle, string addr, string city, string region, string posCode, string country, string phone, string fax)
        {
            this.id = id;
            this.cpnName = cpnName;
            this.ctcName = ctcName;
            this.ctcTitle = ctcTitle;
            this.addr = addr;
            City = city;
            Region = region;
            this.posCode = posCode;
            Country = country;
            Phone = phone;
            Fax = fax;
        }

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
        
    }
}
