using BoDi;
using InnaFeature.Helpers.Browser;

namespace InnaFeature.Hooks
{
    [Binding]
    internal class Hooks
    {
        private readonly IObjectContainer _container;

        public Hooks(IObjectContainer container)
        {
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }


        [BeforeScenario(Order = 1)]
        public void RegisterBrowserService()
        {
            _container.RegisterTypeAs<BrowserHelper, IBrowserHelper>();
        }


        [AfterScenario]
        public void Teardown(IBrowserHelper helper)
        {
            helper.Teardown();
        }
    }
}
