using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetController : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Animator petAnimator;
    
    private Vector3 destination;
    public float speed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, destination) > 0.5f)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, speed);
        }
    }
    
    
    public void Move(Vector3 destination)
    {
        this.destination = destination;
    }
    public void Happy()
    {
//        petAnimator.setTrigger("Happy");
    }
    
    public void Sad()
    {
//        petAnimator.setTrigger("Sad");
    }
    
    public void Sick()
    {
//        petAnimator.setTrigger("Sick");
    }
    
    public void Hungry()
    {
//        petAnimator.setTrigger("Hungry");
    }
    public void Eat()
    {
//        petAnimator.setTrigger("Eat");
    }
}
