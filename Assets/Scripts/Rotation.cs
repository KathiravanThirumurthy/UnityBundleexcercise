using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private float rotationInDegrees = 600.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotAmount = rotationInDegrees * Time.deltaTime;
        float currentzRotation = transform.localRotation.eulerAngles.z;
        float currentyRotation = transform.localRotation.eulerAngles.y;
        float currentxRotation = transform.localRotation.eulerAngles.x;
        transform.localRotation = Quaternion.Euler(new Vector3(0, currentyRotation + rotAmount, currentzRotation + rotAmount));
        // Why use localRotaion instead of Transform.Rotation ?
        /*
         * When you use transform.rotation, it returns the objects rotation in global space, and turn it,
         * How matter what the rotation of it’s parent is. Using localRotation turns the object with respect to it’s parent rotation. 
         */
        // What is Quaternion.eulerAngles?
        /*
         * 
        Objects in Unity are rotated using a concept called a Quaternion. It allows objects to be rotated in any way in 3D space,
        and are very hard to visualize. They use x,y,z,and w, and some imaginary number i,j, and k to work. 
        Luckily they can be created using Euler Angles which is what we all know and love.

         */
    }
}
