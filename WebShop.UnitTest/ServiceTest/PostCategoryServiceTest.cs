using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Data.Infrastructure;
using WebShop.Data.Repositories;
using WebShop.Model.Models;
using WebShop.Service;

namespace WebShop.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<PostCategory> _listCategory;
        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory() {ID = 1,Name = "MD1",Status = true }//,
                //new PostCategory() {ID = 2,Name = "MD2",Status = true },
                //new PostCategory() {ID = 3,Name = "MD3",Status = true }
            };

        }
        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //set method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategory);

            //call action
            var result = _categoryService.GetAll() as List<PostCategory>;
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }
        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory category = new PostCategory();
            int id = 1;
            category.Name = "test";
            category.Alias = "test";
            category.Status = true;
            //set up add and return this category 
            _mockRepository.Setup(m => m.Add(category)).Returns((PostCategory p) => { p.ID = 1; return p; });

            // call method
            var result =  _categoryService.Add(category);
            //check vlue
            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.ID);
            
        }
    }
}
