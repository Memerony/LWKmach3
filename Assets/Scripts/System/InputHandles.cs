﻿using System;
using UnityEngine.UI;
using Zenject;

namespace LWT.System
{
    /// <summary>
    /// Обработчик UI элементов
    /// </summary>
    public class InputHandles : IInitializable
    {
        public event Action StartGameClick;
        public event Action CouponClick;
        public event Action SettingClick;

        public event Action LoginClick;
        public event Action ShowRegistrationClick;
        public event Action RegistrationBackClick;
        public event Action ShowRestorePasswordClick;
        public event Action RestorePasswordBackClick;
        public event Action ShowPasswordClick;
        public event Action RegistrationClick;
        public event Action RestorePasswordClick;

        private readonly MenuUIElements menuElements;
        private readonly StartUIElements startElements;

        public InputHandles(MenuUIElements menuElements, StartUIElements startElements)
        {
            this.menuElements = menuElements;
            this.startElements = startElements;
        }

        public void Initialize()
        {
            menuElements.StartGame.onClick.AddListener(() => StartGameClick?.Invoke());
            menuElements.Coupon.onClick.AddListener(() => CouponClick?.Invoke());
            menuElements.Setting.onClick.AddListener(() => SettingClick?.Invoke());

            startElements.Login.onClick.AddListener(() => LoginClick?.Invoke());
            startElements.ShowRegistration.onClick.AddListener(() => ShowRegistrationClick?.Invoke());
            startElements.RegistrationBack.onClick.AddListener(() => RegistrationBackClick?.Invoke());
            startElements.ShowRestorePassword.onClick.AddListener(() => ShowRestorePasswordClick?.Invoke());
            startElements.RestorePasswordBack.onClick.AddListener(() => RestorePasswordBackClick?.Invoke());
            startElements.ShowPassword.onClick.AddListener(() => ShowPasswordClick?.Invoke());
            startElements.Registration.onClick.AddListener(() => RegistrationClick?.Invoke());
            startElements.RestorePassword.onClick.AddListener(() => RestorePasswordClick?.Invoke());
        }

        [Serializable]
        public class MenuUIElements
        {
            public Button StartGame;
            public Button Coupon;
            public Button Setting;
        }

        [Serializable]
        public class StartUIElements
        {
            public Button Login;
            public Button ShowRegistration;
            public Button ShowRestorePassword;
            public Button RegistrationBack;
            public Button RestorePasswordBack;
            public Button ShowPassword;
            public Button Registration;
            public Button RestorePassword;
        }
    }
}