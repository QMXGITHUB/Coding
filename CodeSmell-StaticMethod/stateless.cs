using Xunit;

namespace CodeSmell_StaticMethod
{
    public class Stateless
    {
        public static void ChangeValue(Child child, Child child1)
        {
            var height = child.Height;
            child.Height = child1.Height;
            child1.Height = height;
        }
    }

    public class StatelessApp
    {
        [Fact]
        public void Change_state_inside_static_method()
        {
            var first = new Child(1);
            var second = new Child(2);
            Assert.Equal(1, first.Height);
            Assert.Equal(2, second.Height);

            Stateless.ChangeValue(first, second);
            Assert.Equal(2, first.Height);
            Assert.Equal(1, second.Height);
        }
    }

    public class Child
    {
        public Child(int i)
        {
            Height = i;
        }

        public int Height { get; set; }
    }
}