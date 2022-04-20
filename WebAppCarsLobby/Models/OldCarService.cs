using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCarsLobby.Models
{
    public class OldCarService
    {

        static List<string[]> carsStorage;
        static List<string> brandsStorage;

        public OldCarService()
        {
            if (carsStorage == null)
            {
                carsStorage = new List<string[]>();
                string[] saab = new string[] { "SAAB", "900s", "8500" };
                string[] volvo = new string[] { "Volvo", "740 GLT", "4600" };
                string[] bmw = new string[] { "BMW", "M3", "14900" };
                carsStorage.Add(saab);
                carsStorage.Add(volvo);
                carsStorage.Add(bmw);

                brandsStorage = new List<string>();
                brandsStorage.Add("SAAB");
                brandsStorage.Add("Volvo");
                brandsStorage.Add("BMW");
                brandsStorage.Add("Opel");
                brandsStorage.Add("VW");
                brandsStorage.Add("Mazda");

            }
        }

        public List<string[]> GetCars()
        {
            return carsStorage;
        }

        public List<string> Getbrands()
        {
            return brandsStorage;
        }

        public void Create(string brand, string model, string price)
        {
            if (string.IsNullOrEmpty(brand))
            {
                throw new ArgumentException($"'{nameof(brand)}' cannot be null or empty.", nameof(brand));
            }

            if (string.IsNullOrEmpty(model))
            {
                throw new ArgumentException($"'{nameof(model)}' cannot be null or empty.", nameof(model));
            }

            if (string.IsNullOrEmpty(price))
            {
                throw new ArgumentException($"'{nameof(price)}' cannot be null or empty.", nameof(price));
            }

            if ( ! brandsStorage.Contains(brand))
            {
                brandsStorage.Add(brand);
            }

            carsStorage.Add(new string[] { brand, model, price });
        }
    }
}
