using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Teleport
{
    public class Teleport : MonoBehaviour
    {
        public void TeleportScript()
        {
            Vector3 pos = transform.position;
            pos.y = Random.Range(1.0f, 3.0f);
            transform.position = pos;
        }
    }
}

