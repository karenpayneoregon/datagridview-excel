
namespace WindowFormsControlsLibrary
{
    /// <summary>
    /// VS2019 there is no BindingNavigator, here you go :-)
    /// </summary>
    public sealed class CoreBindingNavigator : BindingNavigator
    {
        public CoreBindingNavigator()
        {
            AddStandardItems();
        }
    }
}
