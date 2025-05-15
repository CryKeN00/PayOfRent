using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayOfRent.Services
{
    public class RentCalculator
    {
        public decimal Calculate(
    decimal gorVoda, decimal holVoda, decimal gas, decimal elecrich,
    decimal gorVodaTariff, decimal holVodaTariff, decimal gasTariff, decimal elecrichTariff,
    decimal capRepair, decimal trash)
        {
            return (gorVoda * gorVodaTariff) +
                   (holVoda * holVodaTariff) +
                   (gas * gasTariff) +
                   (elecrich * elecrichTariff) +
                   capRepair + trash;
        }
    }
}
