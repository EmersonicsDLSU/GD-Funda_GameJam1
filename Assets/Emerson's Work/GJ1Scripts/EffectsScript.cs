using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsScript : MonoBehaviour
{
    public float destructionTimer = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        destructionTimer -= Time.deltaTime;
        if(destructionTimer <= 0.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
