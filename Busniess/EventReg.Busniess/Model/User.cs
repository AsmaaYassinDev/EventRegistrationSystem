﻿using EventReg.Common.Contracts;

namespace EventReg.Busniess.Model
{
    public class User:IUser
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
    }
}
