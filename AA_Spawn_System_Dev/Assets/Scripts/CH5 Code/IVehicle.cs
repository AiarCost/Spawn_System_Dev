using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Area where interface and spawnable objects that use the interface

public interface IVehicle { }
public class Unicycle : IVehicle { };
public class Bicycle : IVehicle { };
public class MotorCycle : IVehicle { };
public class Truck : IVehicle { };



//Another interface that uses IVehicle inferface function
public interface IVehicleFactory
{
    IVehicle Create(VehicleRequirements requirements);
}