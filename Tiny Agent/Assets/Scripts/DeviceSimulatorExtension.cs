//#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using UnityEditor.DeviceSimulation;

public class DeviceSimulatorExtension : MonoBehaviour//DeviceSimulatorPlugin
{
    // public override string title => "UI Scenerios";
    // bool isWeaponListShow = false;
    // public override VisualElement OnCreateUI()
    // {
    //     VisualElement weaponList_VE = new VisualElement();
    //     var virtualTree_weaponList = Resources.Load<VisualTreeAsset>("WeaponListUI");
    //     virtualTree_weaponList.CloneTree(weaponList_VE);

    //     Toggle weaponToggle = weaponList_VE.Q<Toggle>("WeaponToggle");
    //     Button weaponButton = weaponList_VE.Q<Button>("WeaponButton");
    //     weaponToggle.RegisterCallback<ChangeEvent<bool>>((evt) =>
    //     {
    //         isWeaponListShow = evt.newValue;
    //     });
    //     weaponButton.clicked += ShowWeaponList;

    //     return weaponList_VE;
    // }

    // private void ShowWeaponList()
    // {
    //     GameObject weaponList = GameObject.FindGameObjectWithTag("WeaponList");
    //     GameObject smallWeaponList = GameObject.FindGameObjectWithTag("SmallWeaponList");
    //     if(weaponList != null && smallWeaponList != null)
    //     {
    //         CanvasGroup WeaponListcanvasGroup = weaponList.GetComponent<CanvasGroup>();
    //         CanvasGroup SmallWeaponListcanvasGroup = smallWeaponList.GetComponent<CanvasGroup>();
    //         if(isWeaponListShow)
    //         {
    //             WeaponListcanvasGroup.alpha = 1;
    //             WeaponListcanvasGroup.interactable = true;
    //             SmallWeaponListcanvasGroup.alpha = 0;
    //             SmallWeaponListcanvasGroup.interactable = false;
    //         }
    //         else
    //         {
    //             WeaponListcanvasGroup.alpha = 0;
    //             WeaponListcanvasGroup.interactable = false;
    //             SmallWeaponListcanvasGroup.alpha = 1;
    //             SmallWeaponListcanvasGroup.interactable = true;
    //         }
    //     }
    // }
}
//#endif