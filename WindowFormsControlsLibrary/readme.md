# About

Library for custom controls.

## CoreBindingNavigator

Since Visual Studio 2019/2022 for .NET Core projects does not provide a BindingNavigator in the Visual Studio toolbox the component CoreBindingNavigator provides access in the toolbox.

### Caveats

- Disabling and enabling ToolStrip items does not work well in the collection editor so there are methods provided.
- Adding new items to the collection does not provide the ability to name the items. Rather than write this into CoreBindingNavigator for advance users, add a item than open the designer and modify as needed. For other developers before doing this backup the form in case of errors as one really should never edit a form designer file.

