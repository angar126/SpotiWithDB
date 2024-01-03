using System;
using System.Collections.Generic;

#nullable disable

namespace SpotiAPI.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int? UserType { get; set; }
    }
}
