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
            // �������� ������� ������
            GameObject mainCamera = new GameObject("������� ������");
            mainCamera.AddComponent<Camera>();
            mainCamera.tag = "MainCamera";

            // �������� ��������� ���������
            GameObject light = new GameObject("���������");
            light.AddComponent<Light>();
            light.transform.position = new Vector3(0, 10, 0);

            // �������� ������
            GameObject player = new GameObject("�����");
            GameObject playerModel = new GameObject("������ ������");
            playerModel.transform.parent = player.transform;
            // �������� ����� ��������� ������ ������, ���� ��� ����������

            // �������� ������
            GameObject enemies = new GameObject("�����");
            GameObject enemy1 = new GameObject("���� 1");
            GameObject enemy1Model = new GameObject("������ �����");
            enemy1Model.transform.parent = enemy1.transform;
            // �������� ����� ��������� ������ �����, ���� ��� ����������

            // �������� ���������
            GameObject items = new GameObject("��������");
            GameObject item1 = new GameObject("������� 1");
            GameObject item2 = new GameObject("������� 2");
            // �������� ����� ���������� ���������, ���� ��� ����������

            // �������� ����������� ��������
            GameObject staticObjects = new GameObject("����������� �������");
            GameObject building = new GameObject("������");
            GameObject tree = new GameObject("������");
            // �������� ����� ���������� ����������� ��������, ���� ��� ����������

            // �������� ���������� ������������
            GameObject ui = new GameObject("��������� ������������");
            GameObject scorePanel = new GameObject("������ �����");
            GameObject pauseMenu = new GameObject("���� �����");
            // �������� ����� ���������� ���������� ������������, ���� ��� ����������
        }
    }

}
