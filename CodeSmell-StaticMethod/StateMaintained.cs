using Xunit;

namespace CodeSmell_StaticMethod
{
    class StateMaintained
    {
        private static int staticVariable;

        public void SetStaticField(int i)
        {
            staticVariable = i;
        }

        public int GetStaticField()
        {
            return staticVariable;
        }
    }
    
    public class StateMaintainedApp
    {
        [Fact]
        public void State_will_be_maintained_across_all_instances_of_a_class()
        {
            var instance1 = new StateMaintained();
            Assert.Equal(0, instance1.GetStaticField());

            instance1.SetStaticField(10);
            Assert.Equal(10, instance1.GetStaticField());

            var instance2 = new StateMaintained();
            Assert.Equal(10, instance2.GetStaticField());
        }
    }
}
