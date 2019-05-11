using UnityEngine;
using UnityEngine.Networking;

public class Example : NetworkBehaviour
{
    //Assign the Prefab in the Inspector
    public GameObject objecttt;

    void Start()
    {
        //Instantiate the Prefab
        //Spawn the GameObject you assign in the Inspector
        NetworkServer.Spawn(objecttt);
    }
}