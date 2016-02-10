using Nancy;
using Inventory.Objects;
using System.Collections.Generic;

namespace InventoryList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_car.cshtml"];
      Get["/view_all_cars"] = _ => {
        List<object> allCars = Car.GetAll();
        return View["view_all_cars.cshtml", allCars];
      };
      Post["/car_added"] = _ => {
        Car newCar = new Car (Request.Form["make"], Request.Form["model"],Request.Form["price"],Request.Form["mileage"]);
        // mileage = Request.Query["mileage"],
        // price = Request.Query["price"],

        newCar.Save();
        return View["car_added.cshtml", newCar];
      };
      Post["/cars_cleared"] = _ => {
        Car.ClearAll();
        return View["cars_cleared.cshtml"];
      };
    }
  }
}
