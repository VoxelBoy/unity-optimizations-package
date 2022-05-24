﻿using UnityEditor;
using UnityEngine;

namespace Editor.CrazyGames.WindowComponents
{
    public class About
    {
        public static void RenderGUI()
        {
            EditorGUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();

            GUILayout.Label(
                "The purpose of this package is to help you optimize your game, by reducing the build size and increasing the performance. At the moment, it is target to WebGL games.",
                EditorStyles.wordWrappedLabel);

            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();
        }
    }
}