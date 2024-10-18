using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace ManageHotel.Module.BusinessObjects.Staff
{

    public partial class Contract
    {
        public Contract(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
