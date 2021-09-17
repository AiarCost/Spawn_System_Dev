using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractVehicleFactory 
{
    //public abstract IVehicleFactory CycleFactory();
    //public abstract IVehicleFactory MotorVechicleFactory();

    public abstract IVehicle Create();
}
