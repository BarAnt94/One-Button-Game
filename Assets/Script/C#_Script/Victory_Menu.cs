using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Victory_Menu : MonoBehaviour
{
    public Canvas reloadCanvas;
     public Button reloadButton;
    public Button reloadButton_Menu;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Afficher le Canvas
            reloadCanvas.gameObject.SetActive(true);
            // Activer le bouton de retry
            reloadButton.onClick.AddListener(ReloadLevel);
            reloadButton_Menu.onClick.AddListener(Reload_Menu);
            Player.SetActive(false);
        }
    }
     private void Reload_Menu() 
    {
        SceneManager.LoadScene(0);
    } 
     private void ReloadLevel()
    {
        // Recharger le niveau actuel
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    } 
}
