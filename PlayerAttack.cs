using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject lemonLight; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Light()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Lemon Light!"); 
            Instantiate(lemonLight, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
}
