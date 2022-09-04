using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using pickpoint_delivery_service.Patterns;

using System.Collections.Generic;
using System.Linq;

namespace pickpoint_delivery_service.Controllers
{
    
    [Area("User")]
    public class ProductHoldersController: SearchController<Holder>
    {
        private readonly DeliveryDbContext _deliveryDbContext;
        private readonly IEntityFasade<Holder> _entityFasade;

        public ProductHoldersController(IWebHostEnvironment env, DeliveryDbContext deliveryDbContext,IEntityFasade<Holder> entityFasade)
        {
            _deliveryDbContext = deliveryDbContext;
            _entityFasade = entityFasade;
            
        }

        public IActionResult Index() => RedirectToAction("List");
        public IActionResult HoldersList() => View("HoldersList",new SearchModel<Holder>()
        {
   
            SearchResults = _deliveryDbContext.Holders.ToList()
        }) ;
        public IActionResult About( ) => View(new SearchModel<Product>()
        {

            SearchResults = _deliveryDbContext.Products.ToList()//.Where(p => _deliveryDbContext.Holders.Include(h => h.ProductsInStock).Where(h => h.HolderSerial == serialKey).FirstOrDefault().ProductsInStock.Select(pis => pis.ProductID).Contains(p.ID))
        });
        public SearchModel<Holder> Search(string SearchQuery, int? PageNumber)
        {
            var results = new SearchModel<Holder>()
            {
                SearchQuery = SearchQuery,
                PageNumber = PageNumber!=null? (int)PageNumber: 1,
                SearchOptions = _entityFasade.GetOptions(SearchQuery),
                TotalPages = _entityFasade.TotalPages(SearchQuery, 10),
                TotalResults = _entityFasade.TotalResults(SearchQuery),
                SearchResults = _entityFasade.SearchPage(SearchQuery, PageNumber != null ? (int)PageNumber : 1, 10).ToList()
            };
            return results;
        }
            
 
        public Holder CreateHolder()
        {
            var holder = new Holder() { };
            _deliveryDbContext.Holders.Add(holder);
            _deliveryDbContext.SaveChanges();
            return holder;
        }

        public Holder GetHolder(int holderId)
        {
            return _deliveryDbContext.Holders.Include(h => h.HolderOrders).Where(h => h.ID == holderId).First();
        }

         

        public int RemoveHolder(int holderId)
        {
            _deliveryDbContext.Remove(_deliveryDbContext.Holders.Find(holderId));
            return _deliveryDbContext.SaveChanges();
        }

        public int UpdateHolder(Holder holder)
        {
            var current = _deliveryDbContext.Holders.Find(holder.ID);
            foreach (var propertyInfo in holder.GetType().GetProperties().ToList())
            {
                propertyInfo.SetValue(current, propertyInfo.GetValue(holder));
            }
            return _deliveryDbContext.SaveChanges();
        }

        public override SearchModel<Holder> GetModel()
        {
            return new SearchModel<Holder>() { };
        }

        public override IEnumerable<string> GetOptions(string Query)
        {
            HashSet<string> result = new HashSet<string>();
            this._deliveryDbContext.Holders.ToList().ForEach(h => h.HolderLocation.Split(" ").ToList().ForEach(w=> result.Add(w)) );
            return result;
        }
    }
}
