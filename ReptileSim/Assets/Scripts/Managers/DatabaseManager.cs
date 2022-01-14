using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class DatabaseManager : MonoBehaviour
{
    private Database database;
   
    public static DatabaseManager instance;
    void Start()
    {
        
        if (instance == null)
        {
            instance = this;
        }
        
        
        Pet pet = LoadPet();
        if( pet != null){ Debug.Log(LoadPet().energy);}
    }


    private void update()
    {
//        if(TimingManager.gameHourTimer<0)
//        {
//        
//            Pet pet = new Pet();
//        }
    }
    public void Save(Pet pet)
    {

        database.SaveData<Pet>("pet",pet);
    }

    public Pet LoadPet()
    {

        Pet returnValue = null;
        database.LoadData<Pet>("pet",(pet) =>
        {
        
            returnValue = pet;
        });
        
        return returnValue;

    }

}