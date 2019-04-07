using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce_Web_App.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 25, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    CardNumber = table.Column<string>(nullable: true),
                    CSC = table.Column<short>(nullable: true),
                    HomeAddress = table.Column<string>(maxLength: 70, nullable: true),
                    ZipCode = table.Column<int>(nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Color_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Color_id);
                });

            migrationBuilder.CreateTable(
                name: "FooterMenus",
                columns: table => new
                {
                    FooterItem_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Link = table.Column<string>(maxLength: 70, nullable: false),
                    Name = table.Column<string>(maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterMenus", x => x.FooterItem_id);
                });

            migrationBuilder.CreateTable(
                name: "HeadingMenus",
                columns: table => new
                {
                    HeadingItem_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Link = table.Column<string>(maxLength: 70, nullable: false),
                    Name = table.Column<string>(maxLength: 35, nullable: false),
                    Level = table.Column<byte>(nullable: false),
                    Parent = table.Column<short>(nullable: false),
                    Item_Column = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadingMenus", x => x.HeadingItem_id);
                });

            migrationBuilder.CreateTable(
                name: "Polls",
                columns: table => new
                {
                    Poll_id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Question = table.Column<string>(maxLength: 100, nullable: false),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polls", x => x.Poll_id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Size_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Size_id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Slider_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(maxLength: 35, nullable: false),
                    Text = table.Column<string>(maxLength: 55, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Slider_id);
                });

            migrationBuilder.CreateTable(
                name: "Subcategories",
                columns: table => new
                {
                    Subcategory_id = table.Column<byte>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subcategories", x => x.Subcategory_id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Type_id = table.Column<short>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 55, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Type_id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Order_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Time = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Order_id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Option_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    Poll_id = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Option_id);
                    table.ForeignKey(
                        name: "FK_Options_Polls_Poll_id",
                        column: x => x.Poll_id,
                        principalTable: "Polls",
                        principalColumn: "Poll_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SliderPhotos",
                columns: table => new
                {
                    Photo_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Source = table.Column<string>(nullable: false),
                    Alt = table.Column<string>(nullable: false),
                    Slider_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderPhotos", x => x.Photo_id);
                    table.ForeignKey(
                        name: "FK_SliderPhotos_Sliders_Slider_id",
                        column: x => x.Slider_id,
                        principalTable: "Sliders",
                        principalColumn: "Slider_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 400, nullable: false),
                    Category_id = table.Column<byte>(nullable: false),
                    Subcategory_id = table.Column<byte>(nullable: false),
                    Type_id = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_Category_id",
                        column: x => x.Category_id,
                        principalTable: "Categories",
                        principalColumn: "Category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Subcategories_Subcategory_id",
                        column: x => x.Subcategory_id,
                        principalTable: "Subcategories",
                        principalColumn: "Subcategory_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Types_Type_id",
                        column: x => x.Type_id,
                        principalTable: "Types",
                        principalColumn: "Type_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Vote_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    Option_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Vote_id);
                    table.ForeignKey(
                        name: "FK_Votes_Options_Option_id",
                        column: x => x.Option_id,
                        principalTable: "Options",
                        principalColumn: "Option_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Price_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Net_price = table.Column<double>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Product_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Price_id);
                    table.ForeignKey(
                        name: "FK_Prices_Products_Product_id",
                        column: x => x.Product_id,
                        principalTable: "Products",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductPhotos",
                columns: table => new
                {
                    Photo_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Source = table.Column<string>(nullable: false),
                    Alt = table.Column<string>(nullable: false),
                    Product_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPhotos", x => x.Photo_id);
                    table.ForeignKey(
                        name: "FK_ProductPhotos_Products_Product_id",
                        column: x => x.Product_id,
                        principalTable: "Products",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductVariant_Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product_id = table.Column<int>(nullable: false),
                    Size_id = table.Column<byte>(nullable: true),
                    Color_id = table.Column<byte>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => x.ProductVariant_Id);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Colors_Color_id",
                        column: x => x.Color_id,
                        principalTable: "Colors",
                        principalColumn: "Color_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_Product_id",
                        column: x => x.Product_id,
                        principalTable: "Products",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Sizes_Size_id",
                        column: x => x.Size_id,
                        principalTable: "Sizes",
                        principalColumn: "Size_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Rating_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Product_id = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Rating_id);
                    table.ForeignKey(
                        name: "FK_Ratings_Products_Product_id",
                        column: x => x.Product_id,
                        principalTable: "Products",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ordereds",
                columns: table => new
                {
                    Ordered_id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductVariant_Id = table.Column<long>(nullable: false),
                    Order_Id = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordereds", x => x.Ordered_id);
                    table.ForeignKey(
                        name: "FK_Ordereds_Orders_Order_Id",
                        column: x => x.Order_Id,
                        principalTable: "Orders",
                        principalColumn: "Order_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ordereds_ProductVariants_ProductVariant_Id",
                        column: x => x.ProductVariant_Id,
                        principalTable: "ProductVariants",
                        principalColumn: "ProductVariant_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Category_id", "Name" },
                values: new object[,]
                {
                    { (byte)1, "Men" },
                    { (byte)2, "Women" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Color_id", "Name" },
                values: new object[,]
                {
                    { (byte)1, "Red" },
                    { (byte)2, "Blue" },
                    { (byte)3, "Green" },
                    { (byte)4, "Yellow" },
                    { (byte)5, "Purple" },
                    { (byte)6, "Black" },
                    { (byte)7, "White" }
                });

            migrationBuilder.InsertData(
                table: "FooterMenus",
                columns: new[] { "FooterItem_id", "Link", "Name" },
                values: new object[,]
                {
                    { 5, "author", "Author" },
                    { 3, "login", "Login" },
                    { 4, "register", "Register" },
                    { 1, "", "Home" },
                    { 2, "contact", "Contact us" }
                });

            migrationBuilder.InsertData(
                table: "HeadingMenus",
                columns: new[] { "HeadingItem_id", "Item_Column", "Level", "Link", "Name", "Parent" },
                values: new object[,]
                {
                    { (byte)14, (byte)3, (byte)2, "products/men/underwear", "Underwear", (short)2 },
                    { (byte)24, (byte)3, (byte)2, "products/women/jumpsuits", "T-Shirts", (short)3 },
                    { (byte)23, (byte)3, (byte)2, "products/women/jumpsuits", "Swimwear", (short)3 },
                    { (byte)22, (byte)2, (byte)2, "products/women/jumpsuits", "Skirts", (short)3 },
                    { (byte)21, (byte)2, (byte)2, "products/women/jumpsuits", "Shoes", (short)3 },
                    { (byte)20, (byte)2, (byte)2, "products/women/jumpsuits", "Jumpsuits", (short)3 },
                    { (byte)19, (byte)2, (byte)2, "products/women/jeans", "Jeans", (short)3 },
                    { (byte)18, (byte)1, (byte)2, "products/women/dresses", "Dresses", (short)3 },
                    { (byte)17, (byte)1, (byte)2, "products/women/body", "Body", (short)3 },
                    { (byte)16, (byte)1, (byte)2, "products/women/bags", "Bags", (short)3 },
                    { (byte)15, (byte)1, (byte)2, "products/women/accessories", "Accessories", (short)3 },
                    { (byte)13, (byte)3, (byte)2, "products/men/tshirts", "T-Shirts", (short)2 },
                    { (byte)9, (byte)2, (byte)2, "products/men/jeans", "Jeans", (short)2 },
                    { (byte)11, (byte)2, (byte)2, "products/men/shoes", "Shoes", (short)2 },
                    { (byte)1, (byte)0, (byte)1, "", "Home", (short)0 },
                    { (byte)2, (byte)0, (byte)1, "", "Men", (short)0 },
                    { (byte)12, (byte)2, (byte)2, "products/men/trousers", "Trousers", (short)2 },
                    { (byte)4, (byte)0, (byte)1, "contact", "Contact us", (short)0 },
                    { (byte)5, (byte)1, (byte)2, "products/men/accessories", "Accessories", (short)2 },
                    { (byte)3, (byte)0, (byte)1, "", "Women", (short)0 },
                    { (byte)7, (byte)1, (byte)2, "products/men/blazers", "Blazers", (short)2 },
                    { (byte)8, (byte)1, (byte)2, "products/men/jackets", "Jackets", (short)2 },
                    { (byte)10, (byte)2, (byte)2, "products/men/shirts", "Shirts", (short)2 },
                    { (byte)6, (byte)1, (byte)2, "products/men/backpacks", "Backpacks", (short)2 }
                });

            migrationBuilder.InsertData(
                table: "Polls",
                columns: new[] { "Poll_id", "Active", "Question" },
                values: new object[] { (short)1, true, "Do you like this website?" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Size_id", "Name" },
                values: new object[,]
                {
                    { (byte)5, "L" },
                    { (byte)1, "XS" },
                    { (byte)2, "S" },
                    { (byte)3, "M" },
                    { (byte)4, "XL" },
                    { (byte)6, "XXL" }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Slider_id", "Active", "Text", "Title" },
                values: new object[] { 1, true, "Browse our new collection", "Summer collection" });

            migrationBuilder.InsertData(
                table: "Subcategories",
                columns: new[] { "Subcategory_id", "Name" },
                values: new object[,]
                {
                    { (byte)1, "Accessories" },
                    { (byte)21, "Swimwear" },
                    { (byte)19, "Jumpsuits" },
                    { (byte)18, "Dresses" },
                    { (byte)17, "Body" },
                    { (byte)16, "Bags" },
                    { (byte)10, "Underwear" },
                    { (byte)9, "T-Shirts" },
                    { (byte)20, "Skirts" },
                    { (byte)7, "Shoes" },
                    { (byte)6, "Shirts" },
                    { (byte)5, "Jeans" },
                    { (byte)4, "Jackets" },
                    { (byte)3, "Blazers" },
                    { (byte)2, "Backpacks" },
                    { (byte)8, "Trousers" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Type_id", "Name" },
                values: new object[,]
                {
                    { (short)18, "Sunglasses" },
                    { (short)19, "Checked" },
                    { (short)20, "Vests" },
                    { (short)21, "Bomber" },
                    { (short)22, "Denim" },
                    { (short)23, "Regular fit" },
                    { (short)26, "Casual" },
                    { (short)25, "Slim fit" },
                    { (short)27, "Moccasins" },
                    { (short)28, "Chinos" },
                    { (short)29, "Tailored" },
                    { (short)17, "Belts" },
                    { (short)24, "Leather" },
                    { (short)16, "Sleeveless" },
                    { (short)7, "Plain" },
                    { (short)13, "Summer shoes" },
                    { (short)12, "Sneakers" },
                    { (short)11, "High-heels" },
                    { (short)10, "Flats" },
                    { (short)9, "Midi" },
                    { (short)8, "Maxi" },
                    { (short)30, "Striped" },
                    { (short)6, "Lace" },
                    { (short)5, "Large" },
                    { (short)4, "Mini" },
                    { (short)3, "Jewellery" },
                    { (short)2, "Hats" },
                    { (short)1, "Eyewear" },
                    { (short)14, "Basic" },
                    { (short)31, "Printed" }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Option_id", "Name", "Poll_id" },
                values: new object[,]
                {
                    { 1, "Yes", (short)1 },
                    { 2, "No", (short)1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Product_id", "Category_id", "Description", "Name", "Subcategory_id", "Type_id" },
                values: new object[,]
                {
                    { 5, (byte)1, "Cropped faded loose fit jeans with ripped detailing. They feature two side pockets, two back pockets, one coin pocket, belt loops, button fly fastening in the front and frayed hems", "Cropped loose fit jeans", (byte)5, (short)23 },
                    { 4, (byte)1, "Textured weave blazer with a notched lapel collar and a contrasting pin detail in the buttonhole. Features two front flap pockets, one besom pocket at the chest with a pocket square detail, lining with double inside pockets, double back vents, buttoned cuffs and button fastening in the front.", "Birdseye suit blazer", (byte)3, (short)20 },
                    { 2, (byte)1, "Belt with sports buckle and metallic feature on the tip", "Dark brown leather belt", (byte)1, (short)17 },
                    { 1, (byte)1, "Belt with embossed metallic buckle", "Light brown leather belt", (byte)1, (short)17 },
                    { 8, (byte)1, "Sleeveless printed T-shirt with a round neckline. Features a chest pocket", "Floral and swirl printed tank top", (byte)9, (short)16 },
                    { 7, (byte)1, "White plimsolls. Seven-eyelet facing. Embossed detailing on the upper, except for the toe cap and the heel. White soles", "White embossed plimsolls", (byte)7, (short)12 },
                    { 16, (byte)2, "Fuchsia high-heel shoes. Kitten heels. Pointed toes", "Fabric high-heel court shoes", (byte)7, (short)11 },
                    { 13, (byte)2, "Long V-neck dress with short sleeves. Features a wide gathered waist, an asymmetric, frayed hem and button fastening in the front", "Linen dress with topstitching", (byte)18, (short)8 },
                    { 12, (byte)2, "Long red dress", "Long dress", (byte)18, (short)8 },
                    { 11, (byte)2, "Semi-sheer, strappy bodysuit with a V-neckline and snap button fastening on the bottom", "Lace bodysuit", (byte)17, (short)6 },
                    { 14, (byte)2, "Double-breasted waistcoat with high inverted lapel collar. Box pleat detail on the hem in the same fabric. Features front flap pockets and button fastening", "Pleated waistcoat with inverted lapels", (byte)18, (short)4 },
                    { 10, (byte)2, "Multicoloured mini crossbody bag. Multicoloured sequin appliqués on the exterior. Lined interior with pocket", "Multicolored sequinned crossbody bag", (byte)16, (short)4 },
                    { 3, (byte)1, "Metal cuff bracelet", "Metal bracelet", (byte)1, (short)3 },
                    { 15, (byte)2, "Jumpsuit with an elastic neckline and short ruffled sleeves. Features a seam at the waist, a matching fabric belt, a ruffled hem and zip and button fastening in the front", "Floral print short jumpsuit", (byte)19, null },
                    { 6, (byte)1, "Espadrilles with a leather upper and a natural jute sole", "Leather and jute espadrilles", (byte)7, (short)27 },
                    { 9, (byte)1, "Straight, printed T-shirt with a round neckline and short sleeves", "Texture striped t-shirt", (byte)9, (short)30 }
                });

            migrationBuilder.InsertData(
                table: "SliderPhotos",
                columns: new[] { "Photo_id", "Alt", "Slider_id", "Source" },
                values: new object[,]
                {
                    { 2, "Woman cover", 1, "~/images/womancover.jpg" },
                    { 1, "Man cover", 1, "~/images/mancover.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Prices",
                columns: new[] { "Price_id", "Active", "Discount", "Net_price", "Product_id" },
                values: new object[,]
                {
                    { 15L, true, 0.0, 24.0, 15 },
                    { 13L, true, 18.0, 80.0, 13 },
                    { 16L, true, 0.0, 39.0, 16 },
                    { 11L, true, 0.0, 10.0, 11 },
                    { 7L, true, 15.0, 44.0, 7 },
                    { 8L, true, 30.0, 16.0, 8 },
                    { 14L, true, 0.0, 110.0, 14 },
                    { 1L, true, 0.0, 10.0, 1 },
                    { 2L, true, 10.0, 25.0, 2 },
                    { 4L, true, 14.0, 89.0, 4 },
                    { 10L, true, 6.0, 31.0, 10 },
                    { 5L, true, 17.0, 100.0, 5 },
                    { 12L, true, 11.0, 33.0, 12 },
                    { 3L, true, 34.0, 49.0, 3 },
                    { 6L, true, 43.0, 12.0, 6 },
                    { 9L, true, 8.0, 27.0, 9 }
                });

            migrationBuilder.InsertData(
                table: "ProductPhotos",
                columns: new[] { "Photo_id", "Alt", "Product_id", "Source" },
                values: new object[,]
                {
                    { 33, "Dress", 12, "~\\/images\\/WOMEN\\/Dresses\\/Maxi\\/1_3.jpg" },
                    { 24, "T-Shirt", 9, "~\\/images\\/MEN\\/TShirts\\/Striped\\/1_3.jpg" },
                    { 34, "Dress", 13, "~\\/images\\/WOMEN\\/Dresses\\/Maxi\\/3_1.jpg" },
                    { 35, "Dress", 13, "~\\/images\\/WOMEN\\/Dresses\\/Maxi\\/3_2.jpg" },
                    { 36, "Dress", 13, "~\\/images\\/WOMEN\\/Dresses\\/Maxi\\/3_3.jpg" },
                    { 23, "T-Shirt", 9, "~\\/images\\/MEN\\/TShirts\\/Striped\\/1_2.jpg" },
                    { 43, "Shoes", 16, "~\\/images\\/WOMEN\\/Shoes\\/High_heels\\/2_1.jpg" },
                    { 45, "Shoes", 16, "~\\/images\\/WOMEN\\/Shoes\\/High_heels\\/2_3.jpg" },
                    { 22, "T-Shirt", 9, "~\\/images\\/MEN\\/TShirts\\/Striped\\/1_1.jpg" },
                    { 16, "Sneakers", 7, "~\\/images\\/MEN\\/Shoes\\/Sneakers\\/1_1.jpg" },
                    { 17, "Sneakers", 7, "~\\/images\\/MEN\\/Shoes\\/Sneakers\\/1_2.jpg" },
                    { 18, "Sneakers", 7, "~\\/images\\/MEN\\/Shoes\\/Sneakers\\/1_3.jpg" },
                    { 15, "Shoes", 6, "~\\/images\\/MEN\\/Shoes\\/Moccasins\\/2_3.jpg" },
                    { 19, "T-Shirt", 8, "~\\/images\\/MEN\\/TShirts\\/Sleeveless\\/2_1.jpg" },
                    { 20, "T-Shirt", 8, "~\\/images\\/MEN\\/TShirts\\/Sleeveless\\/2_2.jpg" },
                    { 21, "T-Shirt", 8, "~\\/images\\/MEN\\/TShirts\\/Sleeveless\\/2_3.jpg" },
                    { 14, "Shoes", 6, "~\\/images\\/MEN\\/Shoes\\/Moccasins\\/2_2.jpg" },
                    { 13, "Shoes", 6, "~\\/images\\/MEN\\/Shoes\\/Moccasins\\/2_1.jpg" },
                    { 1, "Belt", 1, "~\\/images\\/MEN\\/Accessories\\/Belts\\/1_1.jpg" },
                    { 32, "Dress", 12, "~\\/images\\/WOMEN\\/Dresses\\/Maxi\\/1_2.jpg" },
                    { 3, "Belt", 2, "~\\/images\\/MEN\\/Accessories\\/Belts\\/2_1.jpg" },
                    { 4, "Belt", 2, "~\\/images\\/MEN\\/Accessories\\/Belts\\/2_2.jpg" },
                    { 12, "Jeans", 5, "~\\/images\\/MEN\\/Jeans\\/Regular_fit\\/1_3.jpg" },
                    { 7, "Vest", 4, "~\\/images\\/MEN\\/Blazers\\/Vests\\/1_1.jpg" },
                    { 8, "Vest", 4, "~\\/images\\/MEN\\/Blazers\\/Vests\\/1_2.jpg" },
                    { 11, "Jeans", 5, "~\\/images\\/MEN\\/Jeans\\/Regular_fit\\/1_2.jpg" },
                    { 9, "Vest", 4, "~\\/images\\/MEN\\/Blazers\\/Vests\\/1_3.jpg" },
                    { 10, "Jeans", 5, "~\\/images\\/MEN\\/Jeans\\/Regular_fit\\/1_1.jpg" },
                    { 2, "Belt", 1, "~\\/images\\/MEN\\/Accessories\\/Belts\\/1_2.jpg" },
                    { 44, "Shoes", 16, "~\\/images\\/WOMEN\\/Shoes\\/High_heels\\/2_2.jpg" },
                    { 27, "Bag", 10, "~\\/images\\/WOMEN\\/Bags\\/Mini_bags\\/1_3.jpg" },
                    { 25, "Bag", 10, "~\\/images\\/WOMEN\\/Bags\\/Mini_bags\\/1_1.jpg" },
                    { 26, "Bag", 10, "~\\/images\\/WOMEN\\/Bags\\/Mini_bags\\/1_2.jpg" },
                    { 6, "Bracelet", 3, "~\\/images\\/MEN\\/Accessories\\/Jewellery\\/2_2.jpg" },
                    { 39, "Dress", 14, "~\\/images\\/WOMEN\\/Dresses\\/Mini\\/3_3.jpg" },
                    { 38, "Dress", 14, "~\\/images\\/WOMEN\\/Dresses\\/Mini\\/3_2.jpg" },
                    { 37, "Dress", 14, "~\\/images\\/WOMEN\\/Dresses\\/Mini\\/3_1.jpg" },
                    { 29, "Body", 11, "~\\/images\\/WOMEN\\/Body\\/Lace\\/2_2.jpg" },
                    { 28, "Body", 11, "~\\/images\\/WOMEN\\/Body\\/Lace\\/2_1.jpg" },
                    { 42, "Jumpsuit", 15, "~\\/images\\/WOMEN\\/Jumpsuits\\/2_3.jpg" },
                    { 41, "Jumpsuit", 15, "~\\/images\\/WOMEN\\/Jumpsuits\\/2_2.jpg" },
                    { 40, "Jumpsuit", 15, "~\\/images\\/WOMEN\\/Jumpsuits\\/2_1.jpg" },
                    { 31, "Dress", 12, "~\\/images\\/WOMEN\\/Dresses\\/Maxi\\/1_1.jpg" },
                    { 5, "Bracelet", 3, "~\\/images\\/MEN\\/Accessories\\/Jewellery\\/2_1.jpg" },
                    { 30, "Body", 11, "~\\/images\\/WOMEN\\/Body\\/Lace\\/2_3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductVariant_Id", "Color_id", "Product_id", "Quantity", "Size_id" },
                values: new object[,]
                {
                    { 7L, (byte)3, 4, 15, (byte)3 },
                    { 5L, (byte)1, 4, 15, (byte)1 },
                    { 6L, (byte)4, 4, 15, (byte)4 },
                    { 43L, (byte)5, 11, 15, (byte)3 },
                    { 3L, null, 3, 15, null },
                    { 2L, (byte)2, 2, 20, null },
                    { 32L, (byte)2, 10, 15, (byte)1 },
                    { 33L, (byte)1, 10, 15, (byte)1 },
                    { 34L, (byte)4, 10, 15, (byte)4 },
                    { 1L, (byte)2, 1, 12, null },
                    { 4L, (byte)2, 4, 15, (byte)1 },
                    { 8L, (byte)5, 4, 15, (byte)5 },
                    { 67L, (byte)5, 15, 15, (byte)3 },
                    { 35L, (byte)3, 10, 15, (byte)3 },
                    { 29L, (byte)3, 9, 15, (byte)3 },
                    { 28L, (byte)4, 9, 15, (byte)4 },
                    { 61L, (byte)5, 15, 15, (byte)3 },
                    { 17L, (byte)5, 6, 15, (byte)3 },
                    { 16L, (byte)5, 6, 15, (byte)5 },
                    { 15L, (byte)3, 6, 15, (byte)3 },
                    { 14L, (byte)4, 6, 15, (byte)4 },
                    { 9L, (byte)5, 4, 15, (byte)3 },
                    { 62L, (byte)2, 15, 15, (byte)1 },
                    { 64L, (byte)4, 15, 15, (byte)4 },
                    { 65L, (byte)3, 15, 15, (byte)3 },
                    { 13L, (byte)5, 5, 15, (byte)3 },
                    { 12L, (byte)5, 5, 15, (byte)5 },
                    { 11L, (byte)3, 5, 15, (byte)3 },
                    { 10L, (byte)4, 5, 15, (byte)4 },
                    { 66L, (byte)5, 15, 15, (byte)5 },
                    { 63L, (byte)1, 15, 15, (byte)1 },
                    { 36L, (byte)5, 10, 15, (byte)5 },
                    { 25L, (byte)5, 8, 15, (byte)3 },
                    { 27L, (byte)1, 8, 15, (byte)1 },
                    { 54L, (byte)5, 13, 15, (byte)5 },
                    { 53L, (byte)3, 13, 15, (byte)3 },
                    { 52L, (byte)4, 13, 15, (byte)4 },
                    { 51L, (byte)1, 13, 15, (byte)1 },
                    { 50L, (byte)2, 13, 15, (byte)1 },
                    { 38L, (byte)2, 11, 15, (byte)1 },
                    { 39L, (byte)1, 11, 15, (byte)1 },
                    { 55L, (byte)5, 13, 15, (byte)3 },
                    { 40L, (byte)4, 11, 15, (byte)4 },
                    { 49L, (byte)5, 12, 15, (byte)3 },
                    { 48L, (byte)5, 12, 15, (byte)5 },
                    { 47L, (byte)3, 12, 15, (byte)3 },
                    { 46L, (byte)4, 12, 15, (byte)4 },
                    { 45L, (byte)1, 12, 15, (byte)1 },
                    { 44L, (byte)2, 12, 15, (byte)1 },
                    { 42L, (byte)5, 11, 15, (byte)5 },
                    { 41L, (byte)3, 11, 15, (byte)3 },
                    { 30L, (byte)5, 9, 15, (byte)5 },
                    { 68L, (byte)2, 16, 15, (byte)1 },
                    { 69L, (byte)1, 16, 15, (byte)1 },
                    { 26L, (byte)2, 8, 15, (byte)1 },
                    { 24L, (byte)5, 8, 15, (byte)5 },
                    { 23L, (byte)3, 8, 15, (byte)3 },
                    { 22L, (byte)4, 8, 15, (byte)4 },
                    { 56L, (byte)2, 14, 15, (byte)1 },
                    { 21L, (byte)5, 7, 15, (byte)3 },
                    { 20L, (byte)5, 7, 15, (byte)5 },
                    { 19L, (byte)3, 7, 15, (byte)3 },
                    { 18L, (byte)4, 7, 15, (byte)4 },
                    { 57L, (byte)1, 14, 15, (byte)1 },
                    { 58L, (byte)4, 14, 15, (byte)4 },
                    { 59L, (byte)3, 14, 15, (byte)3 },
                    { 60L, (byte)5, 14, 15, (byte)5 },
                    { 73L, (byte)5, 16, 15, (byte)3 },
                    { 72L, (byte)5, 16, 15, (byte)5 },
                    { 71L, (byte)3, 16, 15, (byte)3 },
                    { 70L, (byte)4, 16, 15, (byte)4 },
                    { 37L, (byte)5, 10, 15, (byte)3 },
                    { 31L, (byte)5, 9, 15, (byte)3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Options_Poll_id",
                table: "Options",
                column: "Poll_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ordereds_Order_Id",
                table: "Ordereds",
                column: "Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ordereds_ProductVariant_Id",
                table: "Ordereds",
                column: "ProductVariant_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_Product_id",
                table: "Prices",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPhotos_Product_id",
                table: "ProductPhotos",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Category_id",
                table: "Products",
                column: "Category_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Subcategory_id",
                table: "Products",
                column: "Subcategory_id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Type_id",
                table: "Products",
                column: "Type_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_Color_id",
                table: "ProductVariants",
                column: "Color_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_Product_id",
                table: "ProductVariants",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_Size_id",
                table: "ProductVariants",
                column: "Size_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_Product_id",
                table: "Ratings",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SliderPhotos_Slider_id",
                table: "SliderPhotos",
                column: "Slider_id");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_Option_id",
                table: "Votes",
                column: "Option_id");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_UserId",
                table: "Votes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FooterMenus");

            migrationBuilder.DropTable(
                name: "HeadingMenus");

            migrationBuilder.DropTable(
                name: "Ordereds");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "ProductPhotos");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "SliderPhotos");

            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Polls");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Subcategories");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
