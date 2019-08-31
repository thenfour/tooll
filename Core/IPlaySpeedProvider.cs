// Copyright (c) Framefield. All rights reserved.
// Released under the MIT license. (see LICENSE.txt)

using System;

namespace Framefield.Core
{
    // The playback system implements this in order to provide access to Operators.
    public interface IPlaySpeedProvider
    {
        double PlaySpeed { get; }
        event EventHandler PlaySpeedChanged;
    }
}
