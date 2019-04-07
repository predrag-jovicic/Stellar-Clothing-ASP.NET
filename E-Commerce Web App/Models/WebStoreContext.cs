using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Models
{
    public class WebStoreContext : IdentityDbContext<User,Role,String>
    {
        public WebStoreContext(DbContextOptions<WebStoreContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<FooterMenu> FooterMenus { get; set; }
        public DbSet<HeadingMenu> HeadingMenus { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Ordered> Ordereds { get; set; }
        public DbSet<Poll> Polls { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderPhoto> SliderPhotos { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Models.Type> Types { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Color>().HasData(
                    new Color { Color_id = 1, Name = "Red" },
                    new Color { Color_id = 2,Name = "Blue" },
                    new Color { Color_id = 3,Name = "Green" },
                    new Color { Color_id = 4,Name = "Yellow" },
                    new Color { Color_id = 5,Name = "Purple" },
                    new Color { Color_id = 6,Name = "Black" },
                    new Color { Color_id = 7,Name = "White" }
            );
            builder.Entity<Category>().HasData(
                    new Category { Category_id = 1, Name = "Men" },
                    new Category { Category_id = 2, Name = "Women" }
            );
            builder.Entity<FooterMenu>().HasData(
                    new FooterMenu { FooterItem_id = 1,Name = "Home", Link = "" },
                    new FooterMenu { FooterItem_id = 2,Name = "Contact us", Link = "contact" },
                    new FooterMenu { FooterItem_id = 3,Name = "Login", Link = "login" },
                    new FooterMenu { FooterItem_id = 4,Name = "Register", Link = "register" },
                    new FooterMenu { FooterItem_id = 5,Name = "Author", Link = "author" }
            );
            builder.Entity<Poll>().HasData(
                new Poll { Poll_id = 1, Active = true, Question = "Do you like this website?" }
                );

            builder.Entity<Option>().HasData(
                 new Option { Option_id = 1, Name = "Yes", Poll_id = 1 },
                 new Option { Option_id = 2, Name = "No", Poll_id = 1 }
                );

            builder.Entity<Subcategory>().HasData(
                    new Subcategory { Subcategory_id = 1, Name = "Accessories" },
                    new Subcategory { Subcategory_id = 2,Name = "Backpacks" },
                    new Subcategory { Subcategory_id = 3,Name = "Blazers" },
                    new Subcategory { Subcategory_id = 4,Name = "Jackets" },
                    new Subcategory { Subcategory_id = 5,Name = "Jeans" },
                    new Subcategory { Subcategory_id = 6,Name = "Shirts" },
                    new Subcategory { Subcategory_id = 7,Name = "Shoes" },
                    new Subcategory { Subcategory_id = 8,Name = "Trousers" },
                    new Subcategory { Subcategory_id = 9,Name = "T-Shirts" },
                    new Subcategory { Subcategory_id = 10,Name = "Underwear" },
                    new Subcategory { Subcategory_id = 16,Name = "Bags" },
                    new Subcategory { Subcategory_id = 17,Name = "Body" },
                    new Subcategory { Subcategory_id = 18,Name = "Dresses" },
                    new Subcategory { Subcategory_id = 19,Name = "Jumpsuits" },
                    new Subcategory { Subcategory_id = 20,Name = "Skirts" },
                    new Subcategory { Subcategory_id = 21,Name = "Swimwear" }
                );

            builder.Entity<Models.Type>().HasData(
                    new Models.Type { Type_id = 1,Name = "Eyewear" },
                    new Models.Type { Type_id = 2,Name = "Hats"},
                    new Models.Type { Type_id = 3,Name = "Jewellery" },
                    new Models.Type { Type_id = 4,Name = "Mini" },
                    new Models.Type { Type_id = 5,Name = "Large" },
                    new Models.Type { Type_id = 6,Name = "Lace" },
                    new Models.Type { Type_id = 7,Name = "Plain" },
                    new Models.Type { Type_id = 8,Name = "Maxi" },
                    new Models.Type { Type_id = 9,Name = "Midi" },
                    new Models.Type { Type_id = 10,Name = "Flats" },
                    new Models.Type { Type_id = 11,Name = "High-heels" },
                    new Models.Type { Type_id = 12,Name = "Sneakers" },
                    new Models.Type { Type_id = 13,Name = "Summer shoes" },
                    new Models.Type { Type_id = 14,Name = "Basic" },
                    new Models.Type { Type_id = 16,Name = "Sleeveless" },
                    new Models.Type { Type_id = 17,Name = "Belts" },
                    new Models.Type { Type_id = 18,Name = "Sunglasses" },
                    new Models.Type { Type_id = 19,Name = "Checked" },
                    new Models.Type { Type_id = 20,Name = "Vests" },
                    new Models.Type { Type_id = 21,Name = "Bomber" },
                    new Models.Type { Type_id = 22,Name = "Denim" },
                    new Models.Type { Type_id = 23,Name = "Regular fit" },
                    new Models.Type { Type_id = 24,Name = "Leather" },
                    new Models.Type { Type_id = 25,Name = "Slim fit" },
                    new Models.Type { Type_id = 26,Name = "Casual" },
                    new Models.Type { Type_id = 27,Name = "Moccasins" },
                    new Models.Type { Type_id = 28,Name = "Chinos" },
                    new Models.Type { Type_id = 29,Name = "Tailored" },
                    new Models.Type { Type_id = 30,Name = "Striped" },
                    new Models.Type { Type_id = 31,Name = "Printed" }
                );

            builder.Entity<Size>().HasData(
                    new Size { Size_id = 1, Name = "XS" },
                    new Size { Size_id = 2, Name = "S" },
                    new Size { Size_id = 3, Name = "M" },
                    new Size { Size_id = 4, Name = "XL" },
                    new Size { Size_id = 5, Name = "L" },
                    new Size { Size_id = 6, Name = "XXL" }
                );

            builder.Entity<Slider>().HasData(
                    new Slider { Slider_id = 1, Active = true, Title = "Summer collection", Text = "Browse our new collection" }
                );

            builder.Entity<SliderPhoto>().HasData(
                 new SliderPhoto { Photo_id = 1, Slider_id = 1, Alt = "Man cover", Source = "/images/mancover.jpg" },
                 new SliderPhoto { Photo_id = 2, Slider_id = 1, Alt = "Woman cover", Source = "/images/womancover.jpg" }
                );

            builder.Entity<Price>().HasData(
                    new Price { Price_id = 1,Product_id = 1, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 2,Product_id = 2, Net_price = 25, Discount = 10, Active = true },
                    new Price { Price_id = 3,Product_id = 3, Net_price = 49, Discount = 34, Active = true },
                    new Price { Price_id = 4,Product_id = 4, Net_price = 89, Discount = 14, Active = true },
                    new Price { Price_id = 5,Product_id = 5, Net_price = 100, Discount = 17, Active = true },
                    new Price { Price_id = 6,Product_id = 6, Net_price = 12, Discount = 43, Active = true },
                    new Price { Price_id = 7,Product_id = 7, Net_price = 44, Discount = 15, Active = true },
                    new Price { Price_id = 8,Product_id = 8, Net_price = 16, Discount = 30, Active = true },
                    new Price { Price_id = 9,Product_id = 9, Net_price = 27, Discount = 8, Active = true },
                    new Price { Price_id = 10,Product_id = 10, Net_price = 31, Discount = 6, Active = true },
                    new Price { Price_id = 11,Product_id = 11, Net_price = 10, Discount = 0, Active = true },
                    new Price { Price_id = 12,Product_id = 12, Net_price = 33, Discount = 11, Active = true },
                    new Price { Price_id = 13,Product_id = 13, Net_price = 80, Discount = 18, Active = true },
                    new Price { Price_id = 14,Product_id = 14, Net_price = 110, Discount = 0, Active = true },
                    new Price { Price_id = 15,Product_id = 15, Net_price = 24, Discount = 0, Active = true },
                    new Price { Price_id = 16, Product_id = 16, Net_price = 39, Discount = 0, Active = true }
                );
            builder.Entity<ProductVariant>().HasData(
                    new ProductVariant { ProductVariant_Id = 1, Product_id = 1, Color_id = 2, Quantity = 12 },
                    new ProductVariant {ProductVariant_Id = 2,Product_id = 2, Color_id = 2, Quantity = 20 },
                    new ProductVariant {ProductVariant_Id = 3,Product_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 4,Product_id = 4, Color_id = 2, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 5,Product_id = 4, Color_id = 1, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 6,Product_id = 4, Color_id = 4, Size_id = 4, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 7,Product_id = 4, Color_id = 3, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 8,Product_id = 4, Color_id = 5, Size_id = 5, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 9,Product_id = 4, Color_id = 5, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 10,Product_id = 5, Color_id = 4, Size_id = 4, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 11,Product_id = 5, Color_id = 3, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 12,Product_id = 5, Color_id = 5, Size_id = 5, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 13,Product_id = 5, Color_id = 5, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 14,Product_id = 6, Color_id = 4, Size_id = 4, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 15,Product_id = 6, Color_id = 3, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 16,Product_id = 6, Color_id = 5, Size_id = 5, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 17,Product_id = 6, Color_id = 5, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 18,Product_id = 7, Color_id = 4, Size_id = 4, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 19,Product_id = 7, Color_id = 3, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 20,Product_id = 7, Color_id = 5, Size_id = 5, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 21,Product_id = 7, Color_id = 5, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 22,Product_id = 8, Color_id = 4, Size_id = 4, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 23,Product_id = 8, Color_id = 3, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 24,Product_id = 8, Color_id = 5, Size_id = 5, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 25,Product_id = 8, Color_id = 5, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 26,Product_id = 8, Color_id = 2, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 27,Product_id = 8, Color_id = 1, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 28,Product_id = 9, Color_id = 4, Size_id = 4, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 29,Product_id = 9, Color_id = 3, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 30,Product_id = 9, Color_id = 5, Size_id = 5, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 31,Product_id = 9, Color_id = 5, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 32,Product_id = 10, Color_id = 2, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 33,Product_id = 10, Color_id = 1, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 34,Product_id = 10, Color_id = 4, Size_id = 4, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 35,Product_id = 10, Color_id = 3, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 36,Product_id = 10, Color_id = 5, Size_id = 5, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 37,Product_id = 10, Color_id = 5, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 38,Product_id = 11, Color_id = 2, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 39,Product_id = 11, Color_id = 1, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 40,Product_id = 11, Color_id = 4, Size_id = 4, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 41,Product_id = 11, Color_id = 3, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 42,Product_id = 11, Color_id = 5, Size_id = 5, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 43,Product_id = 11, Color_id = 5, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 44,Product_id = 12, Color_id = 2, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 45,Product_id = 12, Color_id = 1, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 46,Product_id = 12, Color_id = 4, Size_id = 4, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 47,Product_id = 12, Color_id = 3, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 48,Product_id = 12, Color_id = 5, Size_id = 5, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 49,Product_id = 12, Color_id = 5, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 50,Product_id = 13, Color_id = 2, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 51,Product_id = 13, Color_id = 1, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 52,Product_id = 13, Color_id = 4, Size_id = 4, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 53,Product_id = 13, Color_id = 3, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 54,Product_id = 13, Color_id = 5, Size_id = 5, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 55,Product_id = 13, Color_id = 5, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 56,Product_id = 14, Color_id = 2, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 57,Product_id = 14, Color_id = 1, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 58,Product_id = 14, Color_id = 4, Size_id = 4, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 59,Product_id = 14, Color_id = 3, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 60,Product_id = 14, Color_id = 5, Size_id = 5, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 61,Product_id = 15, Color_id = 5, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 62,Product_id = 15, Color_id = 2, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 63,Product_id = 15, Color_id = 1, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 64,Product_id = 15, Color_id = 4, Size_id = 4, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 65,Product_id = 15, Color_id = 3, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 66,Product_id = 15, Color_id = 5, Size_id = 5, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 67,Product_id = 15, Color_id = 5, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 68,Product_id = 16, Color_id = 2, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 69,Product_id = 16, Color_id = 1, Size_id = 1, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 70,Product_id = 16, Color_id = 4, Size_id = 4, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 71,Product_id = 16, Color_id = 3, Size_id = 3, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 72,Product_id = 16, Color_id = 5, Size_id = 5, Quantity = 15 },
                    new ProductVariant {ProductVariant_Id = 73, Product_id = 16, Color_id = 5, Size_id = 3, Quantity = 15 }
                );
            builder.Entity<HeadingMenu>().HasData(
                new HeadingMenu {HeadingItem_id = 1, Name = "Home", Link = "",Item_Column = 0,HasChildren = false, Parent = 0 },
                new HeadingMenu {HeadingItem_id = 2, Name = "Men", Link = "",Item_Column = 0, HasChildren = true, Parent = 0 },
                new HeadingMenu {HeadingItem_id = 3, Name = "Women", Link = "", Item_Column = 0, HasChildren = true, Parent = 0 },
                new HeadingMenu {HeadingItem_id = 4, Name = "Contact us", Link = "contact", Item_Column = 0, HasChildren = false, Parent = 0 },
                new HeadingMenu {HeadingItem_id = 5, Name = "Accessories", Link = "products/men/accessories", Item_Column = 1, HasChildren = false, Parent = 2 },              
                new HeadingMenu {HeadingItem_id = 6, Name = "Backpacks", Link = "products/men/backpacks", Item_Column = 1, HasChildren = false, Parent = 2 },
                new HeadingMenu {HeadingItem_id = 7, Name = "Blazers", Link = "products/men/blazers",  Item_Column = 1, HasChildren = false, Parent = 2 },
                new HeadingMenu {HeadingItem_id = 8, Name = "Jackets", Link = "products/men/jackets",Item_Column = 1, HasChildren = false, Parent = 2 },
                new HeadingMenu {HeadingItem_id = 9, Name = "Jeans", Link = "products/men/jeans",  Item_Column = 2, HasChildren = false, Parent = 2 },
                new HeadingMenu {HeadingItem_id = 10, Name = "Shirts", Link = "products/men/shirts", Item_Column = 2, HasChildren = false, Parent = 2 },
                new HeadingMenu {HeadingItem_id = 11, Name = "Shoes", Link = "products/men/shoes", Item_Column = 2, HasChildren = false, Parent = 2 },
                new HeadingMenu {HeadingItem_id = 12, Name = "Trousers", Link = "products/men/trousers", Item_Column = 2, HasChildren = false, Parent = 2 },
                new HeadingMenu {HeadingItem_id = 13, Name = "T-Shirts", Link = "products/men/t-shirts", Item_Column = 3, HasChildren = false, Parent = 2 },
                new HeadingMenu {HeadingItem_id = 14, Name = "Underwear", Link = "products/men/underwear", Item_Column = 3, HasChildren = false, Parent = 2 },
                new HeadingMenu {HeadingItem_id = 15, Name = "Accessories", Link = "products/women/accessories", Item_Column = 1, HasChildren = false, Parent = 3 },
                new HeadingMenu {HeadingItem_id = 16, Name = "Bags", Link = "products/women/bags", Item_Column = 1, HasChildren = false, Parent = 3 },
                new HeadingMenu {HeadingItem_id = 17, Name = "Body", Link = "products/women/body", Item_Column = 1, HasChildren = false, Parent = 3 },
                new HeadingMenu {HeadingItem_id = 18, Name = "Dresses", Link = "products/women/dresses", Item_Column = 1, HasChildren = false, Parent = 3 },
                new HeadingMenu {HeadingItem_id = 19, Name = "Jeans", Link = "products/women/jeans", Item_Column = 2, HasChildren = false, Parent = 3 },
                new HeadingMenu {HeadingItem_id = 20, Name = "Jumpsuits", Link = "products/women/jumpsuits", Item_Column = 2, HasChildren = false, Parent = 3 },
                new HeadingMenu {HeadingItem_id = 21, Name = "Shoes", Link = "products/women/shoes", Item_Column = 2, HasChildren = false, Parent = 3 },
                new HeadingMenu {HeadingItem_id = 22, Name = "Skirts", Link = "products/women/skirts", Item_Column = 2, HasChildren = false, Parent = 3 },
                new HeadingMenu {HeadingItem_id = 23, Name = "Swimwear", Link = "products/women/swimwear", Item_Column = 3, HasChildren = false, Parent = 3 },
                new HeadingMenu {HeadingItem_id = 24, Name = "T-Shirts", Link = "products/women/t-shirts", Item_Column = 3, HasChildren = false, Parent = 3 }
                );

            builder.Entity<ProductPhoto>().HasData(
                    new ProductPhoto { Photo_id=1, Product_id = 1, Source = @"/images/MEN/Accessories/Belts/1_1.jpg", Alt = "Belt" },
                    new ProductPhoto {Photo_id=2,Product_id = 1, Source = @"/images/MEN/Accessories/Belts/1_2.jpg", Alt = "Belt" },
                    new ProductPhoto {Photo_id=3,Product_id = 2, Source = @"/images/MEN/Accessories/Belts/2_1.jpg", Alt = "Belt" },
                    new ProductPhoto {Photo_id=4,Product_id = 2, Source = @"/images/MEN/Accessories/Belts/2_2.jpg", Alt = "Belt" },
                    new ProductPhoto {Photo_id=5,Product_id = 3, Source = @"/images/MEN/Accessories/Jewellery/2_1.jpg", Alt = "Bracelet" },
                    new ProductPhoto {Photo_id=6,Product_id = 3, Source = @"/images/MEN/Accessories/Jewellery/2_2.jpg", Alt = "Bracelet" },
                    new ProductPhoto {Photo_id=7,Product_id = 4, Source = @"/images/MEN/Blazers/Vests/1_1.jpg", Alt = "Vest" },
                    new ProductPhoto {Photo_id=8,Product_id = 4, Source = @"/images/MEN/Blazers/Vests/1_2.jpg", Alt = "Vest" },
                    new ProductPhoto {Photo_id=9,Product_id = 4, Source = @"/images/MEN/Blazers/Vests/1_3.jpg", Alt = "Vest" },
                    new ProductPhoto {Photo_id=10,Product_id = 5, Source = @"/images/MEN/Jeans/Regular_fit/1_1.jpg", Alt = "Jeans" },
                    new ProductPhoto {Photo_id=11,Product_id = 5, Source = @"/images/MEN/Jeans/Regular_fit/1_2.jpg", Alt = "Jeans" },
                    new ProductPhoto {Photo_id=12,Product_id = 5, Source = @"/images/MEN/Jeans/Regular_fit/1_3.jpg", Alt = "Jeans" },
                    new ProductPhoto {Photo_id=13,Product_id = 6, Source = @"/images/MEN/Shoes/Moccasins/2_1.jpg", Alt = "Shoes" },
                    new ProductPhoto {Photo_id=14,Product_id = 6, Source = @"/images/MEN/Shoes/Moccasins/2_2.jpg", Alt = "Shoes" },
                    new ProductPhoto {Photo_id=15,Product_id = 6, Source = @"/images/MEN/Shoes/Moccasins/2_3.jpg", Alt = "Shoes" },
                    new ProductPhoto {Photo_id=16,Product_id = 7, Source = @"/images/MEN/Shoes/Sneakers/1_1.jpg", Alt = "Sneakers" },
                    new ProductPhoto {Photo_id=17,Product_id = 7, Source = @"/images/MEN/Shoes/Sneakers/1_2.jpg", Alt = "Sneakers" },
                    new ProductPhoto {Photo_id=18,Product_id = 7, Source = @"/images/MEN/Shoes/Sneakers/1_3.jpg", Alt = "Sneakers" },
                    new ProductPhoto {Photo_id=19,Product_id = 8, Source = @"/images/MEN/TShirts/Sleeveless/2_1.jpg", Alt = "T-Shirt" },
                    new ProductPhoto {Photo_id=20,Product_id = 8, Source = @"/images/MEN/TShirts/Sleeveless/2_2.jpg", Alt = "T-Shirt" },
                    new ProductPhoto {Photo_id=21,Product_id = 8, Source = @"/images/MEN/TShirts/Sleeveless/2_3.jpg", Alt = "T-Shirt" },
                    new ProductPhoto {Photo_id=22,Product_id = 9, Source = @"/images/MEN/TShirts/Striped/1_1.jpg", Alt = "T-Shirt" },
                    new ProductPhoto {Photo_id=23,Product_id = 9, Source = @"/images/MEN/TShirts/Striped/1_2.jpg", Alt = "T-Shirt" },
                    new ProductPhoto {Photo_id=24,Product_id = 9, Source = @"/images/MEN/TShirts/Striped/1_3.jpg", Alt = "T-Shirt" },
                    new ProductPhoto {Photo_id=25,Product_id = 10, Source = @"/images/WOMEN/Bags/Mini_bags/1_1.jpg", Alt = "Bag" },
                    new ProductPhoto {Photo_id=26,Product_id = 10, Source = @"/images/WOMEN/Bags/Mini_bags/1_2.jpg", Alt = "Bag" },
                    new ProductPhoto {Photo_id=27,Product_id = 10, Source = @"/images/WOMEN/Bags/Mini_bags/1_3.jpg", Alt = "Bag" },
                    new ProductPhoto {Photo_id=28,Product_id = 11, Source = @"/images/WOMEN/Body/Lace/2_1.jpg", Alt = "Body" },
                    new ProductPhoto {Photo_id=29,Product_id = 11, Source = @"/images/WOMEN/Body/Lace/2_2.jpg", Alt = "Body" },
                    new ProductPhoto {Photo_id=30,Product_id = 11, Source = @"/images/WOMEN/Body/Lace/2_3.jpg", Alt = "Body" },
                    new ProductPhoto {Photo_id=31,Product_id = 12, Source = @"/images/WOMEN/Dresses/Maxi/1_1.jpg", Alt = "Dress" },
                    new ProductPhoto {Photo_id=32,Product_id = 12, Source = @"/images/WOMEN/Dresses/Maxi/1_2.jpg", Alt = "Dress" },
                    new ProductPhoto {Photo_id=33,Product_id = 12, Source = @"/images/WOMEN/Dresses/Maxi/1_3.jpg", Alt = "Dress" },
                    new ProductPhoto {Photo_id=34,Product_id = 13, Source = @"/images/WOMEN/Dresses/Maxi/3_1.jpg", Alt = "Dress" },
                    new ProductPhoto {Photo_id=35,Product_id = 13, Source = @"/images/WOMEN/Dresses/Maxi/3_2.jpg", Alt = "Dress" },
                    new ProductPhoto {Photo_id=36,Product_id = 13, Source = @"/images/WOMEN/Dresses/Maxi/3_3.jpg", Alt = "Dress" },
                    new ProductPhoto {Photo_id=37,Product_id = 14, Source = @"/images/WOMEN/Dresses/Mini/3_1.jpg", Alt = "Dress" },
                    new ProductPhoto {Photo_id=38,Product_id = 14, Source = @"/images/WOMEN/Dresses/Mini/3_2.jpg", Alt = "Dress" },
                    new ProductPhoto {Photo_id=39,Product_id = 14, Source = @"/images/WOMEN/Dresses/Mini/3_3.jpg", Alt = "Dress" },
                    new ProductPhoto {Photo_id=40,Product_id = 15, Source = @"/images/WOMEN/Jumpsuits/2_1.jpg", Alt = "Jumpsuit" },
                    new ProductPhoto {Photo_id=41,Product_id = 15, Source = @"/images/WOMEN/Jumpsuits/2_2.jpg", Alt = "Jumpsuit" },
                    new ProductPhoto {Photo_id=42,Product_id = 15, Source = @"/images/WOMEN/Jumpsuits/2_3.jpg", Alt = "Jumpsuit" },
                    new ProductPhoto {Photo_id=43,Product_id = 16, Source = @"/images/WOMEN/Shoes/High_heels/2_1.jpg", Alt = "Shoes" },
                    new ProductPhoto {Photo_id=44,Product_id = 16, Source = @"/images/WOMEN/Shoes/High_heels/2_2.jpg", Alt = "Shoes" },
                    new ProductPhoto {Photo_id = 45, Product_id = 16, Source = @"/images/WOMEN/Shoes/High_heels/2_3.jpg", Alt = "Shoes" }
                );

            builder.Entity<Product>().HasData(
                    new Product { Product_id = 1, Name = "Light brown leather belt", Description = "Belt with embossed metallic buckle", Category_id = 1, Subcategory_id = 1, Type_id = 17 },
                    new Product { Product_id = 2, Name = "Dark brown leather belt", Description = "Belt with sports buckle and metallic feature on the tip", Category_id = 1, Subcategory_id = 1, Type_id = 17 },
                    new Product { Product_id = 3, Name = "Metal bracelet", Description = "Metal cuff bracelet", Category_id = 1, Subcategory_id = 1, Type_id = 3 },
                    new Product { Product_id = 4, Name = "Birdseye suit blazer", Description = "Textured weave blazer with a notched lapel collar and a contrasting pin detail in the buttonhole. Features two front flap pockets, one besom pocket at the chest with a pocket square detail, lining with double inside pockets, double back vents, buttoned cuffs and button fastening in the front.", Category_id = 1, Subcategory_id = 3, Type_id = 20 },
                    new Product { Product_id = 5, Name = "Cropped loose fit jeans", Description = "Cropped faded loose fit jeans with ripped detailing. They feature two side pockets, two back pockets, one coin pocket, belt loops, button fly fastening in the front and frayed hems", Category_id = 1, Subcategory_id = 5, Type_id = 23 },
                    new Product { Product_id = 6, Name = "Leather and jute espadrilles", Description = "Espadrilles with a leather upper and a natural jute sole", Category_id = 1, Subcategory_id = 7, Type_id = 27 },
                    new Product { Product_id = 7, Name = "White embossed plimsolls", Description = "White plimsolls. Seven-eyelet facing. Embossed detailing on the upper, except for the toe cap and the heel. White soles", Category_id = 1, Subcategory_id = 7, Type_id = 12 },
                    new Product { Product_id = 8, Name = "Floral and swirl printed tank top", Description = "Sleeveless printed T-shirt with a round neckline. Features a chest pocket", Category_id = 1, Subcategory_id = 9, Type_id = 16 },
                    new Product { Product_id = 9, Name = "Texture striped t-shirt", Description = "Straight, printed T-shirt with a round neckline and short sleeves", Category_id = 1, Subcategory_id = 9, Type_id = 30 },
                    new Product { Product_id = 10, Name = "Multicolored sequinned crossbody bag", Description = "Multicoloured mini crossbody bag. Multicoloured sequin appliqués on the exterior. Lined interior with pocket", Category_id = 2, Subcategory_id = 16, Type_id = 4 },
                    new Product { Product_id = 11, Name = "Lace bodysuit", Description = "Semi-sheer, strappy bodysuit with a V-neckline and snap button fastening on the bottom", Category_id = 2, Subcategory_id = 17, Type_id = 6 },
                    new Product { Product_id = 12, Name = "Long dress", Description = "Long red dress", Category_id = 2, Subcategory_id = 18, Type_id = 8 },
                    new Product { Product_id = 13, Name = "Linen dress with topstitching", Description = "Long V-neck dress with short sleeves. Features a wide gathered waist, an asymmetric, frayed hem and button fastening in the front", Category_id = 2, Subcategory_id = 18, Type_id = 8 },
                    new Product { Product_id = 14, Name = "Pleated waistcoat with inverted lapels", Description = "Double-breasted waistcoat with high inverted lapel collar. Box pleat detail on the hem in the same fabric. Features front flap pockets and button fastening", Category_id = 2, Subcategory_id = 18, Type_id = 4 },
                    new Product { Product_id = 15, Name = "Floral print short jumpsuit", Description = "Jumpsuit with an elastic neckline and short ruffled sleeves. Features a seam at the waist, a matching fabric belt, a ruffled hem and zip and button fastening in the front", Category_id = 2, Subcategory_id = 19, Type_id = null },
                    new Product { Product_id = 16, Name = "Fabric high-heel court shoes", Description = "Fuchsia high-heel shoes. Kitten heels. Pointed toes", Category_id = 2, Subcategory_id = 7, Type_id = 11}
                );
        }
    }
}
