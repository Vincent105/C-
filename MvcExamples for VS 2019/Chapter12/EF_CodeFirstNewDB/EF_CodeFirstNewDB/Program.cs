﻿using System;
using System.Linq;
using EF_CodeFirstNewDB.Models;

namespace EF_CodeFirstNewDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogContext())
            {
                if (!context.Users.Any())
                {
                    //新增Entity
                    User user = new User { UserName = "聖殿祭司", Email = "dotnetcool@gmail.com" };
                    context.Users.Add(user);    //將Entity加入Users DbSet
                    context.SaveChanges();      //儲存異動, 將資料寫入資料庫
                }
                

                //讀取資料
                foreach(var item in context.Users)
                {
                    Console.WriteLine($"Name : {item.UserName}, Email : {item.Email}");
                }

                Console.WriteLine("請按任一鍵離開...");
                Console.ReadKey();
            }
        }
    }
}
