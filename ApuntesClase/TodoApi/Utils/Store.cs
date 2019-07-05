using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.Utils
{
    public sealed class Store
    {
        private readonly static Store _instance = new Store();
        public List<TodoItem> todos = new List<TodoItem>();

        public Store()
        {
        }

        public static Store Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}