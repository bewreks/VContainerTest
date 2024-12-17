using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace DefaultNamespace
{
    public class Bootstrapper : IInitializable
    {
        [Inject] private IObjectResolver _container;

        public void Initialize()
        {
            Debug.Log("Hello World!");
            Debug.Log(_container);
            var factory = _container.Resolve<Func<Foo>>();
            factory().Initialize();
        }
    }
}
