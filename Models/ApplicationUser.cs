  
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<TodoItem> Items { get; set; }
    }
}