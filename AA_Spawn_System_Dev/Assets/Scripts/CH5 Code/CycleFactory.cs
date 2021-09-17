using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//The factories that are going to be used

public class CycleFactory : MonoBehaviour, IVehicleFactory
{
    public IVehicle Create(VehicleRequirements requirements)
    {
        switch (requirements.NumberofPassengers)
        {
            case 1:
                if (requirements.NumberofWheels == 1)
                    return new Unicycle();
                return new Bicycle();
            default:
                return new Bicycle();
                

        }
    }
}


public class MotorVehicleFactory: MonoBehaviour, IVehicleFactory
{
    public IVehicle Create(VehicleRequirements requirements)
    {
        switch (requirements.NumberofPassengers)
        {
            case 1:
                return new MotorCycle();
            default:
                return new Truck();
        }
    }



}

