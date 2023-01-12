using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
     

        public Result(bool succes, string message):this(succes) //this demek classın kendisi demek 
                                                                //bu bölümde iki paramtleri olarak gönderdiğimizde aşağıdaki cons. da çalışcaktır.
        {
           Message= message;    
           
        }
        public Result(bool succes)
        {
            //buradaki işlem cons. overloadingdir. // iki farklı metodumuz varmış gibi bir davranış sergiler
            Success = succes;

        }
        public bool Success { get; }

        public string Message { get; }// getter read onlydir read onlyler constructorlarla set edilebilir.
    }
}
