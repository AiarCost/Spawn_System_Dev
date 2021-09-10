using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;
    private INPC m_Thief;
    public void SpawnVillagers()
    {
        // We don't want to specify the class to instiate for each type of villager
        // Instead, we ask the factory to "manufacture" it for us.

        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
        m_Thief = m_Factory.GetNPC(NPCType.Thief);

        m_Beggar.Speak();
        m_Farmer.Speak();
        m_Shopowner.Speak();
        m_Thief.Speak();
    }
}
