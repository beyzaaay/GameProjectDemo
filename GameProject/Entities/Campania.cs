using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campania:IEntity
    {
        public int CampaniaId { get; set; }
        public string CampaniaName { get; set; }
        public decimal DiscountRate { get; internal set; }
    }
}
