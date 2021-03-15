using GameProject.Business.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class PlayerManager:IPlayerService
    {
        IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player)==true)
            {
                Console.WriteLine("Player Added : " + player.firstName);
            }
            else
            {
                Console.WriteLine("Player validation error. ");
            }
        }

        public void Delete(Player player)
        {

        }

        public void Update(Player player)
        {

        }
    }
}
