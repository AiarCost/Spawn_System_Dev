using UnityEngine;

public class ClientCH3 : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnerNPC.SpawnVillagers();
        }
    }
}
