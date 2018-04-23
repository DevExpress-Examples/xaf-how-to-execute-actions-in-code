using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;

namespace WinWebSolution.Module.Win {
    public class Child : BaseObject {
        public Child(Session session) : base(session) { }
        private string _name;
        public string Name {
            get { return _name; }
            set { SetPropertyValue("Name", ref _name, value); }
        }
        private Master _master;
        [Association("Master-Children")]
        public Master Master {
            get { return _master; }
            set { SetPropertyValue("Master", ref _master, value); }
        }
    }
}
