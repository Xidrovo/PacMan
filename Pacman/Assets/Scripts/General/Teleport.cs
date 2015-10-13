using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    public GameObject TeleportA, TeleportB;

    private Vector3 Temp;
    void OnCollisionEnter2D(Collision2D Coll)
    {
        if (Coll.gameObject == TeleportA)
        {
            Temp = TeleportB.transform.position;
            Temp.x = TeleportB.transform.position.x - 0.5f;

            this.transform.position = Temp;
        }
        if (Coll.gameObject == TeleportB)
        {
            Temp = TeleportA.transform.position;
            Temp.x = TeleportA.transform.position.x + 0.5f;

            this.transform.position = Temp;
        }
    }
}
