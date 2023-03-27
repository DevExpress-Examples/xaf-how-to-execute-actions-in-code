using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;


using System.IO;
using System.ComponentModel;
using MySolution.Module.BusinessObjects;

namespace dxTestSolution.Module.Controllers {
    public class ActionInvokerViewController : ObjectViewController<ListView, Contact> {
        public ActionInvokerViewController() {

            var callSimpleAction = new SimpleAction(this, "СallSimpleAction(Refresh)", PredefinedCategory.Edit);
            callSimpleAction.Execute += saSimpleActionInvoker_Execute;

            var callSingleChoice = new SimpleAction(this, "CallSingleChoiceAction(New)", PredefinedCategory.Edit);
            callSingleChoice.Execute += saSingleChoiceActionInvoker_Execute;

            //var callPopupAction = new SimpleAction(this, "callPopupAction", PredefinedCategory.Edit);
            //callPopupAction.Execute += saPopupWindowShowActionInvoker_Execute;

            var callParametrized = new SimpleAction(this, "CallParametrizedAction(Filter)", PredefinedCategory.Edit);
            callParametrized.Execute += saParametrizedActionInvoker_Execute;
        }

        // This code uses undocumented API. Thoroughly test it before using in production. We can change or even remove this code with any update. We will not support this code and solutions based on it.
        //private void saPopupWindowShowActionInvoker_Execute(object sender, SimpleActionExecuteEventArgs e) {
        //    LinkUnlinkController linkUnlinkController = Frame.GetController<LinkUnlinkController>();
        //    if (linkUnlinkController != null) {
        //        var popupWindowParams = linkUnlinkController.LinkAction.GetPopupWindowParams();
        //        ShowViewParameters showViewParameters = new ShowViewParameters(popupWindowParams.View);
        //        showViewParameters.Controllers.Add(popupWindowParams.DialogController);
        //        showViewParameters.TargetWindow = TargetWindow.NewModalWindow;
        //        Application.ShowViewStrategy.ShowView(showViewParameters, new ShowViewSource(null, null));
        //    }
        //}


        private void saSingleChoiceActionInvoker_Execute(object sender, SimpleActionExecuteEventArgs e) {
            NewObjectViewController newObjectViewController = Frame.GetController<NewObjectViewController>();
            if (newObjectViewController != null) {
                newObjectViewController.NewObjectAction.DoExecute(newObjectViewController.NewObjectAction.Items[0]);
            }
        }
        private void saSimpleActionInvoker_Execute(object sender, SimpleActionExecuteEventArgs e) {
            RefreshController refreshController = Frame.GetController<RefreshController>();
            if (refreshController != null) {
                refreshController.RefreshAction.DoExecute();
            }
        }
        private void saParametrizedActionInvoker_Execute(object sender, SimpleActionExecuteEventArgs e) {
            FilterController filterController = Frame.GetController<FilterController>();
            if (filterController != null) {
                filterController.FullTextFilterAction.DoExecute("FirstName3");
            }
        }
    }
}
