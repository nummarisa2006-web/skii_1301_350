using System;
using Unity.VisualScripting;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverScreen;

    public static Finish Instance;

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Player p = other.gameObject.GetComponent<Player>();

        if(p == null)
            return;

        UIManager.Instance.ShowNotiText($"You Win!!!!! \nHp : {p.HP} \nPoint: {p.Point}");
        Time.timeScale = 0;
    }

    public void ShowHideGameOverScreen(bool flag)
    {
        gameOverScreen.SetActive(flag);
        return;
    }
}

