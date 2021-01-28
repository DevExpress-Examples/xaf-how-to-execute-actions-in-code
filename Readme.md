<!-- default file list -->
*Files to look at*:

* [ActionsInvokerViewController.cs](./CS/WinWebSolution.Module.Win/ActionsInvokerViewController.cs) (VB: [ActionsInvokerViewController.vb](./VB/WinWebSolution.Module.Win/ActionsInvokerViewController.vb))
<!-- default file list end -->
# How to execute Actions in code

## Scenario

Normally, XAF Actions are executed only by end users using the interaction with UI elements (for instance, button clicks, navigation, or main menu selection). In advanced UI scenarios, XAF developers may want to programmatically trigger the code inside the Execute event handlers of custom or standard XAF Actions. For instance, a XAF developer wants to execute default Action logic that shows a View or runs some code in the background.

In general, this is rarely needed and is not recommended because there are always better solutions. For instance, you may avoid this if you refactor your Action's Execute and other event handlers and extract the required code into separate methods (then, you can call these methods directly without triggering the UI-related Action code).

## Solution

### SimpleAction

`mySimpleAction.DoExecute();`

### ParametrizedAction

`myParametrizedAction.DoExecute("test value"); // Mind the ParametrizedAction.ValueType. Here, a string is used as an example.`

### SingleChoiceAction

`mySingleChoiceAction.DoExecute(mySingleChoiceAction.Items[0]); // Mind the SingleChoiceAction.Items structure. Here, the first item is used as an example.`

### PopupWindowShowAction (to display a dialog window)

Use the [ShowViewStrategyBase.ShowViewInPopupWindow(View, Action, Action, String, String)](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ShowViewStrategyBase.ShowViewInPopupWindow(DevExpress.ExpressApp.View-System.Action-System.Action-System.String-System.String)) method that works for all XAF UI platforms.

>*NOTE*: `PopupWindowShowActionHelper` demonstrated in this example is WinForms-specific and is not widely used. PopupWindowShowActionHelper and its related parts are **internal and undocumented APIs** that can be changed without notice in the future. We will not be able to provide any formal support for these internal APIs either. That said, use it at your own risk. If you describe your business task in greater detail, our team will be in a better position to describe alternative options here.
