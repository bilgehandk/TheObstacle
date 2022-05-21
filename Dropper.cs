using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private MeshRenderer renderer;
    private Rigidbody rigidBody;
    [SerializeField] float timeToWait = 5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            rigidBody.useGravity = true;
            renderer.enabled = true;
        }
    }
}
