using System;
using System.Collections.Generic;

namespace ToDo.Models.ViewModel
{
	public class ToDoViewModel
	{
		public List<ToDoItem> TodoList { get; set; }
		public ToDoItem Todo { get; set; }
	}
}

