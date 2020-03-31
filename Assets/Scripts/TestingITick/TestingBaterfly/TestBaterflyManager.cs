using UnityEngine;


class TestBaterflyManager : MonoBehaviour
{
    public TestBaterflyController controller { get; private set; }

    public TestBaterflyScriptableObj _cubdata;

    #region UnityMetods
    private void Awake()
    {
        TestBaterflyLoad();
    }
    #endregion

    #region Metods
    private void TestBaterflyLoad()
    {
        controller = new TestBaterflyController(_cubdata);
        controller.OnAwake();
    }
    #endregion 
}

