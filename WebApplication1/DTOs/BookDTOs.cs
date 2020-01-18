using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DTOs
{
    public class BooKAddDto
    {
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
    public class BookUpdateDto : BooKAddDto
    {
        [Required]
        public Guid Id { get; set; }
    }
    public class BookGetDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }
    }
}

