using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Late_Night_Snacks.Models;

namespace Late_Night_Snacks.Data
{
    public static class DBSeeder
    {
        public static void SeedDB(MenuItemsDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.MenuItems.AddRange(
                new MenuItem()
                {
                    Name = "Foot-long Chili Cheese Hot Dog",
                    Description = "Try is incredible end to your long night of adventure. Premium-grade meats fill this delicious dog with juicy excitement for your tastebuds to enjoy. Top this incredible hot dog served on a Kaiser bun with spicy cheese, warm chili, pickles, spicy mustard, ketchup, onions, pico- you name it, if we have it on the truck, you can load it on your dog.",
                    Price = 1.00M,
                    Quantity = 1,
                },
                new MenuItem()
                {
                    Name = "Meats and More Pepperoni Pizza",
                    Description = "This pizza is sure to make your night feel out of this world! With a traditional mozzarella-cheese topping over a marinara sause, this inch-thick slice of pizza is honestly a meal in itself. Pepperoni, sweet Italian Sausage, and a mixure of ham and seasoned ground turkey top this incredible pizza that is served with a fork and knife becuase you will need them to eat this pizza!",
                    Price = 2.00M,
                    Quantity = 1,
                },
                new MenuItem()
                {
                    Name = "Happy Ending Hot Fudge Sunday", 
                    Description = "End your warm night with a cool down and some hot fudge. Locally-sources Oberweis Vanilla Bean Ice Cream is topped with a waterfall of Bissinger's homemade chocolate hot fudge. This icecream is served in a bowl but is flanked with pieces of sugar cone scoops that allow you to get the taste of a cone without the mess. Add a chocolate-covered cherry on top and that completes the end to an amazing night on the town", 
                    Price = 5.00M,
                    Quantity = 1
                },
                new MenuItem()
                {
                    Name = "Kale Chips in Sea Salt with Guacamole Aioli",
                    Description = "Tired of the typical potato chips? Try this quick snack thats as good for your hunger as it is for your waistline. Fresh baked, these kale chips are lightly crusted with Mediterranean Sea Salt and are accompanied by a side of our signature guacamole aioli ",
                    Price = 1.00M,
                    Quantity = 1
                }, new MenuItem()
                {
                    Name = "Cajun Butter Popcorn",
                    Description = "Looking for a handy snack you can carry around and share with others? This buttered popcorn tossed with a bit of spice from Zatarain's cajun seasoning will make you the star of the afterparty. Nothing beats the hunger pains better than this basic salty snack that is as good for one as it is for many ",
                    Price = 6.00M,
                    Quantity = 1
                }, new MenuItem()
                {
                    Name = "Fruit-Topped Funnel Cake",
                    Description = "As simple as its stated: Traditional powdered sugar topped doughy funnel cake severed with your choice of fruit topping. Toppings include cherry, strawberry, blackberry, and apple. Caramel and hot fudge can be added. A la mode for $2.00 extra",
                    Price = 3.00M,
                    Quantity = 1
                }, new MenuItem()
                {
                    Name = "Angus Double Thick Burger with Sharpe Cheddar Cheese",
                    Description = "This double stacked burger is sure enough to eat for two! Two angus patties are encased in two pieces each of this sharpe cheddar cheese between a layer of spicy mayo, lettuc, tomato, and onion. Served on a sweet Hawaiian bread bun, this burger will not disappoint. ",
                    Price = 5.00M,
                    Quantity = 1
                }, new MenuItem()
                {
                    Name = "Cucumber slices topped with Spinache Artichoke Dip",
                    Description = "This healthy snack will give your Keto diet a boost with fresh, locally grown cucumbers serving as the base for this delicious dish. Fat-free mozarella with Neufchatel cheese are mixed with spinach and artichokes to make this veggie snack as delicious as it looks. 4 pieces per order ",
                    Price = 1.00M,
                    Quantity = 1
                },
                new MenuItem()
                {
                    Name = "Strawberry Shortcake To Go",
                    Description = "This quick dessert is perfect to eat on the go when you are heading home after a long evening of fun. Served in a collectable cup with a spoon, this dish is simple layers and short-bread based cake, with alternating vanilla whipped cream and strawberry puree. Topped with a dollop of whipped cream and a fresh strawberry this dessert is almost too pretty to eat! But don't let that stop you!",
                    Price = 8.00M,
                    Quantity = 1
                }, new MenuItem()
                {
                    Name = "Steak and Eggs",
                    Description = "Simply put: Steak and Eggs With Hashbrowns. This St. Louis classic is cooked to order, with your steak rare, medium, or well done; eggs can be over-easy, scrambled, or fried. You make your choice! Hashbrowns can be plain, or covered with our spicy cheese, bacon, chili- anything on toppings on the truck you want to add can make this mainstream meal uniquely yours ",
                    Price = 12.00M,
                    Quantity = 1
                }
                );
            context.SaveChanges();
        }
    }
}
