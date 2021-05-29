using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Partiality.Modloader;
using UnityEngine;

public class RainMod_HideRainMeter : PartialityMod
{
    public RainMod_HideRainMeter()
    {
        this.ModID = "RainMod_HideRainMeter";
        this.Version = "0100";
        this.author = "Uzix";
    }

    public static RainMod_HideRainMeter instance;

    public override void OnEnable()
    {
        base.OnEnable();
        //Hooks go here
        HideRainMeter.Patch();
    }
}
