﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.API.Utilities
{
    public class SkyrimModule : IModule
    {
        string IModule.Name
        {
            get { return "Skyrim"; }
        }

        GameType IModule.GameType
        {
            get { return GameType.kSkyrim; }
        }
    }
}
