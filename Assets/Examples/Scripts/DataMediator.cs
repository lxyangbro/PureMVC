using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns.Mediator;
using UnityEngine;
using UnityEngine.UI;

namespace Examples
{
    public class DataMediator : Mediator
    {
        // 定义名称
        public new const string NAME = "DataMediator";
 
        // 定义显示的控件
        private Text Level_Text;
        private Button AddLevel_Button;
 
        public DataMediator(GameObject goRootNode) :base(NAME)
        {
 
            // 查找赋值显示控件
            Level_Text = goRootNode.transform.Find("Level_Text").GetComponent<Text>();
            AddLevel_Button = goRootNode.transform.Find("AddLevel_Button").GetComponent<Button>();
 
            // 按钮注册事件
            AddLevel_Button.onClick.AddListener(OnClickAddLevelListener);
        }
 
        /// <summary>
        /// 按钮点击事件监听
        /// </summary>
        private void OnClickAddLevelListener() {
            // 定义消息，发送控制层
            SendNotification("Reg_StartDataCommand");
        }
 
        public override string[] ListNotificationInterests()
        {
 
            List<string> listResult = new List<string>();
 
            // 可以接收的消息集合
            listResult.Add("Msg_AddLevel");
 
            return listResult.ToArray();
 
        }
 
        public override void HandleNotification(INotification notification)
        {
            switch (notification.Name)
            {
                case "Msg_AddLevel":
                    // 把模型层发来的数据，显示到控件上
                    Level_Text.text = (notification.Body as MyData).Level.ToString();
 
                    break;
 
                default:
                    break;
            }
        }
    }
}
