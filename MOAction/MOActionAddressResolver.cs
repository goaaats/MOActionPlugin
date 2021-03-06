﻿using Dalamud.Game;
using Dalamud.Game.Internal;
using System;

namespace MOActionPlugin
{
    class MOActionAddressResolver : BaseAddressResolver
    {

        public IntPtr RequestAction { get; private set; }

        public IntPtr SetUiMouseoverEntityId { get; private set; }

        protected override void Setup64Bit(SigScanner sig)
        {
            this.RequestAction = sig.ScanText("40 53 55 57 41 54 41 57 48 83 EC 60 83 BC 24 ?? ?? ?? ?? ?? 49 8B E9 45 8B E0 44 8B FA 48 8B F9 41 8B D8 74 14 80 79 68 00 74 0E 32 C0 48 83 C4 60 41 5F 41 5C 5F 5D 5B C3");

            this.SetUiMouseoverEntityId = sig.ScanText("48 89 91 ?? ?? ?? ?? C3 CC CC CC CC CC CC CC CC 48 89 5C 24 ?? 55 56 57 48 81 EC ?? ?? ?? ?? 48 8B 05 ?? ?? ?? ?? 48 33 C4 48 89 84 24 ?? ?? ?? ?? 48 8D B1 ?? ?? ?? ?? 44 89 44 24 ?? 48 8B EA 48 8B D9 48 8B CE 48 8D 15 ?? ?? ?? ?? 41 B9 ?? ?? ?? ??");
        }
    }
}
