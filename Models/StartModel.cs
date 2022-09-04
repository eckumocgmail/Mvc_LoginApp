using pickpoint_delivery_service;

using System.Collections.Generic;

public class StartModel
{
    public List<Product> Cards = new List<Product>();
    public IDictionary<string, IDictionary<string, string>> Links = new Dictionary<string, IDictionary<string, string>>();
}