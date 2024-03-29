﻿using Module25EF.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module25EF.PLL.Views.UserViews
{
    public class UserBooksView
    {

        public void Show(User user)
        {
            Message.Blue("Ваши книги:");
            user.Books.ForEach(b =>
            {
                Console.WriteLine($"<<Id: {b.Id}, Название: {b.Title}, Автор: {b.Author.Name},\nГод выпуска: {b.ReleaseYear}, Жанр: {b.Genre.Title}, Стоимость: {b.Cost}>>");
            });
        }
    }
}
