using Microsoft.EntityFrameworkCore;
using pickpoint_delivery_service;
using pickpoint_delivery_service.Delivery;
using pickpoint_delivery_service.Patterns;
using static System.Console;
using static Newtonsoft.Json.JsonConvert;
using static pickpoint_delivery_service.CustomerContext;
using static pickpoint_delivery_service.CustomerContext;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static System.Console;
using static Newtonsoft.Json.JsonConvert;
using Newtonsoft.Json.Linq;
using static pickpoint_delivery_service.CustomerContext;
using Microsoft.AspNetCore.Mvc;
using pickpoint_delivery_service.Patterns;
using pickpoint_delivery_service.Controllers;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using static Newtonsoft.Json.JsonConvert;
using pickpoint_delivery_service.Delivery;
using System.Collections.Concurrent;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace pickpoint_delivery_service.Patterns
{

    




    public class UnitOfWork 
    {
        private readonly IEntityFasade<Product> Products;
        private readonly IEntityFasade<Holder> Holders;
        private readonly IEntityFasade<Order> Orders;
        private readonly IEntityFasade<OrderItem> OrderItems;
        private readonly IEntityFasade<ProductImage> ProductImages;

        public UnitOfWork(IEntityFasade<Product> products, IEntityFasade<Holder> holders, IEntityFasade<Order> orders, IEntityFasade<OrderItem> orderItems, IEntityFasade<ProductImage> productImages)
        {
            Products = products;
            Holders = holders;
            Orders = orders;
            OrderItems = orderItems;
            ProductImages = productImages;
        }


      
    }
       
}

namespace pickpoint_delivery_service.Patterns
{
    public interface IEntitySearch<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetSearchResults(string query);
        IEnumerable<TEntity> GetSearchResultsByPage(string query, int page, int size);
        IEnumerable<object> SearchInProperties(string query, string[] properties);
        IEnumerable<object> SearchInPropertiesByPage(string query, string[] properties, int page, int size);
        IEnumerable<object> SearchInPropertiesAndSelecColumns(string query, string[] properties, string[] columns, int page, int size);
    }


    public interface IEntityFasade<TEntity> where TEntity : class
    {
        int Create(params TEntity[] items);
        IEnumerable<TEntity> Get(params int[] ids);
        IEnumerable<TEntity> GetAll();
        IEnumerable<string> GetOptions(string searchQuery);
        IEnumerable<TEntity> GetPage(int page, int size);
        IEnumerable<TEntity> GetPage(int[] ids, int page, int size);
        int Remove(params int[] ids);
        IEnumerable<TEntity> Search(string query);
        int TotalPages(string searchQuery, int v);
        IEnumerable<object> SearchColumnsInPropertiesPage(string query, string[] properties, string[] columns, int page, int size);
        int TotalResults(string searchQuery);
        IEnumerable<object> SearchInProperties(string query, string[] properties);
        IEnumerable<object> SearchInPropertiesPage(string query, string[] properties, int page, int size);
        IEnumerable<TEntity> SearchPage(string query, int page, int size);
        int Update(params TEntity[] items);
    }
}







public class EntityFasade<TEntity> : IEntityFasade<TEntity> where TEntity : class
{

    private DbContext _context;
    private DbSet<TEntity> GetDbSet() => _context.Set<TEntity>();

    public EntityFasade(DbContext context)
    {
        _context = context;
    }

    public int Create(params TEntity[] items)
    {
        foreach (var item in items)
        {
            _context.Add(item);
        }
        return _context.SaveChanges();
    }

    public IEnumerable<TEntity> Get(params int[] ids)
        => GetDbSet().Where(item => ids.Contains(int.Parse(item.GetType().GetProperty("ID").ToString())));

    public IEnumerable<TEntity> GetPage(int[] ids, int page, int size)
        => GetDbSet().Where(item => ids.Contains(int.Parse(item.GetType().GetProperty("ID").ToString()))).Skip((page - 1) * size).Take(size);

    public IEnumerable<TEntity> GetAll() => GetDbSet();

    public IEnumerable<TEntity> GetPage(int page, int size) => GetDbSet().Skip((page - 1) * size).Take(size);

    public int Remove(params int[] ids)
    {
        Get(ids).ToList().ForEach(item => _context.Remove(item));
        return _context.SaveChanges();
    }

    public int Update(params TEntity[] items)
    {
        foreach (var item in items)
            _context.Update(item);
        return _context.SaveChanges();
    }

    

    //TODO: нужно реализовать разбаение по словам
    public IEnumerable<TEntity> Search(string query)
    {
        
        List<TEntity> result = new List<TEntity>();
        try
        {
            var set = GetDbSet();
            set.ToList().ForEach(item => {
                if (SerializeObject(item).ContainsAnyWord(query))
                
                    result.Add(item);
                
            });
        }
        catch (Exception ex)
        {

        }

        return result;
    }


    public IEnumerable<TEntity> SearchPage(string query, int page, int size)
    {
        List<TEntity> result = new List<TEntity>();

        GetDbSet().ToList().ForEach(item => {
            if (String.IsNullOrEmpty(query) || SerializeObject(item).Contains(query))
            {
                result.Add(item);
            }
        });

        WriteLine(SerializeObject(result.Skip((page - 1) * size).Take(size).ToArray()));
        return result.Skip((page - 1) * size).Take(size).ToArray();
    }

    public IEnumerable<object> SearchColumnsInPropertiesPage(string query, string[] properties, string[] columns, int page, int size)
        => SearchInPropertiesPage(query, properties, page, size).Select(next => next.SelectProperties(columns));





    public IEnumerable<object> SearchInPropertiesPage(string query, string[] properties, int page, int size)
        => GetDbSet().Select(item => item.ToDictionary().Where(kv => properties.Contains(kv.Key))).Skip((page - 1) * size).Take(size);

    public IEnumerable<object> SearchInProperties(string query, string[] properties)
        => GetDbSet().Select(item => item.ToDictionary()).Where(dic => SerializeObject(dic.Values).ToLower().Contains(query.ToLower()));

    public int TotalPages(string query, int size)
    {
        List<TEntity> result = new List<TEntity>();
        GetDbSet().ToList().ForEach(item => {
            if (String.IsNullOrEmpty(query) || SerializeObject(item).Contains(query))
            {
                result.Add(item);
            }
        });
        return 1 + (int)Math.Floor((decimal)result.Count() / size);
    }

    public int TotalResults(string query)
    {
        List<TEntity> result = new List<TEntity>();
        GetDbSet().ToList().ForEach(item => {
            if (String.IsNullOrEmpty(query) || SerializeObject(item).Contains(query))
            {
                result.Add(item);
            }
        });
        return result.Count();
    }

    public IEnumerable<string> GetOptions(string query)
    {
        HashSet<string> result = new HashSet<string>();
        GetDbSet().ToList().ForEach(item => {

            GetKeywords(item).ToList().ForEach(i => result.Add(i));

        });
        return result;
    }

    private IEnumerable<string> GetKeywords(TEntity item)
    {

        return new StupidKeywordsParserService().ParseKeywords(SerializeObject(item)).Keys;
    }
}
public static class StringExtensinos
{
    public static bool ContainsAnyWord(this string text, string query)
    {
        if (query == null || String.IsNullOrWhiteSpace(query))
            return true;
        foreach (var word in text.ToLower().SplitWords().Where(w => String.IsNullOrWhiteSpace(w) == false))
        {
            foreach (var q in query.ToLower().SplitWords())
            {
                if (word == q)
                    return true;
            }
        }
        return false;


    }
}