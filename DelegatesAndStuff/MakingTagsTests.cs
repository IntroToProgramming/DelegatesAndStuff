using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DelegatesAndStuff
{
    public class MakingTagsTests
    {

       [Fact]
       public void CanMakeTagsProcedureally()
        {
            Assert.Equal("<h1>Hello</h1>", TagMaker("h1", "Hello"));
            Assert.Equal("<h1>Goodbye</h1>", TagMaker("h1", "Goodbye"));
            Assert.Equal("<p>Stuff</p>", TagMaker("p", "Stuff"));

            string TagMaker(string element, string content)
            {
                return $"<{element}>{content}</{element}>";
            }

        }
        [Fact]
        public void CanMakeTagsOopStyle()
        {
            var h1Maker = new TagMaker("h1");
            var pMaker = new TagMaker("p");

            Assert.Equal("<h1>Hello</h1>", h1Maker.Make("Hello"));
            Assert.Equal("<h1>Goodbye</h1>", h1Maker.Make("Goodbye"));
            Assert.Equal("<p>Stuff</p>", pMaker.Make("Stuff"));
        }

        [Fact]
        public void CanMakeTagsFunctionalStyle()
        {
            Func<string, Func<string, string>> tagMaker;

            tagMaker = (tag) => (content) => $"<{tag}>{content}</{tag}>";

            var h1Maker = tagMaker("h1");
            var pMaker = tagMaker("p");

            Assert.Equal("<h1>Hello</h1>", h1Maker("Hello"));
            Assert.Equal("<h1>Goodbye</h1>", h1Maker("Goodbye"));
            Assert.Equal("<p>Stuff</p>", pMaker("Stuff"));
        }

       
    }

    public class TagMaker
    {
        private string element;

        public TagMaker(string element)
        {
            this.element = element;
        }

        public string Make(string content)
        {
            return $"<{element}>{content}</{element}>";
        }
    }
}
