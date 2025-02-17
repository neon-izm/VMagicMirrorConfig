﻿namespace Baku.VMagicMirrorConfig
{
    public abstract class SettingViewModelBase : ViewModelBase
    {
        //NOTE: 本当はprivate protectedがしたいが、そのためだけにC# 7.2使うのもアレなのでinternalで済ます
        internal SettingViewModelBase(UdpSender sender)
        {
            _sender = sender;
        }

        private readonly UdpSender _sender;

        //NOTE: 本当はprivate protectedがしたいが、そのためだけにC# 7.2使うのもアレなのでinternalでごまかします
        internal void SendMessage(UdpMessage message)
            => _sender.SendMessage(message);

        private ActionCommand _resetToDefaultCommand;
        public ActionCommand ResetToDefaultCommand
            => _resetToDefaultCommand ?? (_resetToDefaultCommand = new ActionCommand(ResetToDefault));

        private ActionCommand _saveSettingCommand;
        public ActionCommand SaveSettingCommand
            => _saveSettingCommand ?? (_saveSettingCommand = new ActionCommand(SaveSetting));

        private ActionCommand _loadSettingCommand;
        public ActionCommand LoadSettingCommand
            => _loadSettingCommand ?? (_loadSettingCommand = new ActionCommand(LoadSetting));

        protected abstract void ResetToDefault();
        protected abstract void SaveSetting();
        protected abstract void LoadSetting();

        internal abstract void SaveSetting(string path);
        internal abstract void LoadSetting(string path);
    }
}
