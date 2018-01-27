using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group : MonoBehaviour
{

    public class Goth : MonoBehaviour
    {
        private static int reputation;

        int getRep ()
        {
            return reputation;
        }

        void modifyRep (int rep)
        {
            reputation += rep;
        }
    }

    public class Jock : MonoBehaviour
    {
        public int reputation;
    }

    public class Scene : MonoBehaviour
    {
        public int reputation;
    }

    public class Plastic : MonoBehaviour
    {
        public int reputation;
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
