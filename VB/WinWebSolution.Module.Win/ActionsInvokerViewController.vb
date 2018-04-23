Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.ExpressApp.Win
Imports DevExpress.ExpressApp.SystemModule

Namespace WinWebSolution.Module.Win
    Partial Public Class PopupWindowInvokerViewController
        Inherits ViewController

        Public Sub New()
            InitializeComponent()
            RegisterActions(components)
        End Sub
        Private Sub saPopupWindowShowActionInvoker_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles saPopupWindowShowActionInvoker.Execute
            Dim linkUnlinkController As LinkUnlinkController = Frame.GetController(Of LinkUnlinkController)()
            If linkUnlinkController IsNot Nothing Then
                 Call (New PopupWindowShowActionHelper(linkUnlinkController.LinkAction)).ShowPopupWindow()
            End If
        End Sub
        Private Sub saSingleChoiceActionInvoker_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles saSingleChoiceActionInvoker.Execute
            Dim newObjectViewController As NewObjectViewController = Frame.GetController(Of NewObjectViewController)()
            If newObjectViewController IsNot Nothing Then
                newObjectViewController.NewObjectAction.DoExecute(newObjectViewController.NewObjectAction.Items(0))
            End If
        End Sub
        Private Sub saSimpleActionInvoker_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles saSimpleActionInvoker.Execute
            Dim refreshController As RefreshController = Frame.GetController(Of RefreshController)()
            If refreshController IsNot Nothing Then
                refreshController.RefreshAction.DoExecute()
            End If
        End Sub
        Private Sub saParametrizedActionInvoker_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles saParametrizedActionInvoker.Execute
            Dim filterController As FilterController = Frame.GetController(Of FilterController)()
            If filterController IsNot Nothing Then
                filterController.FullTextFilterAction.DoExecute("test value")
            End If
        End Sub
    End Class
End Namespace
