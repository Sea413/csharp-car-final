using System.Collections.Generic;

namespace Inventory.Objects
{
  public class Car
  {
    // private string _description;
    private string _make;
    private string _model;
    private string _price;
    private string _mileage;
    private static List<object> _instances = new List<object> {};

    public Car (string make, string model, string price, string mileage)
    {
      this._make = make;
      this._model = model;
      this._price = price;
      this._mileage = mileage;
    }
    public string GetMake()
    {
      return this._make;
    }
    public void SetMake(string newMake)
    {
      this._make = newMake;
    }

    public string GetModel()
    {
      return this._model;
    }
    public void SetModel(string newModel)
    {
      this._model = newModel;
    }

    public string GetPrice()
    {
      return this._price;
    }
    public void SetPrice(string newPrice)
    {
      this._price = newPrice;
    }

    public string GetMileage()
    {
      return this._mileage;
    }
    public void SetMileage(string newMileage)
    {
      this._mileage = newMileage;
    }

    public static List<object> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }

    public static void ClearAll()
    {
    _instances.Clear();
    }
  }
}
