using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AcNetwork : AcSingleton<AcNetwork>
{
    bool m_isHost = false;
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public bool StartHost()
    {

        return true;
    }

    public bool Connect(string ip)
    {

        return true;
    }
}
