using UnityEngine;
using VContainer.Unity;

namespace DefaultNamespace
{
    public class Foo : IInitializable
    {

        public void Initialize()
        {
            Debug.Log("Hello World!2");
        }
    }
}
