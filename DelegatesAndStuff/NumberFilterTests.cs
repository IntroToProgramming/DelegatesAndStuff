using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DelegatesAndStuff
{
    public class NumberFilterTests
    {
        [Fact]
        public void CanFilterOutOdds()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numberFilter = new NumberFilter();


            List<int> evens = numberFilter.FilterOutOdds(numbers);

            Assert.Equal(2, evens[0]);
            Assert.Equal(4, evens[1]);
            // etc. etc.
        }

        [Fact]
        public void CanFilterOutEvens()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numberFilter = new NumberFilter();


            List<int> evens = numberFilter.FilterOutEvens(numbers);

            Assert.Equal(1, evens[0]);
            Assert.Equal(3, evens[1]);
            // etc. etc.
        }
    }
}
