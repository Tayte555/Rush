using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float sens = 2f;
    public Transform leftAndRight;
    float upAndDown = 0f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sens;
        float mouseY = Input.GetAxis("Mouse Y") * sens;

        //rotating player body left and right
        leftAndRight.Rotate(Vector3.up * mouseX);

        //clamping player camera rotation
        upAndDown = Mathf.Clamp(upAndDown, -90, 90);

        //rotating player camera up and down
        upAndDown -= mouseY;
        transform.localRotation = Quaternion.Euler(upAndDown, 0f, 0f);
    }
}
