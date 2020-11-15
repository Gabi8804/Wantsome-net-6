﻿using StoreApp.BusinessLogic.BusinessEntities;
using StoreApp.DataAccess;
using StoreApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.BusinessLogic
{
    public class SpecificationsHandler
    {
        private readonly SpecsRepository<Specs> specsRepo;
        private readonly CategorySpecRepository<CategorySpecs> catSpecRepo;
        private readonly Prod_CatSpecsRepository<Prod_CatSpec> prod_catSpecsRepo;

        public SpecificationsHandler()
        {
            prod_catSpecsRepo = new Prod_CatSpecsRepository<Prod_CatSpec>();
            specsRepo = new SpecsRepository<Specs>();
            catSpecRepo = new CategorySpecRepository<CategorySpecs>();
        }

        public List<SpecificationsModel> GetSpecs(int specId)
        {
            List<CategorySpecs> categorySpecsList = catSpecRepo.ReadAllBySpecIds(specId);

            var specIds = new List<int>();
            foreach (var cs in categorySpecsList)
            {
                specIds.Add(cs.SpecId);
            }
            var specs = specsRepo.ReadByIds(specIds);

            var specList = new List<SpecificationsModel>();

            foreach (var s in specs)
            {
                specList.Add(new SpecificationsModel
                {
                    Name = s.Name,
                    SpecId = s.SpecId
                });
            }

            return specList;
        }

        public List<CategorySpecsModel> GetCatSpecs(int specId)
        {
            List<CategorySpecs> categorySpecsList = catSpecRepo.ReadAllBySpecIds(specId);

            var catSpecs = new List<CategorySpecsModel>();
            foreach (var cs in categorySpecsList)
            {
                catSpecs.Add(new CategorySpecsModel
                {
                    CategoryId = cs.CategoryId,
                    CategorySpecsId = cs.CategorySpecsId,
                    SpecId = cs.SpecId
                });
            }
            return catSpecs;
        }

        public void Create(List<Prod_CatSpecModel> prod_CatSpedList)
        {
            var specValues = new List<Prod_CatSpec>();
            foreach (var s in prod_CatSpedList)
            {
                specValues.Add(new Prod_CatSpec
                {
                    SpecValue = s.SpecValue,
                    ProductId = s.ProductId,
                    CategorySpecsId = s.CategorySpecId
                });
            }
            prod_catSpecsRepo.CreateMultiple(specValues);
        }
        public List<SpecificationsModel> GetSpecificationsByProductId(int productId)
        {

            var prodCatSpecList = prod_catSpecsRepo.GetProd_CatSpecsByProductId(productId);

            var catSpecList = catSpecRepo.GetAllByIds(prodCatSpecList.Select(x => x.CategorySpecsId));

            var specIds = catSpecList.Select(x => x.SpecId);
            List<int> specIntIds = new List<int>();
            foreach(var s in specIds)
            {
                specIntIds.Add(s);
            }
            var specList = specsRepo.ReadByIds(specIntIds);


            var joinedSpecList = from prodCatSpec in prodCatSpecList
                                 join catspec in catSpecList
                                 on prodCatSpec.CategorySpecsId equals catspec.CategorySpecsId
                                 join spec in specList
                                 on catspec.SpecId equals spec.SpecId
                                 into Specs
                                 from Spec in Specs.DefaultIfEmpty()
                                 select new
                                 {
                                     prodCatSpec,
                                     catspec,
                                     Spec
                                 };

            var specModelList = new List<SpecificationsModel>();
            foreach (var item in joinedSpecList)
            {
                specModelList.Add(new SpecificationsModel
                {
                    SpecId = item.Spec.SpecId,
                    Name = item.Spec.Name,
                    CategorySpecId = item.catspec.CategorySpecsId,
                    Prod_CatSpecId = item.prodCatSpec.Prod_CatSpecId,
                    Value = item.prodCatSpec.SpecValue
                });
            }

            return specModelList;

        }
    }
}
