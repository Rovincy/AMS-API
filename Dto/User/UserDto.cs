﻿namespace DCI_TSP_API.Dto.User
{
    public class UserDto
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public string? Role { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        //public string? Gender { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
