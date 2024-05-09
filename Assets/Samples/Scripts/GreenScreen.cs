using System;
using Cysharp.Threading.Tasks;
using Demo.Scripts;
using UnityEngine;
using UnityEngine.UI;
using ZBase.UnityScreenNavigator.Core.Screens;
using ZBase.UnityScreenNavigator.Core.Views;

namespace Samples.Scripts
{
    public class GreenScreen : ZBase.UnityScreenNavigator.Core.Screens.Screen
    {
        [SerializeField] private Button _button;

        public override UniTask Initialize(Memory<object> args)
        {
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => {
                var options = new ViewOptions(ResourceKey.RedScreenPrefab());
                ScreenContainer.Of(transform).Push(options);
            });
            return UniTask.CompletedTask;
        }
    }
}