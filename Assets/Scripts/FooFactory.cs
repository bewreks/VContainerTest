using VContainer;

namespace DefaultNamespace
{
    public class FooFactory
    {
        [Inject]
        
        public Foo Create()
        {
            return new Foo();
        }
    }
}
