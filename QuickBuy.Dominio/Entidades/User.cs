﻿using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Order> Orders { get; set; } 
    }
}
