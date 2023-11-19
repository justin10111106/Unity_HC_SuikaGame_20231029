using UnityEngine;  //單行註解之優訥體的函式庫

namespace JK
{
   
     
    /// <summary>
    /// 給予角色移動的公式左右亂跑
    /// </summary>
    public class ControlSystem : MonoBehaviour
    {
        /*練習與註解
        //欄位Field
        //儲存遊戲內的資料

        //常用的資料類型
        //整  數 int
        //浮點數 float
        //字  串 string
        //布林值 bool

        //欄位語法
        //修飾詞 欄位資料類型 欄位名稱 指定 值;
        //修飾詞：公開public，顯示資料但危險
        //修飾詞：私人private(預設)，隱藏資料在後台
        //浮動值給數值時，結尾部分請給小或大f
        //布林值表邏輯判斷
        public int level = 1;
        public float coolingDown = 4.5f;
        public string skillName = "阿密豆腐";
        public bool isDead = false;



        //喚醒功能：播放遊戲開始執行一次
        private void Awake()
        {
            print("<color=green>喚醒事件</color>");
        }
        //開始事件：在Awake後執行一次
        private void Start()
        {
            print("<color=blue>開始事件</color>");
        }
        //更新事件：約1秒鐘執行60次（60FPS）
        private void Update()
        {
            print("<color=red>更新事件</color>");
        }*/
    [Header("移動速度"),Range(0,50)]
    public float moveSpeed = 2f;
    [Header("左邊界"),Tooltip("這是角色左邊極限")]
    public float limitLeft = -4.5f;
    [Header("右邊界"),Tooltip("這是角色右邊極限")]
    public float limitRight = 4.5f;

    }
}