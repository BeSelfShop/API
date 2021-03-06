﻿using Microsoft.AspNetCore.Identity;


namespace PrisonBack.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Forname { get; set; }
        public long? FacebookId { get; set; }
        public string PictureUrl { get; set; }

    }
}
