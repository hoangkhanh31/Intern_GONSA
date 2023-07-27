using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Cấu hình kết nối cơ sở dữ liệu
            optionsBuilder.UseSqlServer("your_connection_string_here");
        }
    }

    public class Employee
    {
        // Định nghĩa các thuộc tính cho bảng Employees
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
