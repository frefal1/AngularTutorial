using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Data.Entity.Migrations;
using AngularTutorial.Models;

namespace AngularTutorial.Helpers
{
    public class ListHelper
    {
        readonly AngularTutorialContext _context;

        public ListHelper()
        {
            _context = new AngularTutorialContext();
        }

        public List<TodoItem> GetAllItems()
        {
            using (var context = _context)
            {
                var items = from i in context.TodoItems
                         where i.TodoText.StartsWith("spotify:user:")
                         select i;
                List<TodoItem> allItems = items.ToList();
                return allItems;
                
            }
        }

        //public List<TodoItem> GetRecentlyAdded()
        //{
        //  //  return GetAllItems().OrderByDescending(x => x.Added).Take(5);
        //}

    }
}