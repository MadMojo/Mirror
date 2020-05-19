﻿using Mirror;


namespace WeaverSyncVarHookTests.AutoDetectsStaticHook
{
    class AutoDetectsStaticHook : NetworkBehaviour
    {
        [SyncVar(hook = nameof(onChangeHealth))]
        int health;

        static void onChangeHealth(int oldValue, int newValue)
        {

        }
    }
}
