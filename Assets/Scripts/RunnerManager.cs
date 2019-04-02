using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runner
{
    public static class RunnerManager
    {
        private static GameEngine gameEngine;
        public static GameEngine GameEngine
        {
            get
            {
                if (gameEngine == null)
                {
                    Debug.LogError("GameEngine doesn't exist in scene!");
                }
                return gameEngine;
            }
            set
            {
                gameEngine = value;
            }
        }

        private static UIManager uiManager;
        public static UIManager UIManager
        {
            get
            {
                if (uiManager == null)
                {
                    uiManager = GameEngine.GetComponent<UIManager>();
                    if (uiManager == null)
                        Debug.LogError("UIManager doesn't exist!");
                }
                return uiManager;
            }
            set
            {
                uiManager = value;
            }
        }

        private static PlayerManager playerManager;
        public static PlayerManager PlayerManager
        {
            get
            {
                if (playerManager == null)
                {
                    playerManager = GameEngine.GetComponent<PlayerManager>();
                    if (playerManager == null)
                        Debug.LogError("PlayerController doesn't exist!");
                }
                return playerManager;
            }
            set
            {
                playerManager = value;
            }
        }

        private static CamManager camManager;
        public static CamManager CamManager
        {
            get
            {
                if (camManager == null)
                {
                    camManager = GameEngine.GetComponent<CamManager>();
                    if (camManager == null)
                        Debug.LogError("CamManager doesn't exist!");
                }
                return camManager;
            }
            set
            {
                camManager = value;
            }
        }

        private static EnemySpawner enemySpawner;
        public static EnemySpawner EnemySpawner
        {
            get
            {
                if (enemySpawner == null)
                {
                    enemySpawner = GameEngine.GetComponent<EnemySpawner>();
                    if (enemySpawner == null)
                        Debug.LogError("EnemySpawner doesn't exist!");
                }
                return enemySpawner;
            }
            set
            {
                enemySpawner = value;
            }
        }

        private static EnemyManager enemyManager;
        public static EnemyManager EnemyManager
        {
            get
            {
                if (enemyManager == null)
                {
                    enemyManager = GameEngine.GetComponent<EnemyManager>();
                    if (enemyManager == null)
                        Debug.LogError("EnemyManager doesn't exist!");
                }
                return enemyManager;
            }
            set
            {
                enemyManager = value;
            }
        }

        private static PlatformManager platformManager;
        public static PlatformManager PlatformManager
        {
            get
            {
                if (platformManager == null)
                {
                    platformManager = GameEngine.GetComponent<PlatformManager>();
                    if (platformManager == null)
                    {
                        Debug.LogError("PlatformManager doesn't exist!");
                    }
                }
                return platformManager;
            }
            set
            {
                platformManager = value;
            }
        }

        private static TriggerChecker checker;
        public static TriggerChecker Checker
        {
            get
            {
                if (checker == null)
                {
                    checker = GameEngine.GetComponent<TriggerChecker>();
                    if (checker == null)
                    {
                        Debug.LogError("PlatformManager doesn't exist!");
                    }
                }
                return checker;
            }
            set
            {
                checker = value;
            }
        }

        private static SaveGameManager saveGame;
        public static SaveGameManager SaveGame
        {
            get
            {
                if(saveGame == null)
                {
                    saveGame = GameEngine.GetComponent<SaveGameManager>();
                    if(saveGame == null)
                    {
                        Debug.LogError("SaveGameManager doesn't exist!");
                    }
                }
                return saveGame;
            }
            set
            {
                saveGame = value;
            }
        }

        private static PlayerChecker playerChecker;
        public static PlayerChecker PlayerChecker
        {
            get
            {
                if (playerChecker == null)
                {
                    playerChecker = GameEngine.GetComponent<PlayerChecker>();
                    if (playerChecker == null)
                    {
                        Debug.LogError("SaveGameManager doesn't exist!");
                    }
                }
                return playerChecker;
            }
            set
            {
                playerChecker = value;
            }
        }
    }
}