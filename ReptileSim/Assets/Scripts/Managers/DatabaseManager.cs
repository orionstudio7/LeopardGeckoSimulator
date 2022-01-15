using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DatabaseManager : MonoBehaviour
{
    public static DatabaseManager instance;
    private Database database;
    public NeedsController needsController;

    private void Awake()
    {
        database = new Database();
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More than one DatabaseManager in the Scene");
    }

    private void Update()
    {
        if(NeedsManager.instance.gameHourTimer < 0)
        {
            Pet pet = new Pet
                (needsController.lastTimeFed.ToString(),
                needsController.lastTimeHappy.ToString(),
                needsController.lastTimeGainedEnergy.ToString(),
                needsController.food,
                needsController.happiness,
                needsController.energy
                );
            SavePet(pet);
        }
    }

    private void Start()
    {
        Pet pet = LoadPet();
        if (pet != null)
        {
            needsController.Initialize
                (
                pet.food,
                pet.happiness,
                pet.energy,
                10,10,10
//                DateTime.Parse(pet.lastTimeFed),
//                DateTime.Parse(pet.lastTimeHappy),
//                DateTime.Parse(pet.lastTimeGainedEnergy)
                );
        }
    }

    public void SavePet(Pet pet)
    {
        database.SaveData("pet", pet);
    }

    public Pet LoadPet()
    {
        Pet returnValue = null;
        database.LoadData<Pet>("pet", (pet) =>
        {
            returnValue = pet;
        });
        return returnValue;
    }

}
