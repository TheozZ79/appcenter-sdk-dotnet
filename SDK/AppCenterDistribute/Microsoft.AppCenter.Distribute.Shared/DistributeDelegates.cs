// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.AppCenter.Distribute
{
    /// <summary>
    /// Release available callback.
    /// </summary>
    public delegate bool ReleaseAvailableCallback(ReleaseDetails releaseDetails);

    /// <summary>
    /// App will close callback.
    /// </summary>
    public delegate void WillExitAppCallback();

    /// <summary>
    /// No release available callback.
    /// </summary>
    public delegate void NoReleaseAvailableCallback();
}
