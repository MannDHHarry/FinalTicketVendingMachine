using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DestinationDAL;
namespace DestinationBLL
{
    public class BLL
    {
        DAL dal = new DAL();
        public List<string> GetDestinations()
        {
            return dal.GetAllDestinations();
        }
    }
}
