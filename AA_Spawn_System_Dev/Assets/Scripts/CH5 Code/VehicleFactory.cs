using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleFactory : AbstractVehicleFactory
{
    //public override IVehicleFactory CycleFactory()
    //{
    //    return new CycleFactory();
    //}

    //public override IVehicleFactory MotorVechicleFactory()
    //{
    //    return new MotorVehicleFactory();
    //}


    private readonly IVehicleFactory _factory;
    private readonly VehicleRequirements _requirements;


    public VehicleFactory (VehicleRequirements requirements)
    {
        // We check if the requirements need an engine, if yes Motor Fac, no Cycle Fac
        _factory = requirements.Engine ? (IVehicleFactory)new MotorVehicleFactory() : new CycleFactory();
        _requirements = requirements;
    }


    public override IVehicle Create()
    {
        return _factory.Create(_requirements);
    }
}
