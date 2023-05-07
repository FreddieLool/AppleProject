using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoamTest : MonoBehaviour
{
    [SerializeField] GameObject Shattered_Apple;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidbody = this.gameObject.GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.up * 100);
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
            Instantiate(Shattered_Apple, this.gameObject.transform.position, this.gameObject.transform.rotation);
            Destroy(this.gameObject);
    }
}
