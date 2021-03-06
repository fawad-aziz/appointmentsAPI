﻿using AppointmentsAPI.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppointmentsAPI.Business.Data.Contracts
{
    public interface IAppointmentDataService
    {
        Task<List<Appointment>> GetAppointments();

        Task<Appointment> CreateAppointment(Appointment appointment);
    }
}
