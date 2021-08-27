using System;
using System.Collections.Generic;
using System.Text;
using IntecApp.Models;

namespace IntecApp.ViewModels
{
    public class MenuOptionViewModel
    {
        public MenuOption BarsAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption FineDiningMenuOption { get; set; } = new MenuOption();
        public MenuOption CafesMenuOption { get; set; } = new MenuOption();
        public MenuOption NearbyMenuOption { get; set; } = new MenuOption();
        public MenuOption FastFoodsMenuOption { get; set; } = new MenuOption();
        public MenuOption FeaturedFoodsMenuOption { get; set; } = new MenuOption();

        public MenuOptionViewModel()
        {
            BarsAndHotelsMenuOption.Title = "Bar and Hotels";
            BarsAndHotelsMenuOption.Image = "beer.png";
            BarsAndHotelsMenuOption.Sub = "42 Place";

            FineDiningMenuOption.Title = "Fine Dining";
            FineDiningMenuOption.Image = "serving_dish.png";
            FineDiningMenuOption.Sub = "15 Place";

            CafesMenuOption.Title = "Cafes";
            CafesMenuOption.Image = "coffee_shop.png";
            CafesMenuOption.Sub = "28 Place";

            NearbyMenuOption.Title = "Nearby";
            NearbyMenuOption.Image = "destination.png";
            NearbyMenuOption.Sub = "34 Place";

            FastFoodsMenuOption.Title = "Fast Foods";
            FastFoodsMenuOption.Image = "fast_food.png";
            FastFoodsMenuOption.Sub = "29 Place";

            FeaturedFoodsMenuOption.Title = "Featured Foods";
            FeaturedFoodsMenuOption.Image = "pizza.png";
            FeaturedFoodsMenuOption.Sub = "21 Place";
        }
    }
}
