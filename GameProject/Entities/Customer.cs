using GameProject.Abstract;
using System;

namespace GameProject.Entities
{

    public class Customer : IEntity
    {
        public int GameId { get; set; }
        public string NationalityId { get; set; }
        public string GameName { get; set; }
        public string GameSurname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

}
