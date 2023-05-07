using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Mashot : MonoBehaviour
{
    public Quaternion tempQuat;
    // Start is called before the first frame update
    void Start()
    {
        tempQuat = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            transform.DORotate(new Vector3(transform.rotation.x - 45f, transform.rotation.y, transform.rotation.z), 0.2f).OnComplete(ReturnToNormal).WaitForCompletion();
        }
    }

    public void ReturnToNormal()
    {
        transform.rotation = tempQuat;
    }
}
