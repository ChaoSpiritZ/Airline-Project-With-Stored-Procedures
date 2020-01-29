using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class LoggedInAdministratorFacade : AnonymousUserFacade, ILoggedInAdministratorFacade
    {
        public void CreateNewAirline(LoginToken<Administrator> token, AirlineCompany airline)
        {
            LoginHelper<Administrator>.CheckToken(token);
            if (_airlineDAO.GetAirlineByAirlineName(airline.AirlineName) != null)
                throw new AirlineNameAlreadyExistsException($"there is already an airline with the name '{airline.AirlineName}'");
            if (_airlineDAO.GetAirlineByUsername(airline.UserName) != null || _customerDAO.GetCustomerByUsername(airline.UserName) != null || airline.UserName == "admin")
                throw new UsernameAlreadyExistsException($"Username '{airline.UserName}' is already taken!");
            _airlineDAO.Add(airline);
        }

        public void CreateNewCustomer(LoginToken<Administrator> token, Customer customer)
        {
            throw new NotImplementedException();
        }

        public void RemoveAirline(LoginToken<Administrator> token, AirlineCompany airline)
        {
            throw new NotImplementedException();
        }

        public void RemoveCustomer(LoginToken<Administrator> token, Customer customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateAirlineDetails(LoginToken<Administrator> token, AirlineCompany airline)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerDetails(LoginToken<Administrator> token, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
