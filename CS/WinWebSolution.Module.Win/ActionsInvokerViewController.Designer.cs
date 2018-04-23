namespace WinWebSolution.Module.Win {
    partial class PopupWindowInvokerViewController {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.saSimpleActionInvoker = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saSingleChoiceActionInvoker = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saPopupWindowShowActionInvoker = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.saParametrizedActionInvoker = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // saSimpleActionInvoker
            // 
            this.saSimpleActionInvoker.Caption = "Call SimpleAction";
            this.saSimpleActionInvoker.Id = "ba558288-4aad-4893-a181-78bdaca65cbe";
            this.saSimpleActionInvoker.Tag = null;
            this.saSimpleActionInvoker.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saSimpleActionInvoker_Execute);
            // 
            // saSingleChoiceActionInvoker
            // 
            this.saSingleChoiceActionInvoker.Caption = "Call SingleChoiceAction";
            this.saSingleChoiceActionInvoker.Id = "abe02ee5-6ea6-4d4b-9010-cfaceb01097c";
            this.saSingleChoiceActionInvoker.Tag = null;
            this.saSingleChoiceActionInvoker.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saSingleChoiceActionInvoker_Execute);
            // 
            // saPopupWindowShowActionInvoker
            // 
            this.saPopupWindowShowActionInvoker.Caption = "Call PopupWindowShowAction";
            this.saPopupWindowShowActionInvoker.Id = "50b348d3-7739-4a83-855d-cbb2a6e1908f";
            this.saPopupWindowShowActionInvoker.Tag = null;
            this.saPopupWindowShowActionInvoker.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saPopupWindowShowActionInvoker_Execute);
            // 
            // saParametrizedActionInvoker
            // 
            this.saParametrizedActionInvoker.Caption = "Call ParametrizedAction";
            this.saParametrizedActionInvoker.Id = "7c8fb0d5-d87d-406a-8387-33e13514bd05";
            this.saParametrizedActionInvoker.Tag = null;
            this.saParametrizedActionInvoker.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.saParametrizedActionInvoker_Execute);
            // 
            // PopupWindowInvokerViewController
            // 
            this.TargetObjectType = typeof(WinWebSolution.Module.Win.Child);
            this.TargetViewNesting = DevExpress.ExpressApp.Nesting.Nested;
            this.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction saSimpleActionInvoker;
        private DevExpress.ExpressApp.Actions.SimpleAction saSingleChoiceActionInvoker;
        private DevExpress.ExpressApp.Actions.SimpleAction saPopupWindowShowActionInvoker;
        private DevExpress.ExpressApp.Actions.SimpleAction saParametrizedActionInvoker;

    }
}
