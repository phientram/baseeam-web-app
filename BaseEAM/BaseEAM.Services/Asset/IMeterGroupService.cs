﻿using BaseEAM.Core;
using BaseEAM.Core.Domain;
using BaseEAM.Core.Kendoui;
using System.Collections.Generic;

namespace BaseEAM.Services
{
    public interface IMeterGroupService : IBaseService
    {
        PagedResult<MeterGroup> GetMeterGroups(string expression,
            dynamic parameters,
            int pageIndex = 0,
            int pageSize = 2147483647,
            IEnumerable<Sort> sort = null); //Int32.MaxValue

        List<MeterGroup> GetMeterGroupList(string param);
    }
}
