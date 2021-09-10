using UnityEngine;
using UnityEngine.SceneManagement;

public class Client : MonoBehaviour
{

    public Drone m_Drone;
    public Sniper m_Sniper;
    public Basketball m_Basketball;
    public EnemySpawner m_Spawner;

    private Enemy m_Spawn;
    private int m_IncrementorDrone = 0;
    private int m_IncrementorSniper = 0;
    private int m_IncrementorBasketball = 0;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Drone);

            m_Spawn.name = "Drone_Clone_" + ++m_IncrementorDrone;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorDrone * 1.5f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Sniper);

            m_Spawn.name = "Sniper_Clone_" + ++m_IncrementorSniper;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorSniper * 1.5f);
        }


        if (Input.GetKeyDown(KeyCode.F))
        {
            m_Spawn = m_Spawner.SpawnEnemy(m_Basketball);

            m_Spawn.name = "Basketball_Clone_" + ++m_IncrementorBasketball;
            m_Spawn.transform.Translate(Vector3.forward * m_IncrementorBasketball * 1.5f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(1);
        }
    }
}
