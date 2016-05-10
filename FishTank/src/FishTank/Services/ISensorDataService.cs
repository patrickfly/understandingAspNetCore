﻿using FishTank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishTank.Services
{
    public interface ISensorDataService
    {
        IntHistoryModel GetWaterTemperatureFahrenheit();
        IEnumerable<IntHistoryModel> GetWaterTemperatureFahrenheitHistory();

        IntHistoryModel GetFishMotionPercentage();
        IEnumerable<IntHistoryModel> GetFishMotionPercentageHistory();

        IntHistoryModel GetWaterOpacityPercentage();
        IEnumerable<IntHistoryModel> GetWaterOpacityPercentageHistory();

        IntHistoryModel GetLightIntensityLumens();
        IEnumerable<IntHistoryModel> GetLightIntensityLumensHistory();
    }
}
