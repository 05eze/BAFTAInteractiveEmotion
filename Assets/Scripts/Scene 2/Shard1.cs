using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shard1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Player")
        {
            GameVariables.shardCount += 2;
            Destroy(gameObject);
        }

    }
}
