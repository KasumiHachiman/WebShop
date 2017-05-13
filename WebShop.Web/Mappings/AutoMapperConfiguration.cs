using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop.Model.Models;
using WebShop.Web.Models;

namespace WebShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configuration()
        {
            Mapper.Initialize(cfg =>
            {
                
                cfg.CreateMap<Post, PostViewModel>();
                //cfg.AddProfile<FooProfile>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<PostTag, PostTagViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();
            });
            
            //CreateMap<Post, PostViewModel>();
            //CreateMap<PostTag, PostTagViewModel>();
            //CreateMap<Tag, TagViewModel>();
            //CreateMap<PostCategory, PostCategoryViewModel>();
        }
    }
}