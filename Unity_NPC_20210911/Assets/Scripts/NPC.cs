using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// NPC
/// �w�q NPC ��k
/// </summary>
/// <param name="dialogue">NPC �n������ܤ��e</param>
public class NPC : MonoBehaviour
{
    private void Dialogue(string dialogue)
    {

    }
    
    /// <summary>
    /// �}�Ұө�
    /// </summary>
    /// <returns></returns>
    public bool Openstore()
    {
        return true;
    }
    
    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="price"></param>
    /// <returns></returns>
    public int BuyProp(int price = 100)
    {
        return 0;
    }
    
    /// <summary>
    /// ���o����
    /// </summary>
    /// <param name="indexMission"></param>
    public void GetMission(int indexMission)
    {

    }
    
    /// <summary>
    /// ��s����
    /// </summary>
    /// <param name="propMission"></param>
    /// <returns></returns>
    private int UpdateMissiom(int propMission = 1)
    {
        return 0;
    }
    
    /// <summary>
    /// ��������
    /// </summary>
    /// <param name="indexMission"></param>
    /// <returns></returns>
    private bool MissionFinish(int indexMission)
    {
        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
