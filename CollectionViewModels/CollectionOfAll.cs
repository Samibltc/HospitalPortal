using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospitalManagement.Models;

namespace HospitalManagement.CollectionViewModels
{
    public class CollectionOfAll
    {
        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
        public IEnumerable<Patient> Patients { get; set; }     
        public IEnumerable<Appointment> ActiveAppointments { get; set; }
        public IEnumerable<Appointment> PendingAppointments { get; set; }
    }
}