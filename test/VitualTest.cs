using Xunit;

namespace test
{
    public class VitualTest
    {
        [Fact]
        public void when_child_as_parent()
        {
            Parent parentInitByChild = new Child();
            Assert.Equal("parent method in both", parentInitByChild.methodInBoth());//1-1
            Assert.Equal("parent method only", parentInitByChild.methodInParent());//1-2
            Assert.Equal("Virtual Override in child", parentInitByChild.VitualWithOverride());//2-1
            Assert.Equal("Virtual without override in parent", parentInitByChild.VirtualWithoutOverride());//2-2
            Assert.Equal("Virtual only in parent", parentInitByChild.VirtualOnlyInParent());//2-3
        }

        [Fact]
        public void when_child_as_child()
        {
            Child child = new Child();
            Assert.Equal("child method in both", child.methodInBoth());//1-1
            Assert.Equal("parent method only", child.methodInParent());//1-2
            Assert.Equal("Virtual Override in child", child.VitualWithOverride());//2-1
            Assert.Equal("Virtual without override in child", child.VirtualWithoutOverride());//2-2
            Assert.Equal("Virtual only in parent", child.VirtualOnlyInParent());//2-3
        }

        [Fact]
        public void when_parent_as_parent()
        {
            Parent parent = new Parent();
            Assert.Equal("parent method in both", parent.methodInBoth());//1-1
            Assert.Equal("parent method only", parent.methodInParent());//1-2
            Assert.Equal("Virtual Override in parent", parent.VitualWithOverride());//2-1
            Assert.Equal("Virtual without override in parent", parent.VirtualWithoutOverride());//2-2
            Assert.Equal("Virtual only in parent", parent.VirtualOnlyInParent());//2-3
        }
    }

    public class Parent
    {
        public string methodInBoth()
        {
            return "parent method in both";
        }    
        public string methodInParent()
        {
            return "parent method only";
        }

        public virtual string VitualWithOverride()
        {
            return "Virtual Override in parent";
        }
        public virtual string VirtualWithoutOverride()
        {
            return "Virtual without override in parent";
        }
        public virtual string VirtualOnlyInParent()
        {
            return "Virtual only in parent";
        }
    }

    public class Child : Parent
    {
        public override string VitualWithOverride()
        {
            return "Virtual Override in child";
        }

        public string methodInBoth()
        {
            return "child method in both";
        }
        public string VirtualWithoutOverride()
        {
            return "Virtual without override in child";
        }

    }
}
