using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ICampaniaService
    {
        void Add(Campania campania);
        void Update(Campania campania);
        void Detele(Campania Campania);
    }
}
