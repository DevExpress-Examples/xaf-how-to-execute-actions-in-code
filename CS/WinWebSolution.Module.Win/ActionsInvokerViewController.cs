using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.SystemModule;

namespace WinWebSolution.Module.Win {
    public partial class PopupWindowInvokerViewController : ViewController {
        public PopupWindowInvokerViewController() {
            InitializeComponent();
            RegisterActions(components);
        }
        private void saPopupWindowShowActionInvoker_Execute(object sender, SimpleActionExecuteEventArgs e) {
            LinkUnlinkController linkUnlinkController = Frame.GetController<LinkUnlinkController>(); 
            if(linkUnlinkController != null) { 
                 new PopupWindowShowActionHelper(linkUnlinkController.LinkAction).ShowPopupWindow();
            }
        }
        private void saSingleChoiceActionInvoker_Execute(object sender, SimpleActionExecuteEventArgs e) {
            NewObjectViewController newObjectViewController = Frame.GetController<NewObjectViewController>(); 
            if(newObjectViewController != null) {
                newObjectViewController.NewObjectAction.DoExecute(newObjectViewController.NewObjectAction.Items[0]);
            }
        }
        private void saSimpleActionInvoker_Execute(object sender, SimpleActionExecuteEventArgs e) {
            RefreshController refreshController = Frame.GetController<RefreshController>(); 
            if(refreshController != null) {
                refreshController.RefreshAction.DoExecute();
            }
        }
        private void saParametrizedActionInvoker_Execute(object sender, SimpleActionExecuteEventArgs e) {
            FilterController filterController = Frame.GetController<FilterController>(); 
            if(filterController != null) {
                filterController.FullTextFilterAction.DoExecute("test value");
            }
        }
    }
}
