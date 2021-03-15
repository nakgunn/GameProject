using GameProject.Adapters;
using GameProject.Business.Abstract;
using GameProject.Business.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Campaign CRUD
            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign1 = new Campaign() { Id = "1", Name = "Fırsat20", DiscountRate = 20 };
            Campaign campaign2 = new Campaign() { Id = "1", Name = "Fırsat50", DiscountRate = 50 };
            List<Campaign> campaigns = new List<Campaign>() { campaign1, campaign2 };

            campaignManager.Add(campaign1);
            campaignManager.Delete(campaign2);
            campaignManager.List(campaigns);
            campaignManager.Update(campaign1);

            Player player1 = new Player() { firstName = "Necati", lastName = "Akgün", userName = "nakgunn", dateYear = 1997, nationalityId = 5427934454 }; //fake data 

            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            playerManager.Add(player1);

            Game game1 = new Game() { Id = "1", Name = "Counter Strike-Global Offensive", Genre = "FPS", Price = 100 };

            IOrderService ordermanager = new OrderManager();
            ordermanager.NormalOrder(player1, game1);
            ordermanager.OrderWithCampaign(player1, game1, campaign1);
            








        }
    }
}
