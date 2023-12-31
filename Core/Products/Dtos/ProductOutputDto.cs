﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Products.Dtos
{
    public class ProductOutputDto
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryTitle { get; set; }

        public string? Title { get; set; }

        public int CalculatedQty { get; set; }
    }
}
