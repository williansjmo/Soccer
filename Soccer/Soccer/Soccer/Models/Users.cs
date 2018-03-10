﻿namespace Soccer.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserTypeId { get; set; }
        public string Picture { get; set; }
        public string Email { get; set; }
        public string NickName { get; set; }
        public int FavoriteTeamId { get; set; }
        public int Points { get; set; }
        public Team FavoriteTeam { get; set; }
        public UserType UserType { get; set; }

    }
}
