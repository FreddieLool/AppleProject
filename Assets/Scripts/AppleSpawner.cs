using System.Collections;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    [SerializeField] GameObject throwableObject;
    [SerializeField] Transform spawnPoint;
    [SerializeField] [Range(0.1f, 100f)] float spawnTimer = 1;
    int randomPosition;
    public LayerMask raycastLayerMask;
    bool isRayCastHit = false;
    void Start()
    {
        StartCoroutine(AppleThrowing());
    }

    void Update()
    {
        isRayCastHit = Physics.Raycast(spawnPoint.position, spawnPoint.localPosition, 1000f, raycastLayerMask);
    }
    private void OnDrawGizmos()
    {
        Color gizmoRayColor;

        if (isRayCastHit)
            gizmoRayColor = Color.green;
        else
            gizmoRayColor = Color.magenta;

        Gizmos.color = gizmoRayColor;
        Gizmos.DrawRay(spawnPoint.position, spawnPoint.forward);
    }
    IEnumerator AppleThrowing()
    {
        while (true)
        {
            int randomPosition = Random.Range(1, 4);

            Instantiate(throwableObject, spawnPoint.position, spawnPoint.rotation);
            yield return new WaitForSeconds(spawnTimer);

        }
    }

    void switchRotation()
    {
        switch (randomPosition)
        {
            case 1:
                spawnPoint.rotation = Quaternion.Euler(spawnPoint.rotation.eulerAngles.x,Random.rotation.eulerAngles.y, spawnPoint.rotation.eulerAngles.z);
                break;
            default:
                break;
        }
    }
}
