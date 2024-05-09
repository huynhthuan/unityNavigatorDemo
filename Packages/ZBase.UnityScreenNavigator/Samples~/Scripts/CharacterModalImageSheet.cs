using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using ZBase.UnityScreenNavigator.Core.Sheets;

namespace Demo.Scripts
{
    public class CharacterModalImageSheet : Sheet
    {
        [SerializeField] private Image _image;

        private int _characterId;
        private int _rank;

        public void Setup(int characterId, int rank)
        {
            _characterId = characterId;
            _rank = rank;
        }
        public override async UniTask WillEnter(Memory<object> args)
        {
            var handle = DemoAssetLoader.AssetLoader.LoadAsync<Sprite>(ResourceKey.CharacterSprite(_characterId, _rank));
            await handle.Task;
            _image.sprite = handle.Result;
        }

    }

}