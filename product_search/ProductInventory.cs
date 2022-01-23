using System;
using System.Collections.Generic;

public class ProductInventory
{
    private const string NAME = "NAME";
    private const string COUNTRY = "COUNTRY";
    private string compundKey;
    private Dictionary<String, int> indexedProducs = new Dictionary<string, int>();

    public void Load(List<Product> products)
    {
        if (products != null)
        {
            foreach (Product p in products)
            {
                AddOrUpdateProduct(COUNTRY, p.Country, p.Quantity);
                AddOrUpdateProduct(NAME, p.Name, p.Quantity);
            }
        }
    }

    private string generateCounpoundkey(string fieldName, string fieldValue)
    {
        return fieldName + "-" + fieldValue.ToUpper();
    }

    private void AddOrUpdateProduct(string fieldName, string fieldValue, int quantity)
    {
        compundKey = generateCounpoundkey(fieldName, fieldValue);
        if (indexedProducs.ContainsKey(compundKey))
        {
            indexedProducs[compundKey] += quantity;
        }
        else
        {
            indexedProducs.Add(compundKey, quantity);
        }
    }

    public int GetTotalByProduct(string productName)
    {
        return GenericSearch(NAME, productName);
    }

    public int GetTotalByCountry(string country)
    {
        return GenericSearch(COUNTRY, country);
    }

    private int GenericSearch(string searchParam, string searchvalue)
    {
        if (string.IsNullOrEmpty(searchvalue))
        {
            throw new Exception(searchParam + " can not be null");
        }

        if (indexedProducs == null)
        {
            throw new Exception("Inventory is empty");
        }

        compundKey = generateCounpoundkey(searchParam, searchvalue);
        if (indexedProducs.ContainsKey(compundKey))
        {
            return indexedProducs[compundKey];
        }
        return 0;
    }

}