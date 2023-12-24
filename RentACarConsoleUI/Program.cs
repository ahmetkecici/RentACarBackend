using Dal.Concrete.EntityFramework;
using System;

    public class Program
    {

        public static void main(string[] args)
        {



            EfCarDal carDal = new EfCarDal();
            int[] filteredBrands = {
                1, 2
            };
            var data = carDal.GetAll();
            var filteredData = data.Where(x => filteredBrands.Contains(x.BrandId));

            foreach (var car in filteredData)
            {
                Console.WriteLine(car.ModelYear);
            }


        }
    }


