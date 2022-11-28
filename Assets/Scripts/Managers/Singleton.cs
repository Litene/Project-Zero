using Unity.VisualScripting;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour {
    private static T _instance;
    public static T Instance {
        get {
            if (_instance != null) return _instance;
            _instance = FindObjectOfType<T>();
            _instance ??= GenerateSingleton();
            return _instance;
        }
    }
    private static T GenerateSingleton() {
        GameObject gameManagerObject = new GameObject(typeof(T).Name);
        return gameManagerObject.AddComponent<T>();
    }
}

