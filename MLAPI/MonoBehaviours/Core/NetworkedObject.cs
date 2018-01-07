﻿using UnityEngine;

namespace MLAPI
{
    //TODO
    //Will be used for objects which will be spawned automatically across clients
    public class NetworkedObject : MonoBehaviour
    {
        [HideInInspector]
        public uint NetworkId;
        [HideInInspector]
        public int OwnerClientId = -1;
        [HideInInspector]
        public int SpawnablePrefabId;
        [HideInInspector]
        public bool IsPlayerObject = false;
        public bool ServerOnly = false;
        public bool isLocalPlayer
        {
            get
            {
                return OwnerClientId == NetworkingManager.singleton.MyClientId;
            }
        }

        private void OnDestroy()
        {
            NetworkingManager.OnDestroyObject(NetworkId);
        }
    }
}
