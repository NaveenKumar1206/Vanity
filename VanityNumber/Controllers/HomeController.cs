using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VanityNumber.Controllers
{

    [ApiController]
    public class HomeController : ControllerBase
    {


        /// <summary>
        /// +1-541-754-3010
        /// </summary>
        /// <remarks>+1-541-754-3010</remarks>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        [Route("api/PhoneNumberCombinations")]
        [HttpGet]
        public JsonResult PhoneNumberCombinations(string phoneNumber)
        {
            JsonResult result = new JsonResult("");
            Queue<string> queue = new Queue<string>();


            if (phoneNumber.Length == 0) { result.Value = phoneNumber; }
            if (phoneNumber.Length > 0)
            {
                string temp;
                queue.Enqueue("");

                for (int i = 0; i < phoneNumber.Length; i++)
                {
                    string x = Helper.MapAlphabet(phoneNumber.Substring(i, 1));

                    while (queue.Peek().Length < i + 1)
                    {
                        temp = queue.Dequeue();
                        foreach (char c in x.ToCharArray())
                        {
                            queue.Enqueue(temp + c);
                        }
                    }
                }
            }
            result.Value = queue.ToArray();
            return result;
        }
              
    }
}
