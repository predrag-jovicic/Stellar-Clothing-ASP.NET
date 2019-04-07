using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Commerce_Web_App.Migrations
{
    public partial class HeadingMenuSchemeUpdatedAndImagesPathEdited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "HeadingMenus");

            migrationBuilder.AlterColumn<byte>(
                name: "Parent",
                table: "HeadingMenus",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AddColumn<bool>(
                name: "HasChildren",
                table: "HeadingMenus",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)1,
                column: "Parent",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)2,
                columns: new[] { "HasChildren", "Parent" },
                values: new object[] { true, (byte)0 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)3,
                columns: new[] { "HasChildren", "Parent" },
                values: new object[] { true, (byte)0 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)4,
                column: "Parent",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)5,
                column: "Parent",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)6,
                column: "Parent",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)7,
                column: "Parent",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)8,
                column: "Parent",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)9,
                column: "Parent",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)10,
                column: "Parent",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)11,
                column: "Parent",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)12,
                column: "Parent",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)13,
                columns: new[] { "Link", "Parent" },
                values: new object[] { "products/men/t-shirts", (byte)2 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)14,
                column: "Parent",
                value: (byte)2);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)15,
                column: "Parent",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)16,
                column: "Parent",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)17,
                column: "Parent",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)18,
                column: "Parent",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)19,
                column: "Parent",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)20,
                column: "Parent",
                value: (byte)3);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)21,
                columns: new[] { "Link", "Parent" },
                values: new object[] { "products/women/shoes", (byte)3 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)22,
                columns: new[] { "Link", "Parent" },
                values: new object[] { "products/women/skirts", (byte)3 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)23,
                columns: new[] { "Link", "Parent" },
                values: new object[] { "products/women/swimwear", (byte)3 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)24,
                columns: new[] { "Link", "Parent" },
                values: new object[] { "products/women/t-shirts", (byte)3 });

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 1,
                column: "Source",
                value: "/images/MEN/Accessories/Belts/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 2,
                column: "Source",
                value: "/images/MEN/Accessories/Belts/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 3,
                column: "Source",
                value: "/images/MEN/Accessories/Belts/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 4,
                column: "Source",
                value: "/images/MEN/Accessories/Belts/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 5,
                column: "Source",
                value: "/images/MEN/Accessories/Jewellery/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 6,
                column: "Source",
                value: "/images/MEN/Accessories/Jewellery/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 7,
                column: "Source",
                value: "/images/MEN/Blazers/Vests/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 8,
                column: "Source",
                value: "/images/MEN/Blazers/Vests/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 9,
                column: "Source",
                value: "/images/MEN/Blazers/Vests/1_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 10,
                column: "Source",
                value: "/images/MEN/Jeans/Regular_fit/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 11,
                column: "Source",
                value: "/images/MEN/Jeans/Regular_fit/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 12,
                column: "Source",
                value: "/images/MEN/Jeans/Regular_fit/1_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 13,
                column: "Source",
                value: "/images/MEN/Shoes/Moccasins/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 14,
                column: "Source",
                value: "/images/MEN/Shoes/Moccasins/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 15,
                column: "Source",
                value: "/images/MEN/Shoes/Moccasins/2_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 16,
                column: "Source",
                value: "/images/MEN/Shoes/Sneakers/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 17,
                column: "Source",
                value: "/images/MEN/Shoes/Sneakers/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 18,
                column: "Source",
                value: "/images/MEN/Shoes/Sneakers/1_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 19,
                column: "Source",
                value: "/images/MEN/TShirts/Sleeveless/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 20,
                column: "Source",
                value: "/images/MEN/TShirts/Sleeveless/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 21,
                column: "Source",
                value: "/images/MEN/TShirts/Sleeveless/2_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 22,
                column: "Source",
                value: "/images/MEN/TShirts/Striped/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 23,
                column: "Source",
                value: "/images/MEN/TShirts/Striped/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 24,
                column: "Source",
                value: "/images/MEN/TShirts/Striped/1_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 25,
                column: "Source",
                value: "/images/WOMEN/Bags/Mini_bags/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 26,
                column: "Source",
                value: "/images/WOMEN/Bags/Mini_bags/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 27,
                column: "Source",
                value: "/images/WOMEN/Bags/Mini_bags/1_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 28,
                column: "Source",
                value: "/images/WOMEN/Body/Lace/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 29,
                column: "Source",
                value: "/images/WOMEN/Body/Lace/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 30,
                column: "Source",
                value: "/images/WOMEN/Body/Lace/2_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 31,
                column: "Source",
                value: "/images/WOMEN/Dresses/Maxi/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 32,
                column: "Source",
                value: "/images/WOMEN/Dresses/Maxi/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 33,
                column: "Source",
                value: "/images/WOMEN/Dresses/Maxi/1_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 34,
                column: "Source",
                value: "/images/WOMEN/Dresses/Maxi/3_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 35,
                column: "Source",
                value: "/images/WOMEN/Dresses/Maxi/3_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 36,
                column: "Source",
                value: "/images/WOMEN/Dresses/Maxi/3_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 37,
                column: "Source",
                value: "/images/WOMEN/Dresses/Mini/3_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 38,
                column: "Source",
                value: "/images/WOMEN/Dresses/Mini/3_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 39,
                column: "Source",
                value: "/images/WOMEN/Dresses/Mini/3_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 40,
                column: "Source",
                value: "/images/WOMEN/Jumpsuits/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 41,
                column: "Source",
                value: "/images/WOMEN/Jumpsuits/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 42,
                column: "Source",
                value: "/images/WOMEN/Jumpsuits/2_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 43,
                column: "Source",
                value: "/images/WOMEN/Shoes/High_heels/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 44,
                column: "Source",
                value: "/images/WOMEN/Shoes/High_heels/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 45,
                column: "Source",
                value: "/images/WOMEN/Shoes/High_heels/2_3.jpg");

            migrationBuilder.UpdateData(
                table: "SliderPhotos",
                keyColumn: "Photo_id",
                keyValue: 1,
                column: "Source",
                value: "/images/mancover.jpg");

            migrationBuilder.UpdateData(
                table: "SliderPhotos",
                keyColumn: "Photo_id",
                keyValue: 2,
                column: "Source",
                value: "/images/womancover.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasChildren",
                table: "HeadingMenus");

            migrationBuilder.AlterColumn<short>(
                name: "Parent",
                table: "HeadingMenus",
                nullable: false,
                oldClrType: typeof(byte));

            migrationBuilder.AddColumn<byte>(
                name: "Level",
                table: "HeadingMenus",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)1,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)1, (short)0 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)2,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)1, (short)0 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)3,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)1, (short)0 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)4,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)1, (short)0 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)5,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)2 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)6,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)2 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)7,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)2 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)8,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)2 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)9,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)2 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)10,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)2 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)11,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)2 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)12,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)2 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)13,
                columns: new[] { "Level", "Link", "Parent" },
                values: new object[] { (byte)2, "products/men/tshirts", (short)2 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)14,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)2 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)15,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)3 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)16,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)3 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)17,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)3 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)18,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)3 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)19,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)3 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)20,
                columns: new[] { "Level", "Parent" },
                values: new object[] { (byte)2, (short)3 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)21,
                columns: new[] { "Level", "Link", "Parent" },
                values: new object[] { (byte)2, "products/women/jumpsuits", (short)3 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)22,
                columns: new[] { "Level", "Link", "Parent" },
                values: new object[] { (byte)2, "products/women/jumpsuits", (short)3 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)23,
                columns: new[] { "Level", "Link", "Parent" },
                values: new object[] { (byte)2, "products/women/jumpsuits", (short)3 });

            migrationBuilder.UpdateData(
                table: "HeadingMenus",
                keyColumn: "HeadingItem_id",
                keyValue: (byte)24,
                columns: new[] { "Level", "Link", "Parent" },
                values: new object[] { (byte)2, "products/women/jumpsuits", (short)3 });

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 1,
                column: "Source",
                value: "~\\/images\\/MEN\\/Accessories\\/Belts\\/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 2,
                column: "Source",
                value: "~\\/images\\/MEN\\/Accessories\\/Belts\\/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 3,
                column: "Source",
                value: "~\\/images\\/MEN\\/Accessories\\/Belts\\/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 4,
                column: "Source",
                value: "~\\/images\\/MEN\\/Accessories\\/Belts\\/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 5,
                column: "Source",
                value: "~\\/images\\/MEN\\/Accessories\\/Jewellery\\/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 6,
                column: "Source",
                value: "~\\/images\\/MEN\\/Accessories\\/Jewellery\\/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 7,
                column: "Source",
                value: "~\\/images\\/MEN\\/Blazers\\/Vests\\/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 8,
                column: "Source",
                value: "~\\/images\\/MEN\\/Blazers\\/Vests\\/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 9,
                column: "Source",
                value: "~\\/images\\/MEN\\/Blazers\\/Vests\\/1_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 10,
                column: "Source",
                value: "~\\/images\\/MEN\\/Jeans\\/Regular_fit\\/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 11,
                column: "Source",
                value: "~\\/images\\/MEN\\/Jeans\\/Regular_fit\\/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 12,
                column: "Source",
                value: "~\\/images\\/MEN\\/Jeans\\/Regular_fit\\/1_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 13,
                column: "Source",
                value: "~\\/images\\/MEN\\/Shoes\\/Moccasins\\/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 14,
                column: "Source",
                value: "~\\/images\\/MEN\\/Shoes\\/Moccasins\\/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 15,
                column: "Source",
                value: "~\\/images\\/MEN\\/Shoes\\/Moccasins\\/2_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 16,
                column: "Source",
                value: "~\\/images\\/MEN\\/Shoes\\/Sneakers\\/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 17,
                column: "Source",
                value: "~\\/images\\/MEN\\/Shoes\\/Sneakers\\/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 18,
                column: "Source",
                value: "~\\/images\\/MEN\\/Shoes\\/Sneakers\\/1_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 19,
                column: "Source",
                value: "~\\/images\\/MEN\\/TShirts\\/Sleeveless\\/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 20,
                column: "Source",
                value: "~\\/images\\/MEN\\/TShirts\\/Sleeveless\\/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 21,
                column: "Source",
                value: "~\\/images\\/MEN\\/TShirts\\/Sleeveless\\/2_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 22,
                column: "Source",
                value: "~\\/images\\/MEN\\/TShirts\\/Striped\\/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 23,
                column: "Source",
                value: "~\\/images\\/MEN\\/TShirts\\/Striped\\/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 24,
                column: "Source",
                value: "~\\/images\\/MEN\\/TShirts\\/Striped\\/1_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 25,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Bags\\/Mini_bags\\/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 26,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Bags\\/Mini_bags\\/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 27,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Bags\\/Mini_bags\\/1_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 28,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Body\\/Lace\\/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 29,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Body\\/Lace\\/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 30,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Body\\/Lace\\/2_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 31,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Dresses\\/Maxi\\/1_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 32,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Dresses\\/Maxi\\/1_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 33,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Dresses\\/Maxi\\/1_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 34,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Dresses\\/Maxi\\/3_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 35,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Dresses\\/Maxi\\/3_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 36,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Dresses\\/Maxi\\/3_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 37,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Dresses\\/Mini\\/3_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 38,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Dresses\\/Mini\\/3_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 39,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Dresses\\/Mini\\/3_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 40,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Jumpsuits\\/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 41,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Jumpsuits\\/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 42,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Jumpsuits\\/2_3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 43,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Shoes\\/High_heels\\/2_1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 44,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Shoes\\/High_heels\\/2_2.jpg");

            migrationBuilder.UpdateData(
                table: "ProductPhotos",
                keyColumn: "Photo_id",
                keyValue: 45,
                column: "Source",
                value: "~\\/images\\/WOMEN\\/Shoes\\/High_heels\\/2_3.jpg");

            migrationBuilder.UpdateData(
                table: "SliderPhotos",
                keyColumn: "Photo_id",
                keyValue: 1,
                column: "Source",
                value: "~/images/mancover.jpg");

            migrationBuilder.UpdateData(
                table: "SliderPhotos",
                keyColumn: "Photo_id",
                keyValue: 2,
                column: "Source",
                value: "~/images/womancover.jpg");
        }
    }
}
