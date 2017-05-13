using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShop.Model.Models;
using WebShop.Web.Models;

namespace WebShop.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdatePostCategory(this PostCategory postCategory, PostCategoryViewModel postCategoryVM)
        {

            postCategory.ID = postCategoryVM.ID;
            postCategory.Name = postCategoryVM.Name;
            postCategory.Alias = postCategoryVM.Alias;
            postCategory.Description = postCategoryVM.Description;
            postCategory.ParentID = postCategoryVM.ParentID;
            postCategory.DisplayOrder = postCategoryVM.DisplayOrder;
            postCategory.Image = postCategoryVM.Image;
            postCategory.HomeFlag = postCategoryVM.HomeFlag;
            postCategory.Status = postCategoryVM.Status;

            postCategory.CreatedDate = postCategoryVM.CreatedDate;
            postCategory.CreatedBy = postCategoryVM.CreatedBy;
            postCategory.UpdatedDate = postCategoryVM.UpdatedDate;
            postCategory.UpdatedBy = postCategoryVM.UpdatedBy;
            postCategory.MetaKeyword = postCategoryVM.MetaKeyword;
            postCategory.MetaDescription = postCategoryVM.MetaDescription;

        }
        public static void UpdatePost(this Post post, PostViewModel postPV)
        {

            post.ID = postPV.ID;
            post.Name = postPV.Name;
            post.Alias = postPV.Alias;
            post.Description = postPV.Description;

            post.CategoryID = postPV.CategoryID;
            post.DisplayOrder = postPV.DisplayOrder;
            post.Image = postPV.Image;
            post.HomeFlag = postPV.HomeFlag;
            post.Content = postPV.Content;
            post.ViewCount = postPV.ViewCount;
            post.ParentID = postPV.ParentID;
            //postPV. = post.Status;
            post.CreatedDate = postPV.CreatedDate;
            post.CreatedBy = postPV.CreatedBy;
            post.UpdatedDate = postPV.UpdatedDate;
            post.UpdatedBy = postPV.UpdatedBy;
            post.MetaKeyword = postPV.MetaKeyword;
            post.MetaDescription = postPV.MetaDescription;
            

        }
    }
}