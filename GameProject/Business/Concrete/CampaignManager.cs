using GameProject.Business.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class CampaignManager:ICampaignService
    {
      
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign was added: " + campaign.Name);
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign was deleted: " + campaign.Name);
        }
        public void List(List<Campaign> campaigns)
        {
            Console.WriteLine("Campaigns was listed.");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.Name);
            }
        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign was updated: " + campaign.Name);
        }
    }
}
