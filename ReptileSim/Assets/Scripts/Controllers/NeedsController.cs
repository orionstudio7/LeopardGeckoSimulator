using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class NeedsController : MonoBehaviour
{
    
    
    public int food, happiness, energy; 
    
    public int foodTickRate, happinessTickRate, energyTickRate;
    
    public DateTime lastTimeFed, lastTimeHappy, lastTimeGainedEnergy;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        this.food = food;
        this.happiness = happiness;
        this.energy = energy;
    }

    // Update is called once per frame
    void Update()
    {
    
        if(NeedsManager.gameHourTimer < 0)
        {
            ChangeFood(-foodTickRate);
            ChangeHappy(-happinessTickRate);
            ChangeEnergy(-energyTickRate);
        }
        
        
        
    }
    
    
    public void ChangeFood(int amount)
    {
        food += amount;
        
        if (food<0){
            PetManager.instance.Sick();
        }
        else if (food > 100) {food = 100;}
    }
    
    public void ChangeHappy(int amount)
    {
        happiness += amount;
        
        
        if (happiness<0){
            PetManager.instance.Sick();
        }
        else if (happiness > 100) {happiness = 100;}
    }
    
    public void ChangeEnergy(int amount)
    {
        energy += amount;
        
        
        if (energy<0){
            PetManager.instance.Sick();
        }
        
        else if (energy > 100) {energy = 100;}
    }
}
