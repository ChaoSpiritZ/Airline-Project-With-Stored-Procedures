using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineProject
{
    class LoggedInAirlineFacade : AnonymousUserFacade, ILoggedInAirlineFacade
    {
        public void CancelFlight(LoginToken<AirlineCompany> token, Flight flight)
        {
            throw new NotImplementedException();
        }

        public void ChangeMyPassword(LoginToken<AirlineCompany> token, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public void CreateFlight(LoginToken<AirlineCompany> token, Flight flight)
        {
            throw new NotImplementedException();
        }

        public IList<Flight> GetAllFlights(LoginToken<AirlineCompany> token)
        {
            throw new NotImplementedException();
        }

        public IList<Ticket> GetAllTickets(LoginToken<AirlineCompany> token)
        {
            throw new NotImplementedException();
        }

        public void ModifyAirlineDetails(LoginToken<AirlineCompany> token, AirlineCompany airline)
        {
            throw new NotImplementedException();
        }

        public void UpdateFlight(LoginToken<AirlineCompany> token, Flight flight)
        {
            throw new NotImplementedException();
        }
    }
}
