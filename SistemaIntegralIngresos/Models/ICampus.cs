﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIntegralIngresos.Models
{
    public interface ICampus
    {
        List<Campus> GetAllCampus();
        Boolean InsertCampus(Campus campus);
        Boolean DeleteCampus(int id);
        Campus FindByID (int id);
        Boolean EditCampus(Campus campus);
    }
}
