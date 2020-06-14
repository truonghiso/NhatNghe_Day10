using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NhatNghe_Day09.Models.Service.Interfaces
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            //khai báo Map:
            CreateMap<ProductModel,Product>().ReverseMap(); //Map 2 chiều
        }

    }
}
