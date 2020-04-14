using System.IO;
using UnityEngine;


namespace BeastHunter
{
    [CreateAssetMenu(fileName = "Data", menuName = "DataTest")]
    public sealed class Data : ScriptableObject
    {
        #region Fields

        public static SphereData _sphereData;

        public static TestBaterflyData _testBaterflyData;

        #endregion


        #region Properties

        public static SphereData SphereData
        {
            get
            {
                if (_sphereData == null)
                {
                    _sphereData = Resources.Load<SphereData>("Data/SphereData");
                }
                return _sphereData;
            }
        }

        public static TestBaterflyData TestBaterflyData
        {
            get
            {
                if (_testBaterflyData == null)
                {
                    _testBaterflyData = Resources.Load<TestBaterflyData>("Data/TestBaterflyData");
                }
                return _testBaterflyData;
            }
        }


        #endregion
    }
}