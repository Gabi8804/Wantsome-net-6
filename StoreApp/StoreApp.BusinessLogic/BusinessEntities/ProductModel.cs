using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.BusinessLogic.BusinessEntities
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int BrandCategoryId { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string Image { get; set; }

        public BrandModel Brand { get; set; }
        public CategoryModel Category { get; set; }
        public List<SpecificationsModel> Specifications { get; set; }

    }
}
