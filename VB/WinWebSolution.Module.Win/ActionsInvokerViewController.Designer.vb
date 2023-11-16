Namespace WinWebSolution.[Module].Win

    Partial Class PopupWindowInvokerViewController

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.saSimpleActionInvoker = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
            Me.saSingleChoiceActionInvoker = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
            Me.saPopupWindowShowActionInvoker = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
            Me.saParametrizedActionInvoker = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
            ' 
            ' saSimpleActionInvoker
            ' 
            Me.saSimpleActionInvoker.Caption = "Call SimpleAction"
            Me.saSimpleActionInvoker.Id = "ba558288-4aad-4893-a181-78bdaca65cbe"
            Me.saSimpleActionInvoker.Tag = Nothing
            AddHandler Me.saSimpleActionInvoker.Execute, New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(AddressOf Me.saSimpleActionInvoker_Execute)
            ' 
            ' saSingleChoiceActionInvoker
            ' 
            Me.saSingleChoiceActionInvoker.Caption = "Call SingleChoiceAction"
            Me.saSingleChoiceActionInvoker.Id = "abe02ee5-6ea6-4d4b-9010-cfaceb01097c"
            Me.saSingleChoiceActionInvoker.Tag = Nothing
            AddHandler Me.saSingleChoiceActionInvoker.Execute, New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(AddressOf Me.saSingleChoiceActionInvoker_Execute)
            ' 
            ' saPopupWindowShowActionInvoker
            ' 
            Me.saPopupWindowShowActionInvoker.Caption = "Call PopupWindowShowAction"
            Me.saPopupWindowShowActionInvoker.Id = "50b348d3-7739-4a83-855d-cbb2a6e1908f"
            Me.saPopupWindowShowActionInvoker.Tag = Nothing
            AddHandler Me.saPopupWindowShowActionInvoker.Execute, New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(AddressOf Me.saPopupWindowShowActionInvoker_Execute)
            ' 
            ' saParametrizedActionInvoker
            ' 
            Me.saParametrizedActionInvoker.Caption = "Call ParametrizedAction"
            Me.saParametrizedActionInvoker.Id = "7c8fb0d5-d87d-406a-8387-33e13514bd05"
            Me.saParametrizedActionInvoker.Tag = Nothing
            AddHandler Me.saParametrizedActionInvoker.Execute, New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(AddressOf Me.saParametrizedActionInvoker_Execute)
            ' 
            ' PopupWindowInvokerViewController
            ' 
            Me.TargetObjectType = GetType(WinWebSolution.[Module].Win.Child)
            Me.TargetViewNesting = DevExpress.ExpressApp.Nesting.Nested
            Me.TargetViewType = DevExpress.ExpressApp.ViewType.ListView
        End Sub

#End Region
        Private saSimpleActionInvoker As DevExpress.ExpressApp.Actions.SimpleAction

        Private saSingleChoiceActionInvoker As DevExpress.ExpressApp.Actions.SimpleAction

        Private saPopupWindowShowActionInvoker As DevExpress.ExpressApp.Actions.SimpleAction

        Private saParametrizedActionInvoker As DevExpress.ExpressApp.Actions.SimpleAction
    End Class
End Namespace
