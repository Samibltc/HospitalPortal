﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospitalManagement.Models;

namespace HospitalManagement.CollectionViewModels
{
    public class DoctorIndexCollection
    {
        public List<Appointment> Appointments { get; set; }
    }
}