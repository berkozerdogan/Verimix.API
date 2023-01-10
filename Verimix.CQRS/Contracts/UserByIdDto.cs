﻿namespace Verimix.CQRS.Contracts
{
    public class UserByIdDto
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}