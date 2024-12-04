using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject explosion; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public AudioClip lightFade;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayFade()
    {
        AudioSource.PlayClipAtPoint(lightFade, Camera.main.transform.position);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //Debug.Log("BOOM!");
            Instantiate(explosion, transform.position, Quaternion.identity);
            PlayFade();
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

}
