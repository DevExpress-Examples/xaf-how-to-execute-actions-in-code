<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128590153/22.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1393)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# XAF - How to execute Actions programmatically

This example explains how you can trigger the code inside `Execute` event handlers of custom or standard XAF Actions. For example, you can programmatically invoke an Action that shows a View or runs code in the background.

> **NOTE** 
> We do not recommend this approach. Refactor your Action's event handlers and extract required code into separate methods. Call these separate methods directly without triggering UI-related Action code.

![image](https://user-images.githubusercontent.com/14300209/227978022-a50434fa-413f-4634-b0ba-09936fd82927.png)

## Implementation Details

### SimpleAction

`mySimpleAction.DoExecute();`

### ParametrizedAction

`myParametrizedAction.DoExecute("test value");`

Make sure that the parameter type matches `ParametrizedAction.ValueType`. A string is used in this example.

### SingleChoiceAction

`mySingleChoiceAction.DoExecute(mySingleChoiceAction.Items[0]);`

Make sure the pass a parameter that's a valid item from `SingleChoiceAction.Items`. This example passes the first item in the collection.

### PopupWindowShowAction (Display a Dialog Window)

We do not provide public API to execute a PopupWindowShowAction. Use the [ShowViewStrategyBase.ShowViewInPopupWindow(View, Action, Action, String, String)](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ShowViewStrategyBase.ShowViewInPopupWindow(DevExpress.ExpressApp.View-System.Action-System.Action-System.String-System.String)) method to show a View in a pop-up window.

## Files to Review

* [ActionsInvokerViewController.cs](./CS/EFCore/ExecuteActionEF/ExecuteActionEF.Module/Controllers/ActionInvokerViewController.cs)
