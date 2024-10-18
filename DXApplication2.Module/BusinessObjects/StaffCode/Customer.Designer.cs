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

    [DefaultProperty("fullName")]
    public partial class Customer : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string ffullName;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"Họ Tên")]
        public string fullName
        {
            get { return ffullName; }
            set { SetPropertyValue<string>(nameof(fullName), ref ffullName, value); }
        }
        string faddress;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"Địa Chỉ")]
        public string address
        {
            get { return faddress; }
            set { SetPropertyValue<string>(nameof(address), ref faddress, value); }
        }
        string fphone;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"Số Điện Thoại")]
        public string phone
        {
            get { return fphone; }
            set { SetPropertyValue<string>(nameof(phone), ref fphone, value); }
        }
        string femail;
        public string email
        {
            get { return femail; }
            set { SetPropertyValue<string>(nameof(email), ref femail, value); }
        }
        DateTime fdateOfBirth;
        [DevExpress.Xpo.DisplayName(@"Ngày Sinh")]
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy"), DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat ", "{0:dd/MM/yyyy}")]
        public DateTime dateOfBirth
        {
            get { return fdateOfBirth; }
            set { SetPropertyValue<DateTime>(nameof(dateOfBirth), ref fdateOfBirth, value); }
        }
        string fidentity;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"Mã Định Danh/Hộ Chiếu")]
        public string identity
        {
            get { return fidentity; }
            set { SetPropertyValue<string>(nameof(identity), ref fidentity, value); }
        }
        Staff fidStaff;
        [Association(@"CustomerReferencesStaff")]
        [DevExpress.Xpo.DisplayName(@"Nhân Viên Tạo")]
        public Staff idStaff
        {
            get { return fidStaff; }
            set { SetPropertyValue<Staff>(nameof(idStaff), ref fidStaff, value); }
        }
        Counterparty fidCounterparty;
        [Association(@"CustomerReferencesCounterparty")]
        [DevExpress.Xpo.DisplayName(@"Đối Tác Bảo Lãnh")]
        public Counterparty idCounterparty
        {
            get { return fidCounterparty; }
            set { SetPropertyValue<Counterparty>(nameof(idCounterparty), ref fidCounterparty, value); }
        }
        [Association(@"BookingReferencesCustomer"), Aggregated]
        public XPCollection<Booking> Bookings { get { return GetCollection<Booking>(nameof(Bookings)); } }
    }

}
