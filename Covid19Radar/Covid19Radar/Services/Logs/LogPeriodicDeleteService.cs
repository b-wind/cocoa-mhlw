﻿/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at https://mozilla.org/MPL/2.0/. */

using Xamarin.Forms;

namespace Covid19Radar.Services.Logs
{
    public interface ILogPeriodicDeleteService
    {
        void Init();
    }

    public class LogPeriodicDeleteService : ILogPeriodicDeleteService
    {
        public void Init() => DependencyService.Get<ILogPeriodicDeleteService>().Init();
    }
}