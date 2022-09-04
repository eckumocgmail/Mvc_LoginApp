using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using pickpoint_delivery_service.Patterns;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pickpoint_delivery_service.Controllers
{
    
    [Area("User")]
    public class SearchProductsController: AbstractOrderCheckoutController<Product>
    {
        private readonly IUserContext _user;
        private readonly IEntityFasade<Product> products;
        private readonly IEntityFasade<ProductImage> images;

        public SearchProductsController(
            DeliveryDbContext deliveryDbContext, 
            IWebHostEnvironment env,
            IUserContext user,

            IEntityFasade<Product> products, 
            IEntityFasade<ProductImage> images) : base(deliveryDbContext, env, products, images)
        {
            _user = user;
            this.products = products;
            this.images = images;
        }



        public override IActionResult Index() 
            => Redirect("/User/SearchProducts/ProductList");



        public IActionResult OrderCheckout()
            => Redirect("/User/ExchangeOrder/ExchangeCheckout");


        [HttpGet]
        public IActionResult ProductList( [FromServices ]DeliveryDbContext context )
        {
            var model = GetModel();

            try
            {
                if (model != null)
                {
                    model.SearchResults = this.products.Search(model != null ? model.SearchQuery : "").ToList();
                    foreach (Product p in model.SearchResults)
                        p.ProductImages = this.images.GetAll().Where(i => i.ProductID == p.ID).ToList();
                }
            }catch(Exception ex)
            {
                return View("Exception", ex);
            }
            return View("ProductList", model);
        }

        [HttpPost]
        public IActionResult ProductList([FromServices] DeliveryDbContext context, OrderCheckoutModel<Product> returned)
        {
            var model = GetModel();
            model.SearchResults = this.products.Search(model.SearchQuery= returned.SearchQuery).ToList();
            foreach (Product p in model.SearchResults)
                p.ProductImages = this.images.GetAll().Where(i => i.ProductID == p.ID).ToList();
            return View("ProductList", model);
        }
        public IActionResult RemoveFromOrder(int ID)
        {
            GetModel().Selected.Remove(GetModel().Selected.Where(p => p.ID == ID).First());
            return View("ProductList", GetModel());
        }
        public IActionResult PushToOrder(int ID)
        {
            GetModel().Selected.Add(GetModel().SearchResults.Where(r => r.ID == ID).FirstOrDefault());
            return View("ProductList", GetModel());
        }
        public async Task Image([FromServices] DeliveryDbContext _deliveryDbContext, int id)
        {


            var img = _deliveryDbContext.ProductImages.Find(id);
            if (img != null)
            {
                //img.ImageData = System.IO.File.ReadAllBytes(@"D:\Projects-WebApi\pickpoint-delivery-service\Resources\phones-img\motorola-atrix-4g.0.jpg");
                Response.ContentType = "image/jpeg";

                await Response.Body.WriteAsync(img.ImageData, 0, img.ImageData.Length);
            }

        }
        public override OrderCheckoutModel<Product> GetModel()
        {
            var res = this.products.Search("");
            string key = GetType().FullName;
            if (_user.GetSession()!=null&&_user.GetSession().ContainsKey(key)==false)
            {
                _user.GetSession()[key] = new OrderCheckoutModel<Product>()
                {
                    SearchResults = res.ToList()
                };

            }
            foreach(Product p in res)            
                p.ProductImages = this.images.GetAll().Where(i => i.ProductID == p.ID).ToList();
            
            return _user.GetSession()==null?null:(OrderCheckoutModel<Product>)_user.GetSession()[key];
        }

        public override IEnumerable<string> GetOptions(string Query)
        {
            throw new System.NotImplementedException();
        }


    }
}
