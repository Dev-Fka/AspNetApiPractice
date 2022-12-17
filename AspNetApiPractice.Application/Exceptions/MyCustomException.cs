using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetApiPractice.Application.Exceptions
{
    public class MyCustomException: Exception
    {
            public MyCustomException() : base("My error occured")
            {

            }
            public MyCustomException(string message) : base(message)
            {

            }
            public MyCustomException(Exception exception) : this(exception.Message)
            {

            }
        

    }
}
