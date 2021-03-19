using DelegatesAndStuff.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DelegatesAndStuff
{
    public class StaticStuff
    {
        private readonly ITestOutputHelper output;

        public StaticStuff(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void AnonymousTypes()
        {
            var meeting = new { Time = "Noon", Where = "Zoom" };
            Assert.Equal("Noon", meeting.Time);
            Assert.Equal("Zoom", meeting.Where);
            

            var friends = new List<string> { "Tim", "Billy", "Sue", "Ray" };

            var friendInfo = friends
                .Where(f => f.Length >= 3)
                .Select(f => new
                {
                    Name = f,
                    NameInUpper = f.ToUpper(),
                    Letters = f.Length
                });

            foreach(var friend in friendInfo)
            {
                output.WriteLine(friend.Name + " has this many letters" +
                    friend.Letters);
            }
        }

        public override bool Equals(object obj)
        {
            return obj is StaticStuff stuff &&
                   EqualityComparer<ITestOutputHelper>.Default.Equals(output, stuff.output);
        }

        [Fact]
        public void UsingAStaticMethod()
        {
            var numbers = new List<int> { 1, 2, 3, 4 };
           
      

            var name = Utils.FormatName("Luke", "Skywalker");
            Assert.Equal("Skywalker, Luke", name);

            
            Assert.True(14.IsEven());
            Assert.False(13.IsEven());
            Assert.Equal("<p>Awesome!</p>", "p".MakeTag("Awesome!"));

            var dateOfOrderShipped = new DateTime(2021, 3, 21);

            Assert.Equal(2.DaysFromToday().Date, dateOfOrderShipped.Date);
        }
    }
}
