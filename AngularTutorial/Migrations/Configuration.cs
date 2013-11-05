using AngularTutorial.Models;

namespace AngularTutorial.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AngularTutorial.Models.AngularTutorialContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AngularTutorial.Models.AngularTutorialContext context)
        {
            var r = new Random();
            var counter = 0;
            var items = Enumerable.Range(1, 50).Select(o => new TodoItem
            {
                TodoItemId = o,
                DueDate = new DateTime(2013, r.Next(1, 12), r.Next(1, 28)),
                Priority = (byte)r.Next(10),
                Todo = o.ToString(),
                Added = DateTime.Today
            }).ToArray();
            context.TodoItems.AddOrUpdate(item => new { item.Todo }, items);
        }
    }
}
