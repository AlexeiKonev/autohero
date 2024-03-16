using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace autohero.old
{
   

    public class SceneStructureCreator : MonoBehaviour
    {
        [MenuItem("Tools/Create Scene Structure")]
        public  void CreateSceneStructure()
        {
            // Создание главной камеры
            GameObject mainCamera = new GameObject("Главная камера");
            mainCamera.AddComponent<Camera>();
            mainCamera.tag = "MainCamera";

            // Создание источника освещения
            GameObject light = new GameObject("Освещение");
            light.AddComponent<Light>();
            light.transform.position = new Vector3(0, 10, 0);

            // Создание игрока
            GameObject player = new GameObject("Игрок");
            GameObject playerModel = new GameObject("Модель игрока");
            playerModel.transform.parent = player.transform;
            // Добавьте здесь компонент модели игрока, если это необходимо

            // Создание врагов
            GameObject enemies = new GameObject("Враги");
            GameObject enemy1 = new GameObject("Враг 1");
            GameObject enemy1Model = new GameObject("Модель врага");
            enemy1Model.transform.parent = enemy1.transform;
            // Добавьте здесь компонент модели врага, если это необходимо

            // Создание предметов
            GameObject items = new GameObject("Предметы");
            GameObject item1 = new GameObject("Предмет 1");
            GameObject item2 = new GameObject("Предмет 2");
            // Добавьте здесь компоненты предметов, если это необходимо

            // Создание статических объектов
            GameObject staticObjects = new GameObject("Статические объекты");
            GameObject building = new GameObject("Здание");
            GameObject tree = new GameObject("Дерево");
            // Добавьте здесь компоненты статических объектов, если это необходимо

            // Создание интерфейса пользователя
            GameObject ui = new GameObject("Интерфейс пользователя");
            GameObject scorePanel = new GameObject("Панель счета");
            GameObject pauseMenu = new GameObject("Меню паузы");
            // Добавьте здесь компоненты интерфейса пользователя, если это необходимо
        }
    }

}
