using PureMVC.Patterns.Proxy;

namespace Examples
{
    public class DataProxy : Proxy
    {
        // new 覆盖子类同名字段
        public new const string NAME = "DataProxy";

        // 数据实例
        private MyData _MyData = null;

        /// <summary>
        /// 构造函数
        /// </summary>
        public DataProxy() : base(NAME)
        {
            _MyData = new MyData();
        }

        /// <summary>
        /// 增加玩家的等级
        /// </summary>
        /// <param name="addNum"></param>
        public void AddLevel(int addNum)
        {
            // 把参数累加到 实体类 中
            _MyData.Level += addNum;

            // 把变化的数据，发送给 视图层
            SendNotification("Msg_AddLevel", _MyData);
        }
    }
}