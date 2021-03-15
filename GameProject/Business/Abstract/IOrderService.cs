using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Abstract
{
    public interface IOrderService
    {
        public void NormalOrder(Player player, Game game);
        public void OrderWithCampaign(Player player, Game game, Campaign campaign);
    }
}
