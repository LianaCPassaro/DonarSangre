using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonarSangre
{
    class Program
    {
        static void Main(string[] args)
        {

            using (ContaConmigoEntities1 db = new ContaConmigoEntities1())
            {
                var lst = db.Province;
                foreach (var oProvince in lst)
                {
                    Console.WriteLine(oProvince.ProvinceDescription);

                }
                //alta
                Request_Donor donor = new Request_Donor();
                donor.Name_Request_Don = "Liana";
                donor.Last_Name_Request_Don = "Passaro";
                donor.ZipCode = 2000;
                donor.CityId = 20949;
                donor.Last_Date_Replacement = '2019-04-30';
                donor.AmountDonor = 8;
                donor.InstitutionId = 1;
                donor.GroupId = 1;
                donor.FactorId = 1;

                db.Request_Donor.Add(donor);
                db.SaveChanges();
                //modificar
                Request_Donor donor1 = db.Request_Donor.Where(x=> x.Last_Name_Request_Don =='Passaro').First();
                donor1.Name_Request_Don = "Liana Carla";
                db.Entry(donor1).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                //eliminar
                Request_Donor donor2 = db.Request_Donor.Find(2);
                db.Request_Donor.Remove(donor2);
                db.SaveChanges();
            }
        }
    }
}   

