﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace ManageHotel.Module.BusinessObjects.Staff
{

    [DefaultProperty("name")]
    public partial class Counterparty : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fname;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"Đối Tác")]
        public string name
        {
            get { return fname; }
            set { SetPropertyValue<string>(nameof(name), ref fname, value); }
        }
        string femail2;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"Email Đối Tác")]
        public string email2
        {
            get { return femail2; }
            set { SetPropertyValue<string>(nameof(email2), ref femail2, value); }
        }
        string fphone2;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"Số Điện Thoại Đối Tác")]
        public string phone2
        {
            get { return fphone2; }
            set { SetPropertyValue<string>(nameof(phone2), ref fphone2, value); }
        }
        string faddress2;
        [DevExpress.Xpo.DisplayName(@"Địa Chỉ Đối Tác")]
        public string address2
        {
            get { return faddress2; }
            set { SetPropertyValue<string>(nameof(address2), ref faddress2, value); }
        }
        Staff fidStaff;
        [Association(@"CounterpartyReferencesStaff")]
        [DevExpress.Xpo.DisplayName(@"Nhân Viên Tạo")]
        public Staff idStaff
        {
            get { return fidStaff; }
            set { SetPropertyValue<Staff>(nameof(idStaff), ref fidStaff, value); }
        }
        [Association(@"CustomerReferencesCounterparty"), Aggregated]
        public XPCollection<Customer> Customers { get { return GetCollection<Customer>(nameof(Customers)); } }
    }

}
