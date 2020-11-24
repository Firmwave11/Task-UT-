using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace loker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LokerController : ControllerBase
    {
        [HttpGet("{loker}")]
        public string Get(int loker)
        {
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
            
            return "Lantai " + lantai;
        }
    }
}
