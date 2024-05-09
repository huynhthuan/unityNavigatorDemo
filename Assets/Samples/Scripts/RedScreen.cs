using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using ZBase.UnityScreenNavigator.Core.Screens;

namespace Samples.Scripts
{
    public class RedScreen : ZBase.UnityScreenNavigator.Core.Screens.Screen
    {
        [SerializeField] private Button _button;

        public override UniTask Initialize(Memory<object> args)
        {
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => {
                ScreenContainer.Of(transform).Pop(true);
            });
            return UniTask.CompletedTask;
        }
    }
}