    using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;
using ToDo.Models;
using ToDo.Models.ViewModel;

namespace ToDo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            var todoListViewModel = GetAllTodos();
            return View(todoListViewModel);
        }

        [HttpGet]
        public JsonResult PopulateForm(int id)
        {
            var todo = GetById(id);
            return Json(todo);
        }
        [HttpGet]
        //public JsonResult completeTodo(int id)
        //{
        //    var todo = GetById(id);
        //    return Json(todo);
        //}

        internal ToDoViewModel GetAllTodos()
        {
            List<ToDoItem> todoList = new();
            using (SqliteConnection con =
                   new SqliteConnection("Data Source=db.sqlite"))
            {
                using (var tableCmd = con.CreateCommand())
                {
                    con.Open();
                    tableCmd.CommandText = "SELECT * FROM todo";

                    using (var reader = tableCmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                todoList.Add(
                                    new ToDoItem
                                    {
                                        intID = reader.GetInt32(0),
                                        Name = reader.GetString(1),
                                        isComplete = reader.GetString(2)
                                    });
                            }
                        }
                        else
                        {
                            return new ToDoViewModel
                            {
                                TodoList = todoList
                            };
                        }
                    };
                }
            }

            return new ToDoViewModel
            {
                TodoList = todoList
            };
        }

        internal ToDoItem GetById(int id)
        {
            ToDoItem todo = new();

            using (var connection =
                   new SqliteConnection("Data Source=db.sqlite"))
            {
                using (var tableCmd = connection.CreateCommand())
                {
                    connection.Open();
                    tableCmd.CommandText = $"SELECT * FROM todo Where Id = '{id}'";

                    using (var reader = tableCmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            todo.intID = reader.GetInt32(0);
                            todo.Name = reader.GetString(1);
                            todo.isComplete = reader.GetString(2);
                        }
                        else
                        {
                            return todo;
                        }
                    };
                }
            }

            return todo;
        }

        public RedirectResult Insert(ToDoItem todo)
        {
            using (SqliteConnection con =
                   new SqliteConnection("Data Source=db.sqlite"))
            {
                using (var tableCmd = con.CreateCommand())
                {
                    con.Open();
                    tableCmd.CommandText = $"INSERT INTO todo (name , iscomplete) VALUES ('{todo.Name}','{"No"}')";
                    try
                    {
                        tableCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return Redirect("https://localhost:5001/");
        }
        [HttpPost]
        public JsonResult Delete(int id)
        {
            using (SqliteConnection con =
                   new SqliteConnection("Data Source=db.sqlite"))
            {
                using (var tableCmd = con.CreateCommand())
                {
                    con.Open();
                    tableCmd.CommandText = $"DELETE from todo WHERE Id = '{id}'";
                    tableCmd.ExecuteNonQuery();
                }
            }

            return Json(new { });
        }
        [HttpPost]
        public JsonResult completeTodo(int id)
        {
            using (SqliteConnection con =
                   new SqliteConnection("Data Source=db.sqlite"))
            {
                using (var tableCmd = con.CreateCommand())
                {
                    con.Open();
                    tableCmd.CommandText = $"UPDATE todo SET isComplete = '{"Yes"}' WHERE Id = '{id}'";
                    tableCmd.ExecuteNonQuery();
                }
            }

            return Json(new { });
        }

        //public RedirectResult Complete(ToDoItem todo)
        //{
        //    using (SqliteConnection con =
        //           new SqliteConnection("Data Source=db.sqlite"))
        //    {
        //        using (var tableCmd = con.CreateCommand())
        //        {
        //            con.Open();
        //            tableCmd.CommandText = $"UPDATE todo SET isComplete = '{"Yes"}' WHERE Id = '{todo.intID}'";
        //            try
        //            {
        //                tableCmd.ExecuteNonQuery();
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //        }
        //    }

        //    return Redirect("https://localhost:5001/");
        //}
        public RedirectResult Update(ToDoItem todo)
        {
            using (SqliteConnection con =
                   new SqliteConnection("Data Source=db.sqlite"))
            {
                using (var tableCmd = con.CreateCommand())
                {
                    con.Open();
                    tableCmd.CommandText = $"UPDATE todo SET name = '{todo.Name}' WHERE Id = '{todo.intID}'";
                    try
                    {
                        tableCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return Redirect("https://localhost:5001/");
        }

    }

}

