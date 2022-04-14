﻿using System.ComponentModel.DataAnnotations;  
namespace RestAPI_Project_BookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }   
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; }= DateTime.Now;


    }
}
