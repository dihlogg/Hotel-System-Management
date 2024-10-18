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

    [DefaultProperty("idBooking")]
    public partial class BookingDetail : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Booking fidBooking;
        [Association(@"BookingDetailReferencesBooking")]
        [DevExpress.Xpo.DisplayName(@"Người Đặt Phòng")]
        public Booking idBooking
        {
            get { return fidBooking; }
            set { SetPropertyValue<Booking>(nameof(idBooking), ref fidBooking, value); }
        }
        Room fidRoom;
        [Association(@"BookingDetailReferencesRoom")]
        [DevExpress.Xpo.DisplayName(@"Phòng")]
        public Room idRoom
        {
            get { return fidRoom; }
            set { SetPropertyValue<Room>(nameof(idRoom), ref fidRoom, value); }
        }
        DateTime fcheckInDay;
        [DevExpress.Xpo.DisplayName(@"Ngày Đến")]
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"), DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat ", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime checkInDay
        {
            get { return fcheckInDay; }
            set { SetPropertyValue<DateTime>(nameof(checkInDay), ref fcheckInDay, value); }
        }
        DateTime fcheckOutDay;
        [DevExpress.Xpo.DisplayName(@"Ngày Đi")]
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"), DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat ", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime checkOutDay
        {
            get { return fcheckOutDay; }
            set { SetPropertyValue<DateTime>(nameof(checkOutDay), ref fcheckOutDay, value); }
        }
    }

}
