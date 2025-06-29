using AnhBui.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnhBui.Data
{
    public class AnhBuiDbContext : IdentityDbContext
    {
        public AnhBuiDbContext(DbContextOptions<AnhBuiDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        // seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product 
                { Id = 1,
                    Name = "Áo Thun",
                    Price = 75000, 
                    Detail = "Áo thun cotton 100%, mềm mại và thoáng mát, form unisex dễ mặc cho cả nam và nữ.",
                    ImageUrl = "https://dosi-in.com/images/detailed/42/CDL10_1.jpg",
                    IsTrendingProduct = true
                },
                new Product 
                { Id = 2,
                    Name = "Áo Khoác",
                    Price = 200000, 
                    Detail = "Áo khoác vải dù nhẹ, chống gió tốt, thiết kế có mũ tiện lợi cho ngày mưa.",
                    ImageUrl = "https://www.chapi.vn/img/product/2021/11/20/ao-khoac-nam-trung-nien-co-be-bhg-18-new.jpg",
                    IsTrendingProduct = true 
                },
                new Product 
                { Id = 3,
                    Name = "Áo Len",
                    Price = 150000,
                    Detail = "Áo len chất dệt kim mềm mại, giữ ấm tốt nhưng vẫn thoáng khí.",
                    ImageUrl = "https://4menshop.com/images/thumbs/2023/07/ao-len-phoi-mau-al011-mau-do-18179.jpg",
                    IsTrendingProduct = true
                },
                new Product 
                { Id = 4,
                    Name = "Quần Jean",
                    Price = 125000,
                    Detail = "Quần jean co giãn nhẹ, lên form đẹp, thoải mái vận động cả ngày.",
                    ImageUrl = "https://th.bing.com/th/id/OIP.sOahbQYxx6aZynZjlygcaAHaLH?w=640&h=960&rs=1&pid=ImgDetMain&cb=idpwebp2&o=7&rm=3",
                    IsTrendingProduct = true 
                },
                new Product 
                { Id = 5,
                    Name = "Quần Tây",
                    Price = 250000,
                    Detail = "Quần tây vải mềm mịn, đứng form chuẩn, phù hợp đi làm hoặc đi học.",
                    ImageUrl = "https://4menshop.com/images/thumbs/2022/02/quan-tay-tron-regular-mau-den-qt026-16143.jpg",
                    IsTrendingProduct = true 
                },
                new Product 
                { Id = 6,
                    Name = "Bộ Quần Áo Thể Thao",
                    Price = 150000,
                    Detail = "Bộ thể thao thun lạnh co giãn 4 chiều, thấm hút mồ hôi cực tốt.",
                    ImageUrl = "https://cf.shopee.vn/file/606ec435877c83e0e550e93b28bac804",
                    IsTrendingProduct = true 
                }
            );
        }
    }
}