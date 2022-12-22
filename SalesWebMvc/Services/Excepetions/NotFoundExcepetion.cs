using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Excepetions
{
	public class NotFoundExcepetion : ApplicationException
	{
		public NotFoundExcepetion(string message) : base(message)
		{

		}
	}
}
