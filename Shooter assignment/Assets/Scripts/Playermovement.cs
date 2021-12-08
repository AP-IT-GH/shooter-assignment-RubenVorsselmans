using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float _Speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float _Offset = horizontal + Time.deltaTime * _Speed;
        float _NewPos = _Offset + transform.localPosition.x;
        transform.localPosition = new Vector3(Mathf.Clamp(_NewPos, -10, 10), transform.localPosition.y, transform.localPosition.z);
    }
}
