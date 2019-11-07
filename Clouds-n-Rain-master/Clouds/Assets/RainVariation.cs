using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainVariation : MonoBehaviour
{
    //First, define everything 
    ParticleSystem Rain;
    ParticleSystem.EmissionModule rainModule;
    // Start is called before the first frame update
    void Start()
    {
        //Set definitions and call for value setters

        Rain = gameObject.GetComponent<ParticleSystem>();
        rainModule = Rain.emission;

        GetValue();
        SetValue();
    }
    void GetValue() //gathers constant minimums and maximums for how much I want it to rain over the course of the simulation. Not all storms are uniform
    {
        print(string.Format("The constant values are: min {0} max {1}.", rainModule.rateOverTime.constantMin, rainModule.rateOverTime.constantMax));
    }

    void SetValue() //Set the hard numbers that the system flips between to get a constantly-changing effect. minimal but there.
    {
        rainModule.rateOverTime = new ParticleSystem.MinMaxCurve(150f, 550f);
    }
} 
