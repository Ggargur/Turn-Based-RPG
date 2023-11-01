using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace RPG.UI
{
    enum PageType
    {
        Pause,
        MainMenu,
        InGame,
        None

    }

    class UiManager : MonoBehaviour
    {
        [SerializeField] private UiPage[] _openPages;
        private Dictionary<PageType, UiPage> _pages = new();

    }

    class UiPage : MonoBehaviour
    {
        public UnityEvent OnOpenPage;
        public UnityEvent OnClosePage;
        [SerializeField] private PageType _type = PageType.None;

        public bool CheckTyping(PageType desired) => _type == desired;

        public void Close() => gameObject.SetActive(false);

        public void Open() => gameObject.SetActive(true);

        private void OnDisable() {
            OnClosePage?.Invoke();
        }
        private void OnEnable() {
            OnOpenPage?.Invoke();
        }
    }
}