using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaniaManager : ICampaniaService
    {
        public void Add(Campania campania)
        {
            Console.WriteLine(campania.CampaniaName + " "+ "Added");
        }

        public void Detele(Campania campania)
        {
            Console.WriteLine(campania.CampaniaName + "Deleted");
        }

        public void Update(Campania campania)
        {
            Console.WriteLine(campania.CampaniaName + "Updated");
        }
    }
}
