using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class CustomersDAO
    {
        private static CustomersDAO instance;

        public static CustomersDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CustomersDAO();
                return instance;
            }
        }

        private CustomersDAO() { }

        //Xem
        public List<CustomersDTO> View()
        {
            List<CustomersDTO> users = new List<CustomersDTO>();
            try
            {
                string query = "select * from Customers";
                DataTable dt = DataProvider.Instance.Select(CommandType.Text, query);
                foreach (DataRow item in dt.Rows)
                {
                    string id = item["CustomerID"].ToString();
                    string cpnName = item["CompanyName"].ToString();
                    string ctcName = item["ContactName"].ToString();
                    string ctcTitle = item["ContactTitle"].ToString();
                    string addr = item["Address"].ToString();
                    string city = item["City"].ToString();
                    string region = item["Region"] == null ? null : item["Region"].ToString();
                    string posCode = item["PostalCode"] == null ? null : item["PostalCode"].ToString();
                    string country = item["Country"].ToString();
                    string phone = item["Phone"].ToString();
                    string fax = item["Fax"] == null ? null : item["Fax"].ToString();

                    CustomersDTO newU = new CustomersDTO(id, cpnName, ctcName, ctcTitle, addr, city, region, posCode, country, phone, fax);
                    users.Add(newU);
                }
                return users;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //Sua
        public bool Edit(string id,CustomersDTO cts)
        {
            List<CustomersDTO> users = new List<CustomersDTO>();
            try
            {
                string query = "UPDATE Customers SET CompanyName = @CompanyName , ContactName = @ContactName , ContactTitle = @ContactTitle , Address = @Address , City = @City , Region = @Region , PostalCode = @PostalCode , Country = @Country , Phone = @Phone , Fax = @Fax WHERE CustomerID = @oldid";
                object[] para = new object[] { cts.CompanyName , cts.ContactName , cts.ContactTitle , cts.Address , cts.City , cts.Region , cts.PostalCode , cts.Country , cts.Phone , cts.Fax , id};
                if (DataProvider.Instance.ExecuteNonQuery2(query, para) > 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DataProvider.Instance.disconnect();
            }
        }

        public bool Delete(string id)
        {
            List<CustomersDTO> users = new List<CustomersDTO>();
            try
            {
                string query = "DELETE FROM Customers WHERE CustomerID = @id";
                object[] para = new object[] { id };
                if (DataProvider.Instance.ExecuteNonQuery2(query, para) > 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DataProvider.Instance.disconnect();
            }
        }
    }
}
