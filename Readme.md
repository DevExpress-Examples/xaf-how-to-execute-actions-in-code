<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128590153/22.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1393)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ActionsInvokerViewController.cs](./CS/EFCore/ExecuteActionEF/ExecuteActionEF.Module/Controllers/ActionInvokerViewController.cs) 
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

We don't have a public API to execute a PopupWindowShowAction. Use the [ShowViewStrategyBase.ShowViewInPopupWindow(View, Action, Action, String, String)](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ShowViewStrategyBase.ShowViewInPopupWindow(DevExpress.ExpressApp.View-System.Action-System.Action-System.String-System.String)) method to show a view in a popup.



![image](https://user-images.githubusercontent.com/14300209/227978022-a50434fa-413f-4634-b0ba-09936fd82927.png)

