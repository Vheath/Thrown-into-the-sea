using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text scoreText;
    int layerMask = 1 << 8;
    public static int scoreCount;
    RaycastHit hit;
    public float distance = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreCount.ToString();
        if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hit.collider.tag == "Shell")
                {
                    hit.collider.GetComponent<Floater>().PickUp();
                }
            }
        }




    }
}
