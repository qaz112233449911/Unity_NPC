using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// NPC
/// 定義 NPC 方法
/// </summary>
/// <param name="dialogue">NPC 要說的對話內容</param>
public class NPC : MonoBehaviour
{
    private void Dialogue(string dialogue)
    {

    }
    
    /// <summary>
    /// 開啟商店
    /// </summary>
    /// <returns></returns>
    public bool Openstore()
    {
        return true;
    }
    
    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="price"></param>
    /// <returns></returns>
    public int BuyProp(int price = 100)
    {
        return 0;
    }
    
    /// <summary>
    /// 取得任務
    /// </summary>
    /// <param name="indexMission"></param>
    public void GetMission(int indexMission)
    {

    }
    
    /// <summary>
    /// 更新任務
    /// </summary>
    /// <param name="propMission"></param>
    /// <returns></returns>
    private int UpdateMissiom(int propMission = 1)
    {
        return 0;
    }
    
    /// <summary>
    /// 完成任務
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
