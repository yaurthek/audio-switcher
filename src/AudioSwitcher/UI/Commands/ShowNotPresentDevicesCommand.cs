﻿// -----------------------------------------------------------------------
// Copyright (c) David Kean.
// -----------------------------------------------------------------------
using System;
using System.ComponentModel.Composition;
using AudioSwitcher.Presentation.CommandModel;

namespace AudioSwitcher.UI.Commands
{
    [Command(CommandId.ShowNotPresentDevices)]
    internal class ShowNotPresentDevicesCommand : Command
    {
        [ImportingConstructor]
        public ShowNotPresentDevicesCommand()
        {
            Text = Resources.ShowNotPresentDevices;
            Image = Icons.NotPresent;
        }

        public override void Refresh()
        {
            IsChecked = Settings.Default.ShowNotPresentDevices;
        }

        public override void Run()
        {
            Settings.Default.ShowNotPresentDevices = !Settings.Default.ShowNotPresentDevices;
        }
    }
}
