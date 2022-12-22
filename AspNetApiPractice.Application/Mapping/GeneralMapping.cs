using AspNetApiPractice.Domain.Dtos;
using AspNetApiPractice.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Application.Mapping
{
    public class GeneralMapping :Profile
    {

        public GeneralMapping() {
            CreateMap<ProductDto, Product>().ReverseMap();
        }

    }
}
