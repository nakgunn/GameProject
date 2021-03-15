using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
    public interface IPlayerService
    {
        public void Add(Player player);
        public void Delete(Player player);
        public void Update(Player player);
    }
}
