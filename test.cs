namespace Test
{
    using System;
    using Microsoft.AspNetCore.Mvc;

    public class Program
    {
        static void Main()
        {
            var controller = new Controller();

            var result1 = controller.GetResponse1("message1");
            var result2 = controller.GetResponse2("message2");
            var result3 = controller.GetResponse3("message3");

            Console.WriteLine($"Response1: {result1.Value}");
            Console.WriteLine($"Response2: {result2.Value}");

            Console.WriteLine($"Response3: {result3.Value}");
            Console.WriteLine($"Response3: {(result3.Result as ObjectResult).Value as string}");
        }

        private class Controller : ControllerBase
        {
            public ActionResult<string> GetResponse1(string message)
            {
                return new ActionResult<string>(message);
            }

            public ActionResult<string> GetResponse2(string message)
            {
                return message;
            }

            public ActionResult<string> GetResponse3(string message)
            {
                return Ok(message);
            }
        }
    }
}
