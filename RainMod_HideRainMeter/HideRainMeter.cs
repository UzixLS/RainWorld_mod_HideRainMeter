using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RWCustom;

public class HideRainMeter
{
    public static void Patch()
    {
        On.HUD.RainMeter.Draw += RainMeter_Draw;
    }

    private static void RainMeter_Draw(On.HUD.RainMeter.orig_Draw orig, HUD.RainMeter self, float timeStacker)
    {
        return;
    }
}
