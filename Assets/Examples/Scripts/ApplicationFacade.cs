using PureMVC.Patterns.Facade;
using UnityEngine;

namespace Examples
{
    public class ApplicationFacade : Facade
    {
        public ApplicationFacade(GameObject goRootNode)
        {
            /* MVC 三层的关联绑定 */
            // 控制层注册（命令消息 与控制层类的对应关系，建立绑定）
            RegisterCommand("Reg_StartDataCommand", ()=> { return new DataCommand(); });
           
 
            // 视图层注册
            RegisterMediator(new DataMediator(goRootNode));
            // 模型层注册
            RegisterProxy(new DataProxy());
        }
    }
}