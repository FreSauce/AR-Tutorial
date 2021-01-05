using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ObjectToSpawn;
    private PlacementIndicator placementIndicator;

    private void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();

    }

    private void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(ObjectToSpawn, placementIndicator.transform.position, placementIndicator.transform.rotation);

        }
    }
}
