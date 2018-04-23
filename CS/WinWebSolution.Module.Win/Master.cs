using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinWebSolution.Module.Win
{
    [DefaultClassOptions]
    public class Master : BaseObject
    {
        public Master(Session session) : base(session) { }
        [Association("Master-Children")]
        public XPCollection<Child> Children {
            get {
                return GetCollection<Child>("Children");
            }
        }
        private string _name;
        public string Name {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }
    }
}
