using ConsoleApp.Challenges.hashmap_left_join;
using ConsoleApp.Challenges.hashtable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject2
{
    public class TestLeftJoin
    {
        [Fact]
        public void Test1()
        {
            Hashtable hashtable1 = new Hashtable(5);
            hashtable1.Set("fond", "enamored");
            hashtable1.Set("wrath", "anger");
            hashtable1.Set("diligent", "employed");
            hashtable1.Set("outift", "garb");
            hashtable1.Set("guide", "usher");

            Hashtable hashtable2 = new Hashtable(5);
            hashtable2.Set("fond", "averse");
            hashtable2.Set("wrath", "delight");
            hashtable2.Set("diligent", "idle");
            hashtable2.Set("guide", "follow");
            hashtable2.Set("flow", "jam");

            HashmapLeftJoin leftJoin = new HashmapLeftJoin();
            List<string> expected = new List<string>() {
           "[fond:enamored,averse]", "[wrath:anger,delight]",
           "[diligent:employed,idle]", "[outift:garb,]", "[guide:usher,follow]"
            };
            Assert.Equal(expected, leftJoin.LeftJoin(hashtable1, hashtable2));

        }
        [Fact]
        public void Test2()
        {
            Hashtable hashtable1 = new Hashtable(5);
            hashtable1.Set("fond", "enamored");
            hashtable1.Set("wrath", "anger");
            hashtable1.Set("diligent", "employed");
            hashtable1.Set("outift", "garb");
            hashtable1.Set("guide", "usher");

            Hashtable hashtable2 = new Hashtable(5);
            hashtable2.Set("fond", "averse");
            hashtable2.Set("wrath", "delight");
            hashtable2.Set("diligent", "idle");
            hashtable2.Set("guide", "follow");
            hashtable2.Set("flow", "jam");

            HashmapLeftJoin leftJoin = new HashmapLeftJoin();
            List<string> expected = new List<string>() {
           "[fond:enamored,averse]", "[wrath:anger,delight]",
           "[diligent:employed,null]", "[outift:garb,]", "[guide:usher,follow]"
            };
            Assert.NotEqual(expected, leftJoin.LeftJoin(hashtable1, hashtable2));

        }
        [Fact]
        public void Test3()
        {
            Hashtable hashtable1 = new Hashtable(0);
            Hashtable hashtable2 = new Hashtable(0);
            HashmapLeftJoin leftJoin = new HashmapLeftJoin();
            Exception ex = Assert.Throws<Exception>(() => leftJoin.LeftJoin(hashtable1, hashtable2));
            Assert.Equal("Hashtable is empty", ex.Message);

        }
    }
}