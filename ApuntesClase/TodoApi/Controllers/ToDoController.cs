using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Utils;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        /* private TodoItem[] todos = new TodoItem[20]; */
        //Cambias el array por la lista
        // private List<TodoItem> todos = new List<TodoItem>();
        private Store store = Store.Instance;


        [HttpGet]
        public List<TodoItem> GetTodoItems(){
            return this.store.todos;
        }

        [HttpPost]
        public TodoItem PostTodo(TodoItem item){
            this.store.todos.Add(item);
            return item;
        }
    }
}