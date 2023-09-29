﻿using App.Domain.Core.Product.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Product.Contract.AppServices
{
    public interface ICategoryAppService
    {
        Task<int> Add(CategoryInputDto categoryInputDto, CancellationToken cancellationToken);
    }
}
