using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [NotMapped]
        public int AgeInMonths { 
            get 
            { 
                return Multiply(Age, 12); 
            } 
        }

        /// <summary>
        /// Multiple x times y without using built in multiply operator.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private int Multiply(int x, int y)
        {
            int result = 0;

            for(int iteration=0;iteration<y;iteration++)
            {
                result = result + x;
            }

            return result;
        }
    }
}
