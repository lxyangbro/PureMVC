using UnityEngine;

namespace Examples
{
    public class StartGame : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            new ApplicationFacade(this.gameObject);
        }
    }
}
