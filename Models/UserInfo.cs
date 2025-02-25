﻿using System;
namespace HippoAPIAssignment.Models
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public Guid guid { get; set; }  
        public string? DisplayName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
