﻿namespace SushiShopAngular.Server.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Sushi> Sushis { get; } = [];
        public int IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}
