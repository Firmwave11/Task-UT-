using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace loker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LokerController : ControllerBase
    {
        [HttpGet("{loker}")]
        public IActionResult GetLantai(int loker)
        {
            try{
            int nilai = loker ;
            
            int lantai = 1;
            int[] myNum;
            myNum = new int[] {9,3,7,2};

            for (int i = 1; i<=loker ;i++){
                foreach(int j in myNum){
                    nilai = nilai - j;
                    if (nilai<=0){
                        break;
                    }else{
                        lantai += 1;
                    }
                }
            }
            var lante = new Loker();
            lante.noLantai = lantai;
            return Ok(lante);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return BadRequest(ex.Message);
            }
        }
    }
}
