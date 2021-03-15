using GameProject.Business.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    class OrderManager : IOrderService
    {
        public void NormalOrder(Player player, Game game)
        {
            Console.WriteLine("Satın alma başarılı: " + game.Name + " Tutar: " + game.Price + "TL  Keyifli oyunlar " + player.firstName + "!" );
        }

        public void OrderWithCampaign(Player player, Game game, Campaign campaign)
        {
            double orderPrice = game.Price - (game.Price * (campaign.DiscountRate / 100));
            Console.WriteLine("Tebrikler " + campaign.Name + " kampanyasından yararlandınız. Ödenecek tutar: " + orderPrice + "TL" );

        }
    }
}
