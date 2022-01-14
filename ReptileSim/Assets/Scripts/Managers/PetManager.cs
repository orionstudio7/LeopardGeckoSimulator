using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetManager : MonoBehaviour
{
    public PetController pet;
    public float petMoveTimer, originalPetMoveTimer;
    public Transform[] waypoints;
    public NeedsController needsController;
    // Start is called before the first frame update
    
    public static PetManager instance;
    void Start()
    {
        originalPetMoveTimer = petMoveTimer;
        
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Update()
    {
    
        if(petMoveTimer > 0)
        {
            petMoveTimer-=Time.deltaTime;
        }
        
        else
        {
            MovePetToRandomWayPoint();
            petMoveTimer = originalPetMoveTimer;
        }
    }
    
    private void MovePetToRandomWayPoint()
    {
        int randomWayPoint = Random.Range(0,waypoints.Length);
        pet.Move(waypoints[randomWayPoint].position);
    }
    
    public void Die()
    {
    
    }
    
     public void Sick()
    {
        Debug.Log("Pet is sick!");
    }
    
}
