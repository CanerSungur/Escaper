using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    /*
        # Spawn Pointleri array icerisine topladik.
    */
    public static Transform[] spawnPoints;
    void Awake()
    {
        spawnPoints = new Transform[transform.childCount];

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            spawnPoints[i] = transform.GetChild(i);
        }
    }
}
