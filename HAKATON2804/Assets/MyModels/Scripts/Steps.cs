using UnityEngine;


public class Steps : MonoBehaviour
{
    FirstPersonController myController;
    public AudioClip[] stepsWater;
    public AudioClip[] stepsTerrain;

    void Start()
    {
        myController = GetComponent<FirstPersonController>();
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,-transform.up,out hit, 2))
        {
            if (hit.collider.tag == ("SurfaceWater"))
            {
                
            }
            else
            {
                
            }
        }
    }
}