Namespace WinWebSolution.Win
    Partial Public Class WinWebSolutionWindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.module3 = New WinWebSolution.Module.Win.WinWebSolutionModule()
            Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
            Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
            Me.module7 = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' module5
            ' 
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResult))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResultItem))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RulePropertyValueProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRequiredFieldProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRangeProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleValueComparisonProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleStringComparisonProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleRegularExpressionProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleCriteriaProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleSearchObjectProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleObjectExistsProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleUniqueValueProperties))
            Me.module5.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.Validation.RuleIsReferencedProperties))
            ' 
            ' WinWebSolutionWindowsFormsApplication
            ' 
            Me.ApplicationName = "WinWebSolution"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module6)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module5)
            Me.Modules.Add(Me.module7)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private module3 As WinWebSolution.Module.Win.WinWebSolutionModule
        Private module5 As DevExpress.ExpressApp.Validation.ValidationModule
        Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private module7 As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
    End Class
End Namespace
