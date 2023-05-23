using PureMVC.Interfaces;
using PureMVC.Patterns.Command;

namespace Examples
{
    public class DataCommand : SimpleCommand
    {
        /// <summary>
        /// 执行方法
        /// </summary>
        /// <param name="notification"></param>
        public override void Execute(INotification notification)
        {
            // 调用数据层的“增加等级”的方法
            DataProxy dataProxy = Facade.RetrieveProxy(DataProxy.NAME) as DataProxy;
            dataProxy.AddLevel(5);
        }
    }
}
