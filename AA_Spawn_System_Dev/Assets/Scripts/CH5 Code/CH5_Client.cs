using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//The user interface where they get to choose what they want with the spawn system

public class CH5_Client : MonoBehaviour
{

    public int Wheels = 0;
    public bool HasEngine = false;
    public int Passengers = 0;
    public bool HasCargo = false;

    VehicleRequirements requirements = new VehicleRequirements();


    // Start is called before the first frame update
    void Start()
    {
        requirements.NumberofWheels = Wheels;
        requirements.Engine = HasEngine;
        requirements.NumberofPassengers = Passengers;
        requirements.Cargo = HasCargo;

        var vehicle = GetVehicle(requirements);

        Debug.Log(vehicle);
    }



    private static IVehicle GetVehicle(VehicleRequirements requirements)
    {
        //VehicleFactory factory = new VehicleFactory();
        //IVehicle vehicle;

        //if (requirements.Engine)
        //{
        //    return factory.MotorVechicleFactory().Create(requirements);
        //}

        //return factory.CycleFactory().Create(requirements);

        VehicleFactory factory = new VehicleFactory(requirements);
        return factory.Create();
    }
}
