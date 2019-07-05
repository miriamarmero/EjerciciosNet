using System.Collections.Generic;
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
            item.Id = this.store.todos.Count;
            return item;
        }

        [HttpGet("{id}")]
        public TodoItem GetTodoItems(long id){
            return this.store.todos.Find(todo => {
                System.Console.WriteLine("todo: " + todo.Id);
                return todo.Id == id;
            });
        }

        [HttpGet("busqueda/{input}")]
        public List<TodoItem> GetTodoItems(string input){
            return this.store.todos.FindAll(todo => {
                return todo.Name.Contains(input);
            });
        }

        [HttpGet("done")]
        public List<TodoItem> GetTodoIsCompleted(){
            return this.store.todos.FindAll(todo => {
                return todo.IsComplete == true;
            });
        }

        [HttpPatch("done/{id}")]
        public TodoItem PatchTodoIsCompleted(long id){
            int posicion = this.store.todos.FindIndex(todo => todo.Id == id);
            this.store.todos[posicion].IsComplete = true;
            return this.store.todos[posicion];
        }

        [HttpDelete("{id}")]
        public TodoItem DeleteTodoId(long id){
            return this.store.todos.Find(todo => {
                return todo.Id == id;
            });
        }
    }
}